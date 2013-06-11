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

Imports SPCHOL303_Ex2.ServiceReference1
Imports System.Net

Public Class Form1


    Dim context As New  _
            TeamSiteDataContext(New Uri("http://intranet.contoso.com/_vti_bin/ListData.svc"))


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        context.Credentials = CredentialCache.DefaultCredentials
        EmployeesBindingSource.DataSource = context.Employees

    End Sub

    Private Sub EmployeesBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmployeesBindingNavigatorSaveItem.Click

        context.SaveChanges()

    End Sub

    Private Sub EmployeesBindingSource_CurrentItemChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmployeesBindingSource.CurrentItemChanged

        context.UpdateObject(EmployeesBindingSource.Current)

    End Sub
End Class
