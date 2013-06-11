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

Imports Microsoft.SharePoint.Client
Imports SP = Microsoft.SharePoint.Client

Class MainWindow

    Private Sub Window_Loaded(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles MyBase.Loaded

        Dim context As New ClientContext("http://intranet.contoso.com")

        Dim site As Web = context.Web
        context.Load(site, Function(osite) osite.Title)
        context.ExecuteQuery()

        Title = site.Title

        Dim lists As ListCollection = site.Lists
        Dim listsCollection As IEnumerable(Of SP.List) = _
          context.LoadQuery(lists.Include(Function(l) l.Title, Function(l) l.Id))
        context.ExecuteQuery()

        ListBox1.ItemsSource = listsCollection
        ListBox1.DisplayMemberPath = "Title"

    End Sub

End Class
