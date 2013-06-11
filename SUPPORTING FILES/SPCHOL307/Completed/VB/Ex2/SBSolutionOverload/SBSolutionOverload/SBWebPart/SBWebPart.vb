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

    Public Sub New()
    End Sub

    Private _lbl As New Label
    Private _txt As New TextBox
    Private _child As New Button

    Protected Overrides Sub CreateChildControls()
        MyBase.CreateChildControls()
        _child.Text = "Show All Lists"
        AddHandler _child.Click, New EventHandler(AddressOf child_Click)

        Controls.Add(_txt)
        Controls.Add(_child)
        Controls.Add(_lbl)
    End Sub

    Private Sub child_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim dt As DateTime = DateTime.Now
        Do
            Dim allWebs As SPWebCollection = SPContext.Current.Site.AllWebs
            Dim web As SPWeb
            For Each web In allWebs
                Dim lists As SPListCollection = web.Lists
                Dim list As SPList
                For Each list In lists
                    _lbl.Text = (_lbl.Text & "<br>" & list.Title)
                Next
            Next
        Loop While (dt.AddSeconds(CDbl(Integer.Parse(_txt.Text))).CompareTo(DateTime.Now) > 0)
    End Sub


    Protected Overrides Sub RenderContents(ByVal writer As HtmlTextWriter)
        MyBase.RenderContents(writer)
    End Sub

End Class
