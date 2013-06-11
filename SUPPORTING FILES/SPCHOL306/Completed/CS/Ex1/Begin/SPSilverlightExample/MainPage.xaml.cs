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
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.SharePoint.Client;

namespace SPSilverlightExample
{
    public partial class MainPage : UserControl
    {
        private ListItemCollection _projects;

        public class Project
        {
            public string Title { get; set; }
            public DateTime DueDate { get; set; }
            public string Description { get; set; }
        }

        public MainPage()
        {
            InitializeComponent();

            ClientContext context = new ClientContext(ApplicationContext.Current.Url);
            context.Load(context.Web);
            List Projects = context.Web.Lists.GetByTitle("Projects");
            context.Load(Projects);

            CamlQuery query = new Microsoft.SharePoint.Client.CamlQuery();
            string camlQueryXml = "<View><Query><Where><Gt>" +
                "<FieldRef Name='Due_x0020_Date' />" +
                "<Value Type='DateTime'>2008-01-1T00:00:00Z</Value>" +
                "</Gt></Where></Query><ViewFields>" +
                "<FieldRef Name=\"Title\" /><FieldRef Name=\"Description\" />" +
                "<FieldRef Name=\"Due_x0020_Date\" />" +
                "</ViewFields></View>";

            query.ViewXml = camlQueryXml;
            _projects = Projects.GetItems(query);
            context.Load(_projects);
            context.ExecuteQueryAsync(new ClientRequestSucceededEventHandler(OnRequestSucceeded), null);
        }

        private void OnRequestSucceeded(Object sender, ClientRequestSucceededEventArgs args)
        {
            // this is not called on the UI thread
            Dispatcher.BeginInvoke(BindData);
        }

        private void BindData()
        {
            List<Project> projects = new List<Project>();
            foreach (ListItem li in _projects)
            {
                projects.Add(new Project()
                {
                    Title = li["Title"].ToString(),
                    DueDate = Convert.ToDateTime(li["Due_x0020_Date"].ToString()),
                    Description = li["Description"].ToString()
                });
            }
            dataGrid1.ItemsSource = projects; // must be on UI thread
        }
    }
}
