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
Imports System.ComponentModel
Imports System.Runtime.InteropServices
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports Microsoft.SharePoint
Imports Microsoft.SharePoint.WebControls

<ToolboxItemAttribute(false)> _
Public Class SBWebPart
    Inherits WebPart
    Private _ddlProjects As DropDownList = New DropDownList()
    Private _tbDescription As TextBox = New TextBox()
    Private _tbDueDate As TextBox = New TextBox()

    Public Sub New()
    End Sub

    Protected Overrides Sub CreateChildControls()
        MyBase.CreateChildControls()

        Dim parent As New Panel
        parent.Style.Add("border", "solid 1px Navy")
        parent.Style.Add("background-color", "#EEEEEE")
        parent.Style.Add("width", "250px")
        _ddlProjects.ID = "ddlProjects"
        _ddlProjects.AutoPostBack = True
        AddHandler _ddlProjects.SelectedIndexChanged, New EventHandler(AddressOf ddlProjects_SelectedIndexChanged)
        PopulateProjects()
        parent.Controls.Add(_ddlProjects)

        Dim panel As New Panel
        Dim label As New Label
        label.Text = "Description"
        panel.Controls.Add(label)
        parent.Controls.Add(panel)
        panel = New Panel
        panel.Controls.Add(_tbDescription)
        parent.Controls.Add(panel)

        label = New Label
        label.Text = "Due Date"
        panel = New Panel
        panel.Controls.Add(label)
        parent.Controls.Add(panel)

        panel = New Panel
        panel.Controls.Add(_tbDueDate)
        parent.Controls.Add(panel)

        panel = New Panel
        Dim button As New Button
        button.Text = "Update Project"
        AddHandler button.Click, New EventHandler(AddressOf bUpdateProject_Click)
        panel.Controls.Add(button)
        parent.Controls.Add(panel)
        Controls.Add(parent)
    End Sub
    Private Sub PopulateProjects()
        Dim splProjects As SPList = SPContext.Current.Web.Lists.Item("Projects")
        _ddlProjects.Items.Add("-- Select a Project --")
        Dim item As SPListItem
        For Each item In splProjects.Items
            _ddlProjects.Items.Add(New ListItem(item.Title, item.ID.ToString))
        Next
    End Sub

    Private Sub ddlProjects_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
        GetProjectDetails()
    End Sub

    Private Sub bUpdateProject_Click(ByVal sender As Object, ByVal e As EventArgs)
        EnsureChildControls()
        Dim nProjectID As Integer = Convert.ToInt32(_ddlProjects.SelectedValue)
        Dim spliProject As SPListItem = SPContext.Current.Web.Lists.Item("Projects").GetItemById(nProjectID)
        spliProject.Item("Description") = _tbDescription.Text
        spliProject.Item("Due_x0020_Date") = _tbDueDate.Text
        spliProject.Update()
    End Sub


    Protected Overrides Sub RenderContents(ByVal writer As HtmlTextWriter)
        MyBase.RenderContents(writer)
    End Sub
    Protected Overrides Sub OnLoad(ByVal e As EventArgs)
        MyBase.OnLoad(e)
        If Not Page.IsPostBack Then
            GetProjectDetails()
        End If
    End Sub

    Private Sub GetProjectDetails()
        EnsureChildControls()
        If _ddlProjects.SelectedValue <> "-- Select a Project --" Then
            Dim list As SPList = SPContext.Current.Web.Lists.Item("Projects")
            Dim id As Integer = Convert.ToInt32(_ddlProjects.SelectedValue)
            Dim itemById As SPListItem = list.GetItemById(id)
            _tbDescription.Text = itemById.Item("Description").ToString
            _tbDueDate.Text = Convert.ToDateTime(itemById.Item("Due_x0020_Date")).ToShortDateString
        Else
            _tbDescription.Text = String.Empty
            _tbDueDate.Text = String.Empty
        End If
    End Sub


End Class
