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

Option Explicit On
Option Strict On

Imports System
Imports System.Security.Permissions
Imports Microsoft.SharePoint
Imports Microsoft.SharePoint.Security
Imports Microsoft.SharePoint.Utilities
Imports Microsoft.SharePoint.Workflow

Public Class BugListItemEvent 
    Inherits SPItemEventReceiver

	''' <summary>
	''' An item is being added.
	''' </summary>
	Public Overrides Sub ItemAdding(properties as SPItemEventProperties)
        MyBase.ItemAdding(properties)
        Try
            Me.EventFiringEnabled = False
            AutoAssign(properties)
        Catch ex As Exception
            'ToLog ex
            Return
        Finally
            Me.EventFiringEnabled = True
        End Try


	End Sub

	''' <summary>
	''' An item is being updated.
	''' </summary>
	Public Overrides Sub ItemUpdating(properties as SPItemEventProperties)
        MyBase.ItemUpdating(properties)
        Try
            Me.EventFiringEnabled = False
            AutoAssign(properties)
        Catch ex As Exception
            'ToLog ex
            Return
        Finally
            Me.EventFiringEnabled = True
        End Try


	End Sub

	''' <summary>
	''' An item is being deleted.
	''' </summary>
	Public Overrides Sub ItemDeleting(properties as SPItemEventProperties)
        MyBase.ItemDeleting(properties)
        Try
            properties.Cancel = True
            properties.ErrorMessage = "Bugs can only be resolved not deleted!"
        Catch ex As Exception
            'ToLog ex
            Return
        Finally
            Me.EventFiringEnabled = True
        End Try


    End Sub

    Private Shared Sub AutoAssign(ByVal properties As SPItemEventProperties)
        Dim projectName As String = properties.AfterProperties("BugProject").ToString()
        Dim projectList As SPList = properties.Web.GetList("Lists/Projects")
        For Each item As SPListItem In projectList.Items
            If item.Title.ToLower().Contains(projectName.ToLower()) Then
                Dim contact As String = item("Primary Contact").ToString()
                If contact.Contains(";#") Then
                    contact = contact.Split("#"c)(1)
                End If
                properties.AfterProperties("BugAssignedTo") = contact
                Exit For
            End If
        Next
    End Sub



End Class
