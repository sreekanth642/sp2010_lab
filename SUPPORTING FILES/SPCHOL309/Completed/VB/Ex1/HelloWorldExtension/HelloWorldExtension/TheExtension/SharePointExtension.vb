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

Imports System.ComponentModel.Composition
Imports Microsoft.VisualStudio.SharePoint
Imports System.Linq
Imports System.Windows


Namespace HelloWorldExtension
    <Export(GetType(ISharePointProjectExtension))>
    Public Class SharePointProjectExtension
        Implements ISharePointProjectExtension


        Sub Initialize(ByVal projectService As ISharePointProjectService) Implements ISharePointProjectExtension.Initialize
            Dim items = From pi In projectService.ProjectItemTypes
                        Where pi.Key = "Microsoft.VisualStudio.SharePoint.ListDefinition"
                        Select pi.Value

            Dim listType = items.FirstOrDefault()
            AddHandler listType.ProjectItemMenuItemsRequested, AddressOf ContextMenuRequested
        End Sub

        Private Sub ContextMenuRequested(ByVal sender As Object, ByVal e As SharePointProjectItemMenuItemsRequestedEventArgs)
            Dim mi = e.ViewMenuItems.Add("Hello SharePoint Extensibility!")
            AddHandler mi.Click, AddressOf ContextMenuClicked
        End Sub


        Private Sub ContextMenuClicked(ByVal sender As Object, ByVal e As MenuItemEventArgs)
            MessageBox.Show("Hello From a SharePoint project extension")
        End Sub

      
    End Class
End Namespace

