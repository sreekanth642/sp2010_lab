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
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts


Imports Microsoft.SharePoint
Imports Microsoft.SharePoint.Utilities
Imports System.Web

Partial Public Class VisualWebPart1UserControl
    Inherits UserControl

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        Dim dueDate As DateTime = DateTime.Now

        If Not String.IsNullOrEmpty(Request.QueryString("date")) Then
            dueDate = DateTime.Parse(Request.QueryString("date"))
        End If

        Me.DueDate.SelectedDate = dueDate

        Dim home As SPWeb = SPContext.Current.Web
        ProjectsListView.List = home.Lists("Projects")

        Dim query As New SPQuery(ProjectsListView.List.DefaultView)
        query.ViewFields = "<FieldRef Name=""Title"" /><FieldRef Name=""Due_x0020_Date"" />"
        query.Query = String.Format("<Where><Leq><FieldRef Name=""Due_x0020_Date"" /><Value Type=""DateTime"">{0}</Value></Leq></Where>", dueDate.ToString("s"))

        ProjectsListView.DisableFilter = True
        ProjectsListView.DisableSort = True
        ProjectsListView.Query = query


    End Sub

    Protected Sub OnDate_Changed(ByVal sender As Object, ByVal e As EventArgs)
        SPUtility.Redirect(SPContext.Current.ListItem.Name _
        , SPRedirectFlags.Default _
        , HttpContext.Current _
        , String.Format("date={0}", DueDate.SelectedDate.ToString("d")))
    End Sub




End Class
