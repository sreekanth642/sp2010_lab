'--------------------------------------------------------------------------------
' This file is a "Sample" from the SharePoint Foundation 2010
' Samples
'
' Copyright (c) Microsoft Corporation. All rights reserved.
'
' This source code is intended only as a supplement to Microsoft
' Development Tools and/or on-line documentation.  See these other
' materials for detailed information regarding Microsoft code samples.
' 
' THIS CODE AND INFORMATION ARE PROVIDED AS IS WITHOUT WARRANTY OF ANY
' KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
' IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
' PARTICULAR PURPOSE.
'--------------------------------------------------------------------------------

Imports System
Imports System.Collections
Imports System.Configuration
Imports System.Data
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.HtmlControls
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports Microsoft.SharePoint.Workflow
Imports Microsoft.SharePoint
Imports Microsoft.SharePoint.WebControls
Imports Microsoft.SharePoint.Utilities

Partial Public Class WorkflowInitiationForm
    Inherits LayoutsPageBase

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        InitializeParams()

        ' Optionally, add code here to pre-populate your form fields.
    End Sub

    ' This method is called when the user clicks the button to start the workflow.
    Private Function GetInitiationData() As String

        ' TODO: Return a string that contains the initiation data that will be passed to the workflow. Typically, this is in XML format.
        Return Checkbox.Checked.ToString()

    End Function

    Protected Sub StartWorkflow_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        ' Optionally, add code here to perform additional steps before starting your workflow
        Try
            HandleStartWorkflow()
        Catch ex As Exception
            SPUtility.TransferToErrorPage(SPHttpUtility.UrlKeyValueEncode("Failed to Start Workflow"))
        End Try
    End Sub

    Protected Sub Cancel_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        SPUtility.Redirect("Workflow.aspx", SPRedirectFlags.RelativeToLayoutsPage, HttpContext.Current, Page.ClientQueryString)
    End Sub

#Region "Workflow Initiation Code - Typically, the following code should not be changed"

    Private associationGuid As String
    Private workflowList As SPList
    Private workflowListItem As SPListItem

    Private Sub InitializeParams()
        Try
            associationGuid = Request.Params.Item("TemplateID")

            ' Parameters 'List' and 'ID' will be null for site workflows.
            If Not String.IsNullOrEmpty(Request.Params.Item("List")) AndAlso Not String.IsNullOrEmpty(Request.Params.Item("ID")) Then
                workflowList = Web.Lists.Item(New Guid(Request.Params.Item("List")))
                workflowListItem = workflowList.GetItemById(Convert.ToInt32(Request.Params.Item("ID")))
            End If
        Catch ex As Exception
            SPUtility.TransferToErrorPage(SPHttpUtility.UrlKeyValueEncode("Failed to read Request Parameters"))
        End Try
    End Sub

    Private Sub HandleStartWorkflow()

        If workflowList IsNot Nothing AndAlso workflowListItem IsNot Nothing Then
            StartListWorkflow()
        Else
            StartSiteWorkflow()
        End If
    End Sub

    Private Sub StartSiteWorkflow()
        Dim association As SPWorkflowAssociation = Web.WorkflowAssociations.Item(New Guid(associationGuid))
        Web.Site.WorkflowManager.StartWorkflow(Nothing, association, GetInitiationData, SPWorkflowRunOptions.Synchronous)
        SPUtility.Redirect(Web.Url, SPRedirectFlags.UseSource, HttpContext.Current)
    End Sub

    Private Sub StartListWorkflow()
        Dim association As SPWorkflowAssociation = workflowList.WorkflowAssociations.Item(New Guid(associationGuid))
        Web.Site.WorkflowManager.StartWorkflow(workflowListItem, association, GetInitiationData)
        SPUtility.Redirect(workflowList.DefaultViewUrl, SPRedirectFlags.UseSource, HttpContext.Current)
    End Sub
#End Region
End Class
