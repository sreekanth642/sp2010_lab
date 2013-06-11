//--------------------------------------------------------------------------------
// This file is a "Sample" from the SharePoint Foundation 2010
// Samples
//
// Copyright (c) Microsoft Corporation. All rights reserved.
//
// This source code is intended only as a supplement to Microsoft
// Development Tools and/or on-line documentation.  See these other
// materials for detailed information regarding Microsoft code samples.
// 
// THIS CODE AND INFORMATION ARE PROVIDED AS IS WITHOUT WARRANTY OF ANY
// KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
// IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
// PARTICULAR PURPOSE.
//--------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.SharePoint;
using System.Xml;

namespace LinqDemoPrepare
{
    class Program
    {
        static void Main(string[] args)
        {
            string siteURL = "http://demo2010a";
            if (args.Length == 1)
            {
                siteURL = args[0];
            }

            // Connect to SP and open SP List
            Console.Write(String.Format("Connecting to URL {0}  ...", siteURL));
            SPWeb spWeb = new SPSite(siteURL).OpenWeb();
            Console.WriteLine("Opened");

            // Create SPLists
            DeleteAndCreateLists(spWeb);

            // Import data for Project list
            ImportListData(spWeb, "Projects", GetProjectsData());

            // Import data for Employees list
            ImportListData(spWeb, "Employees", GetEmployeesData());
        }

        static void DeleteAndCreateLists(SPWeb spWeb)
        {
            // Delete any existing Employees list using Client API
            try
            {
                SPList empList = spWeb.Lists["Demo"];
                Console.Write("Deleting existing Demo List ...");
                empList.Delete();
                spWeb.Update();
                Console.WriteLine("Done");
            }
            catch (ArgumentException) { }

            // Delete any existing Employees list using Client API
            try
            {
                SPList empList = spWeb.Lists["Employees"];
                Console.Write("Deleting existing Employees List ...");
                empList.Delete();
                spWeb.Update();
                Console.WriteLine("Done");
            }
            catch (ArgumentException) { }

            // Delete any existing Projects list using client API
            try
            {
                SPList projList = spWeb.Lists["Projects"];
                Console.Write("Deleting existing Projects List ...");
                projList.Delete();
                spWeb.Update();
                Console.WriteLine("Done");
            }
            catch (ArgumentException) { }

            // Delete any existing Demo list using Client API
            try
            {
                SPList empList = spWeb.Lists["Demo"];
                Console.Write("Deleting existing Demo List ...");
                empList.Delete();
                spWeb.Update();
                Console.WriteLine("Done");
            }
            catch (ArgumentException) { }

            // Create Projects List using Client API
            Console.Write("Creating Projects List ...");
            Guid pListGuid = spWeb.Lists.Add("Projects", "Company Projects", SPListTemplateType.GenericList);
            spWeb.Update();
            Console.WriteLine("Done");

            // Projects List columns
            Console.Write("Adding Columns to Projects List ...");
            SPList pList = spWeb.Lists[pListGuid];
            pList.OnQuickLaunch = true;
            SPField pTitleIDField = pList.Fields["Title"];
            //pTitleIDField.Title = "Project Name";
            //pTitleIDField.Update();
            FixupField(pList, pList.Fields.Add("Description", SPFieldType.Text, false));
            FixupField(pList, pList.Fields.Add("Due Date", SPFieldType.DateTime, false));
            SPFieldDateTime dueDateField = (SPFieldDateTime)pList.Fields["Due Date"];
            dueDateField.DisplayFormat = SPDateTimeFieldFormatType.DateOnly;

            dueDateField.Update();
            pList.Update();
            Console.WriteLine("Done");

            // Create Employees List using client API
            Console.Write("Creating Employees List ...");
            Guid eListGuid = spWeb.Lists.Add("Employees", "Employees", SPListTemplateType.GenericList);
            spWeb.Update();
            Console.WriteLine("Done");

            // Employees List columns
            Console.Write("Adding Columns to Employees List ...");
            SPList eList = spWeb.Lists[eListGuid];
            eList.OnQuickLaunch = true;
            SPField titleIDField = eList.Fields["Title"];
            titleIDField.Title = "Fullname";
            titleIDField.Update();
            //FixupField(eList, eList.Fields.Add("Birthdate", SPFieldType.DateTime, false));
            //SPFieldDateTime birthdateField = (SPFieldDateTime)eList.Fields["Birthdate"];
            //birthdateField.DisplayFormat = SPDateTimeFieldFormatType.DateOnly;
            //birthdateField.Update();
            FixupField(eList, eList.Fields.Add("JobTitle", SPFieldType.Text, false));
            FixupField(eList, eList.Fields.Add("Team", SPFieldType.Text, false));
            //FixupField(eList, eList.Fields.Add("Married", SPFieldType.Boolean, false));
            FixupField(eList, eList.Fields.Add("Contribution (in Milestones)", SPFieldType.Number, false));
            string projectFieldInternalName = eList.Fields.AddLookup("Project", pListGuid, false);
            SPFieldLookup projectField = (SPFieldLookup)eList.Fields.GetFieldByInternalName(projectFieldInternalName);
            projectField.LookupField = pTitleIDField.InternalName;
            FixupField(projectField);
            eList.Update();

            // Project Manager field (Project to Employee lookup)
            string employeeFieldInternalName = pList.Fields.AddLookup("Primary Contact", eListGuid, false);
            SPFieldLookup managerField = (SPFieldLookup)pList.Fields.GetFieldByInternalName(employeeFieldInternalName);
            managerField.LookupField = titleIDField.InternalName;
            FixupField(managerField);
            pList.Update();

            Console.WriteLine("Done");
        }

