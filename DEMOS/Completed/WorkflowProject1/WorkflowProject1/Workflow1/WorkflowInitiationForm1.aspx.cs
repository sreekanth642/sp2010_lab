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
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using Microsoft.SharePoint;
using Microsoft.SharePoint.WebControls;
using Microsoft.SharePoint.Workflow;
using Microsoft.SharePoint.Utilities;

namespace WorkflowProject1.Workflow1
{
    public partial class WorkflowInitiationForm1 : LayoutsPageBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            InitializeParams();

            // Optionally, add code here to pre-populate your form fields.
        }

        // This method is called when the user clicks the button to start the workflow.
        private string GetInitiationData()
        {
            // TODO: Return a string that contains the initiation data that will be passed to the workflow. Typically, this is in XML format.
            return string.Format("Name {0}  Address {1}", MyName.Text, MyAddress.Text);
        }

        protected void StartWorkflow_Click(object sender, EventArgs e)
        {
            // Optionally, add code here to perform additional steps before starting your workflow
            try
            {
                HandleStartWorkflow();
            }
            catch (Exception)
            {
                SPUtility.TransferToErrorPage(SPHttpUtility.UrlKeyValueEncode("Failed to Start Workflow"));
            }
        }

        protected void Cancel_Click(object sender, EventArgs e)
        {
            SPUtility.Redirect("Workflow.aspx", SPRedirectFlags.RelativeToLayoutsPage, HttpContext.Current, Page.ClientQueryString);
        }

        #region Workflow Initiation Code - Typically, the following code should not be changed

        private string associationGuid;
        private SPList workflowList;
        private SPListItem workflowListItem;

        private void InitializeParams()
        {
            try
            {
                this.associationGuid = Request.Params["TemplateID"];

                // Parameters 'List' and 'ID' will be null for site workflows.
                if (!String.IsNullOrEmpty(Request.Params["List"]) && !String.IsNullOrEmpty(Request.Params["ID"]))
                {
                    this.workflowList = this.Web.Lists[new Guid(Request.Params["List"])];
                    this.workflowListItem = this.workflowList.GetItemById(Convert.ToInt32(Request.Params["ID"]));
                }
            }
            catch (Exception)
            {
                SPUtility.TransferToErrorPage(SPHttpUtility.UrlKeyValueEncode("Failed to read Request Parameters"));
            }
        }

        private void HandleStartWorkflow()
        {
            if (this.workflowList != null && this.workflowListItem != null)
            {
                StartListWorkflow();
            }
            else
            {
                StartSiteWorkflow();
            }
        }

        private void StartSiteWorkflow()
        {
            SPWorkflowAssociation association = this.Web.WorkflowAssociations[new Guid(this.associationGuid)];
            this.Web.Site.WorkflowManager.StartWorkflow((object)null, association, GetInitiationData(), SPWorkflowRunOptions.Synchronous);
            SPUtility.Redirect(this.Web.Url, SPRedirectFlags.UseSource, HttpContext.Current);
        }

        private void StartListWorkflow()
        {
            SPWorkflowAssociation association = this.workflowList.WorkflowAssociations[new Guid(this.associationGuid)];
            this.Web.Site.WorkflowManager.StartWorkflow(workflowListItem, association, GetInitiationData());
            SPUtility.Redirect(this.workflowList.DefaultViewUrl, SPRedirectFlags.UseSource, HttpContext.Current);
        }
        #endregion
    }
}