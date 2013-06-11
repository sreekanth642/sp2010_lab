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
Imports System.Runtime.InteropServices
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports Microsoft.SharePoint
Imports Microsoft.SharePoint.WebControls

Public Class ProviderWebPart
    Inherits WebPart
    Implements IProject

    Private _projectPicker As DropDownList = Nothing

    ReadOnly Property IdProp() As Integer Implements IProject.Id
        Get
            Return Integer.Parse(_projectPicker.SelectedValue)
        End Get
    End Property

    ReadOnly Property Name() As String Implements IProject.Name
        Get
            Return _projectPicker.SelectedItem.ToString()
        End Get
    End Property

    Public Sub New()
    End Sub

    Protected Overrides Sub CreateChildControls()
        MyBase.CreateChildControls()

        Try
            _projectPicker = New DropDownList()

            Using spSite As New SPSite(SPContext.Current.Web.Url)
                Using spWeb As SPWeb = spSite.OpenWeb()
                    Dim projectsList As SPList = spWeb.Lists("Projects")

                    For Each project As SPListItem In projectsList.Items
                        _projectPicker.Items.Add(New ListItem(project.Title, project.ID.ToString()))
                    Next
                End Using
            End Using

            _projectPicker.AutoPostBack = True

            Me.Controls.Add(_projectPicker)
        Catch ex As Exception
            Me.Controls.Clear()
            Me.Controls.Add(New LiteralControl(ex.Message))
        End Try


    End Sub

    <ConnectionProvider("Project Name and ID")> _
    Public Function NameDoesNotMatter() As IProject
        Return Me
    End Function

End Class
