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


namespace SPCHOL200_Ex1.VisualWebPart1
{
    public partial class VisualWebPart1UserControl : UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var dc = new SPLinqDataContext(SPContext.Current.Web.Url);

            var Employees = dc.GetList<EmployeesItem>("Employees");

            var empQuery = from emp in Employees
                           where emp.Project.DueDate <
                           DateTime.Now.AddMonths(6)
                           select new
                           {
                               emp.Title,
                               emp.JobTitle,
                               ProjectTitle = emp.Project.Title,
                               DueDate =
                               emp.Project.DueDate.Value.ToShortDateString()
                           };

            spGridView.DataSource = empQuery;
            spGridView.DataBind();


        }
    }
}
