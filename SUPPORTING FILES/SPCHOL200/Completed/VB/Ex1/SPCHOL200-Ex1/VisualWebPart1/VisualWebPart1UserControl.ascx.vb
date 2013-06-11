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

Partial Public Class VisualWebPart1UserControl
    Inherits UserControl

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        Dim dc As New SPLinqDataContext(SPContext.Current.Web.Url)

        Dim Employees As EntityList(Of EmployeesItem) = _
        dc.GetList(Of EmployeesItem)("Employees")

        Dim empQuery = From emp In Employees _
            Where emp.Project.DueDate < DateTime.Now.AddMonths(6) _
            Select emp.Title, emp.JobTitle, ProjectTitle = emp.Project.Title, _
            DueDate = emp.Project.DueDate.ToString()

        spGridView.DataSource = empQuery
        spGridView.DataBind()

    End Sub

End Class