        static void FixupField(SPList spList, string fieldInternalName)
        {
            FixupField(spList.Fields.GetFieldByInternalName(fieldInternalName));
        }

        static void FixupField(SPField spField)
        {
            // This method takes an InternalName of a field in a spList and process a few things we want all fields to have by default
            // for example setting them to show into the default view
            spField.ShowInDisplayForm = true;
            spField.ShowInEditForm = true;
            spField.ShowInListSettings = true;
            spField.ShowInNewForm = true;
            spField.ShowInVersionHistory = true;
            spField.ShowInViewForms = true;

            // Add field to default view
            SPView defaultView = spField.ParentList.DefaultView;
            defaultView.ViewFields.Add(spField);
            defaultView.Update();

            spField.Update();
        }

        private static string GetLookupValueCollectionString(SPList lookupList, string lookupFieldInternalName, string values)
        {
            string[] strArray = values.Split(new char[] { ';' });
            string str = null;
            foreach (string str2 in strArray)
            {
                if (!string.IsNullOrEmpty(str))
                {
                    str = str + ";#";
                }
                object obj2 = str;
                str = string.Concat(new object[] { obj2, GetLookupValueID(lookupList, lookupFieldInternalName, str2), ";#", str2 });
            }
            return str;
        }

        private static int GetLookupValueID(SPList lookupList, string lookupFieldInternalName, string value)
        {
            SPQuery query = new SPQuery();
            query.Query = "<Where><Eq>   <FieldRef Name=\"" + lookupFieldInternalName + "\" />   <Value Type=\"Text\">" + value + "</Value></Eq></Where>";
            SPListItemCollection items = lookupList.GetItems(query);
            if (items.Count != 1)
            {
                throw new ArgumentException(string.Format("GetLookupValueID not found for {0} value {1}", lookupFieldInternalName, value));
            }
            return items[0].ID;
        }

//        public static void ImportListData(string siteURL, string spListName, string PathToCSV)
        static void ImportListData(SPWeb spWeb, string spListName, string[] TheData)
        {
            //string str = siteURL;
            //string str2 = spListName;
            //string str3 = PathToCSV;
            Console.Write(string.Format("Adding data for list {0} ...", spListName));
            //SPSite site = new SPSite(str);
            //SPList list = site.OpenWeb().Lists[str2];
            SPList list = spWeb.Lists[spListName];
            Console.WriteLine("Done");
            //Console.Write(string.Format("Importing Data from file {0} ...", str3));
            //StreamReader reader = new StreamReader(str3);
            // string str4 = null;
            List<SPField> list2 = null;
//            while ((str4 = reader.ReadLine()) != null)
            foreach (string str4 in TheData)
            {
                string[] strArray = str4.Split(new char[] { ',' });
                // adding fields first time through
                if (list2 == null)
                {
                    list2 = new List<SPField>();
                    foreach (string str5 in strArray)
                    {
                        SPField field = list.Fields[str5];
                        list2.Add(field);
                    }
                }
                else // adding the data since we already got the fields
                {
                    SPListItem item = list.Items.Add();
                    for (int i = 0; i < list2.Count; i++)
                    {
                        string str5 = strArray[i];
                        string typeAsString = list2[i].TypeAsString;
                        if (typeAsString.StartsWith("Lookup"))
                        {
                            if (!string.IsNullOrEmpty(str5))
                            {
                                XmlDocument document = new XmlDocument();
                                document.LoadXml(list2[i].SchemaXml);
                                XmlNode node = document.GetElementsByTagName("Field")[0];
                                Guid guid = new Guid(node.Attributes["List"].Value);
                                string lookupFieldInternalName = node.Attributes["ShowField"].Value;
                                SPList lookupList = spWeb.Lists[guid];
                                if (typeAsString == "LookupMulti")
                                {
                                    item[list2[i].InternalName] = GetLookupValueCollectionString(lookupList, lookupFieldInternalName, str5);
                                }
                                else
                                {
                                    item[list2[i].InternalName] = GetLookupValueID(lookupList, lookupFieldInternalName, str5);
                                }
                            }
                        }
                        else if (typeAsString.StartsWith("MultiChoice"))
                        {
                            if (!string.IsNullOrEmpty(str5))
                            {
                                string[] strArray2 = str5.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                                SPFieldMultiChoiceValue value2 = new SPFieldMultiChoiceValue();
                                foreach (string str8 in strArray2)
                                {
                                    value2.Add(str8);
                                }
                                item[list2[i].InternalName] = value2;
                            }
                        }
                        else if (typeAsString.StartsWith("User"))
                        {
                            if (!string.IsNullOrEmpty(str5))
                            {
                                int lookupId = int.Parse(str5);
                                SPFieldUserValue value3 = new SPFieldUserValue(item.Web, lookupId, null);
                                item[list2[i].InternalName] = value3;
                            }
                        }
                        else
                        {
                            item[list2[i].InternalName] = str5;
                        }
                    }
                    item.Update();
                    Console.Write(".");
                }
            }
            Console.WriteLine(" Done");
        }

