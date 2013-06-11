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

Public Class SPLinqDemoWebPart
    Inherits WebPart

    Const _ascxPath As String = "~/_CONTROLTEMPLATES/SPCHOL302_Ex1/SPLinqDemoWebPart/SPLinqDemoWebPartUserControl.ascx"

    Public Sub New()
    End Sub

    Protected Overrides Sub CreateChildControls()
        Try
            Dim control As Control = Page.LoadControl(_ascxPath)
            Controls.Add(control)
        Finally
            MyBase.CreateChildControls()
        End Try
    End Sub

    Protected Overrides Sub Render(ByVal writer As HtmlTextWriter)
        MyBase.Render(writer)
    End Sub

End Class
