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

using Microsoft.SharePoint;
using Microsoft.SharePoint.Utilities;
using System.Web;

namespace ProjectsListWebPart.VisualWebPart1
{
    public partial class VisualWebPart1UserControl : UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DateTime dueDate = DateTime.Now;

            if (!string.IsNullOrEmpty(Request.QueryString["date"]))
            {
                dueDate = DateTime.Parse(Request.QueryString["date"]);
            }
            DueDate.SelectedDate = dueDate;

            SPWeb home = SPContext.Current.Web;
            ProjectsListView.List = home.Lists["Projects"];

            SPQuery query = new SPQuery(ProjectsListView.List.DefaultView);
            query.ViewFields = "<FieldRef Name=\"Title\" /><FieldRef Name=\"Due_x0020_Date\" />";
            query.Query = string.Format(
                "<Where><Leq><FieldRef Name=\"Due_x0020_Date\" /><Value Type=\"DateTime\">{0}</Value></Leq></Where>"
                , dueDate.ToString("s"));

            ProjectsListView.DisableFilter = true;
            ProjectsListView.DisableSort = true;
            ProjectsListView.Query = query;

        }
        protected void OnDate_Changed(object sender, EventArgs e)
        {
            SPUtility.Redirect(SPContext.Current.ListItem.Name
                 , SPRedirectFlags.Default
                 , HttpContext.Current
                 , string.Format("date={0}", DueDate.SelectedDate.ToString("d")));
        }

    }
}