        static string[] GetEmployeesData()
        {
            string[] value =  { "Fullname,JobTitle,Team,Contribution (in Milestones),Project",
               "Kim Abercrombie,Test Lead,AP,2,Writing more sample code", 
               "Luka Abrus,Dev,AP,3,Writing developer articles", 
               "Sean P. Alexander,Dev,AP,3,Writing developer articles", 
               "Joe Healy,SDET,AP,2,Writing more sample code", 
               "Bjorn Rettig,PM,WSS,3,Writing more sample code", 
               "David Probst,SDE,AP,2,Writing more sample code", 
               "Andy Ruth,SDET,AP,2,Building more developer tools", 
               "Boris Scholl,SDET,AP,2,Writing more sample code", 
               "Ari Bixhorn,CEO,MSFT,25.16,Building more developer tools", 
               "Kevin Kelly,SDET,AP,1,Writing more sample code", 
               "Eric Lang,SDET,AP,1,Writing more sample code", 
               "Chris Mayo,SDET,AP,1,Writing more sample code", 
               "Lisa Miller,SDE,WSS,0.25,Answering forums questions", 
               "Paul West,SDE,WSS,0.25,Writing more sample code", 
               "Arthur Yasinski,Test Lead,WSS,0.25,Building more developer tools", 
               "Robin Young,SDE,AP,3,Answering forums questions", 
               "Doug Mahugh,SDE Intern,WSS,1,Answering forums questions"};
            return value;
        }

        static string[] GetProjectsData()
        {
            string[] value =  { "Title,Description,Due Date,Primary Contact",
"Writing more sample code,Customers need samples to write code from,12/31/2009,",
"Building more developer tools,Tools are fun to build and use,5/16/2009,",
"Answering forums questions,Helping new developers to learn,6/15/2009,",
"Writing developer articles,Everyone needs to read more details,4/15/2009,"};
            return value;
        }

    }
}

