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
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using Microsoft.SharePoint;
using Microsoft.SharePoint.WebControls;

namespace SPSolutionDemo.SBWebPart
{
    [ToolboxItemAttribute(false)]
    public class SBWebPart : WebPart
    {
        public SBWebPart()
        {
        }
        protected override void CreateChildControls()
        {
            base.CreateChildControls();

            Panel parent = new Panel();
            parent.Style.Add("border", "solid 1px Navy");
            parent.Style.Add("background-color", "#EEEEEE");
            parent.Style.Add("width", "250px");
            _ddlProjects.ID = "ddlProjects";
            _ddlProjects.AutoPostBack = true;
            _ddlProjects.SelectedIndexChanged += new
            EventHandler(ddlProjects_SelectedIndexChanged);
            PopulateProjects();
            parent.Controls.Add(_ddlProjects);

            Panel panel = new Panel();
            Label label = new Label();
            label.Text = "Description";
            panel.Controls.Add(label);
            parent.Controls.Add(panel);
            panel = new Panel();
            panel.Controls.Add(_tbDescription);
            parent.Controls.Add(panel);

            label = new Label();
            label.Text = "Due Date";
            panel = new Panel();
            panel.Controls.Add(label);
            parent.Controls.Add(panel);

            panel = new Panel();
            panel.Controls.Add(_tbDueDate);
            parent.Controls.Add(panel);

            panel = new Panel();
            Button bUpdateProject = new Button();
            bUpdateProject.Text = "Update Project";
            bUpdateProject.Click += new EventHandler(bUpdateProject_Click);
            panel.Controls.Add(bUpdateProject);
            parent.Controls.Add(panel);
            Controls.Add(parent);
        }

        DropDownList _ddlProjects = new DropDownList();
        TextBox _tbDescription = new TextBox();
        TextBox _tbDueDate = new TextBox();
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (!Page.IsPostBack)
                GetProjectDetails();
        }

        /* Populate the text boxes with the selected project details */
        private void GetProjectDetails()
        {
            EnsureChildControls();
            if (_ddlProjects.SelectedValue != "-- Select a Project --")
            {
                SPList pList = SPContext.Current.Web.Lists["Projects"];
                int nProjectID = Convert.ToInt32(_ddlProjects.SelectedValue);
                SPListItem spliProject = pList.GetItemById(nProjectID);
                _tbDescription.Text = spliProject["Description"].ToString();
                DateTime dueDate = Convert.ToDateTime(spliProject["Due_x0020_Date"]);
                _tbDueDate.Text = dueDate.ToShortDateString();
            }
            else
            {
                _tbDescription.Text = String.Empty;
                _tbDueDate.Text = String.Empty;
            }
        }
        private void PopulateProjects()
        {
            SPList splProjects = SPContext.Current.Web.Lists["Projects"];
            _ddlProjects.Items.Add("-- Select a Project --");
            foreach (SPListItem spli in splProjects.Items)
            {
                _ddlProjects.Items.Add(new ListItem(spli.Title, spli.ID.ToString()));
            }
        }

        void ddlProjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetProjectDetails();
        }

        /* Update the current project */
        void bUpdateProject_Click(object sender, EventArgs e)
        {
            EnsureChildControls();
            int nProjectID = Convert.ToInt32(_ddlProjects.SelectedValue);
            SPListItem spliProject =
            SPContext.Current.Web.Lists["Projects"].GetItemById(nProjectID);
            spliProject["Description"] = _tbDescription.Text;
            spliProject["Due_x0020_Date"] = _tbDueDate.Text;
            spliProject.Update();
        }
    }
}
