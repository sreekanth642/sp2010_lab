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

Imports Microsoft.SharePoint
Imports Microsoft.SharePoint.Workflow
Imports Microsoft.SharePoint.WorkflowActions

Public Class CreateDocumentLibrary
    Inherits Activity


    Public Sub New()
        InitializeComponent()
    End Sub

    Protected Overloads Overrides Function Execute(ByVal executionContext As ActivityExecutionContext) As ActivityExecutionStatus
        CreateDocLib()
        Return ActivityExecutionStatus.Closed
    End Function

    Private Sub CreateDocLib()
        Using sps As New SPSite(Url)
            Using spw As SPWeb = sps.RootWeb
                Dim ID As Guid = spw.Lists.Add(DocLibName, DocLibName & " Document Library", SPListTemplateType.DocumentLibrary)
                Dim spdl As SPList = spw.Lists(ID)
                spdl.OnQuickLaunch = True
                spdl.Update()
            End Using
        End Using
    End Sub



    Public Shared UrlProperty As DependencyProperty = DependencyProperty.Register("Url", GetType(String), GetType(CreateDocumentLibrary), New PropertyMetadata(""))
    <DescriptionAttribute("Url of base site")> _
    <BrowsableAttribute(True)> _
    <DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Visible)> _
    <ValidationOption(ValidationOption.[Optional])> _
    Public Property Url() As String
        Get
            Return DirectCast((MyBase.GetValue(CreateDocumentLibrary.UrlProperty)), String)
        End Get
        Set(ByVal value As String)
            MyBase.SetValue(CreateDocumentLibrary.UrlProperty, value)
        End Set
    End Property


    Public Shared DocLibNameProperty As DependencyProperty = DependencyProperty.Register("DocLibName", GetType(String), GetType(CreateDocumentLibrary), New PropertyMetadata(""))
    <DescriptionAttribute("Used as doc lib name")> _
    <BrowsableAttribute(True)> _
    <DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Visible)> _
    <ValidationOption(ValidationOption.[Optional])> _
    Public Property DocLibName() As String
        Get
            Return DirectCast((MyBase.GetValue(CreateDocumentLibrary.DocLibNameProperty)), String)
        End Get
        Set(ByVal value As String)
            MyBase.SetValue(CreateDocumentLibrary.DocLibNameProperty, value)
        End Set
    End Property




End Class
