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


Public Class Project
    Private _title As String
    Private _dueDate As DateTime
    Private _description As String

    Public Property Title() As String
        Get
            Return _title
        End Get
        Set(ByVal value As String)
            _title = value
        End Set
    End Property

    Public Property DueDate() As DateTime
        Get
            Return _dueDate
        End Get
        Set(ByVal value As DateTime)
            _dueDate = value
        End Set
    End Property

    Public Property Description() As String
        Get
            Return _description
        End Get
        Set(ByVal value As String)
            _description = value
        End Set
    End Property
End Class


Partial Public Class MainPage
    Inherits UserControl

    Private _projects As ListItemCollection

    Public Sub New()
        InitializeComponent()


        Dim context As ClientContext = New ClientContext(ApplicationContext.Current.Url)
        context.Load(context.Web)
        Dim Projects As List = context.Web.Lists.GetByTitle("Projects")
        context.Load(Projects)

        Dim query As CamlQuery = New CamlQuery()
        Dim camlQueryXml As String = "<View><Query><Where><Gt>" + _
            "<FieldRef Name='Due_x0020_Date' />" + _
            "<Value Type='DateTime'>2008-01-1T00:00:00Z</Value>" + _
            "</Gt></Where></Query><ViewFields>" + _
            "<FieldRef Name=""Title"" /><FieldRef Name=""Description"" />" + _
            "<FieldRef Name=""Due_x0020_Date"" />" + _
            "</ViewFields></View>"

        query.ViewXml = camlQueryXml
        _projects = Projects.GetItems(query)
        context.Load(_projects)
        context.ExecuteQueryAsync(New ClientRequestSucceededEventHandler(AddressOf OnRequestSucceeded), Nothing)


    End Sub


    Public Sub OnRequestSucceeded(ByVal sender As Object, ByVal args As ClientRequestSucceededEventArgs)
        ' this is not called on the UI thread
        Dispatcher.BeginInvoke(New Action(AddressOf BindData))
    End Sub

    Public Sub BindData()
        Dim projects As List(Of Project) = New List(Of Project)()
        For Each li As ListItem In _projects
            projects.Add(New Project() With { _
                         .Title = li("Title").ToString(), _
                         .DueDate = Convert.ToDateTime(li("Due_x0020_Date").ToString()), _
                         .Description = li("Description").ToString() _
                         })
        Next
        DataGrid1.ItemsSource = projects
    End Sub


End Class