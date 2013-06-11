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

Imports Microsoft.SharePoint.Linq
Imports Microsoft.SharePoint
Imports System.Linq
Imports System.Collections.Generic

Partial Public Class SPLinqDemoWebPartUserControl
    Inherits UserControl
    Dim Projects As EntityList(Of ProjectsItem)
    Dim Employees As EntityList(Of EmployeesItem)
    Dim Bugs As EntityList(Of BugItem)

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        Dim spWebUrl As String = SPContext.Current.Web.Url

        Dim dc As New SPLinqDataContext(spWebUrl)

        Projects = dc.GetList(Of ProjectsItem)("Projects")
        Employees = dc.GetList(Of EmployeesItem)("Employees")
        Bugs = dc.GetList(Of BugItem)("Bugs")
        If (Not IsPostBack) Then
            GetEmployees()
        End If

        dc.Dispose()

    End Sub
    Public Sub ChangeQuery(ByVal sender As Object, ByVal e As EventArgs) Handles dropDownList.SelectedIndexChanged
        Dim selected = dropDownList.SelectedValue


        Select Case selected
            Case "Projects"
                GetProjects()

            Case "Employees"
                GetEmployees()

            Case "Bugs"
                GetBugs()

        End Select
    End Sub



    Private Sub GetProjects()
        Dim projQuery = From p In Projects _
                           Where p.DueDate < DateTime.Now.AddMonths(6) _
                           Select nTitle = p.DueDate, JobTitle = p.Description, ProjectTitle = p.DueDate


        spGridView.DataSource = projQuery
        spGridView.DataBind()
    End Sub
    Private Sub GetEmployees()
        Dim empQuery = From emp In Employees _
           Where emp.Project.DueDate < DateTime.Now.AddMonths(6) _
           Select emp.Title, emp.JobTitle, ProjectTitle = emp.Project.Title

        spGridView.DataSource = empQuery
        spGridView.DataBind()
    End Sub
    Private Sub GetBugs()
        Dim bugsQuery = From bug In Bugs _
                      Select Title = bug.Project, JobTitle = bug.Description, PojectTitle = bug.AssignedTo

        spGridView.DataSource = bugsQuery
        spGridView.DataBind()
    End Sub
End Class
