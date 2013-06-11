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
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using Microsoft.SharePoint.Linq;
using Microsoft.SharePoint;
using System.Linq;
using System.Collections.Generic;


namespace SPCHOL302_Ex1.SPLinqDemoWebPart
{
    public partial class SPLinqDemoWebPartUserControl : UserControl
    {
        EntityList<ProjectsItem> Projects;
        EntityList<EmployeesItem> Employees;
        EntityList<BugItem> Bugs;
        protected void Page_Load(object sender, EventArgs e)
        {
            string spWebUrl = SPContext.Current.Web.Url;

            SPLinqDataContext dc = new SPLinqDataContext(spWebUrl);
            
            Projects = dc.GetList<ProjectsItem>("Projects");
            Employees = dc.GetList<EmployeesItem>("Employees");
            Bugs = dc.GetList<BugItem>("Bugs");
            if (!IsPostBack)
                GetEmployees();
            dc.Dispose();

        }
        public void ChangeQuery(object o, EventArgs e)
        {
            var selected = dropDownList.SelectedValue;
            switch (selected)
            {
                case "Projects":
                    GetProjects();
                    break;
                case "Employees":
                    GetEmployees();
                    break;
                case "Bugs":
                    GetBugs();
                    break;
                default:
                    break;
            }
        }

        private void GetBugs()
        {
            var bugsQuery = from bug in Bugs
                            select new
                           {
                              Title = bug.Project,
                              JobTitle = bug.Description,
                               ProjectTitle = bug.AssignedTo
                           };

            spGridView.DataSource = bugsQuery;
            spGridView.DataBind();
        }

        private void GetEmployees()
        {
            var empQuery = from emp in Employees
                           where emp.Project.DueDate <
                           DateTime.Now.AddMonths(6)
                           select new
                           {
                               emp.Title,
                               emp.JobTitle,
                               ProjectTitle = emp.Project.Title
                           };

            spGridView.DataSource = empQuery;
            spGridView.DataBind();
        }

        private void GetProjects()
        {
           var projQuery = from p in Projects
                           where p.DueDate <
                           DateTime.Now.AddMonths(6)
                           select new
                           {
                               Title = p.DueDate,
                               JobTitle = p.Description,
                               ProjectTitle = p.DueDate
                           };

           spGridView.DataSource = projQuery;
           spGridView.DataBind();
        }
        
        
    }
}
