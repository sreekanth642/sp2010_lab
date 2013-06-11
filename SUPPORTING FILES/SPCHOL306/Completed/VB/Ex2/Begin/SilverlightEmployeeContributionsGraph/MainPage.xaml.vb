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


Public Class EmployeeContributions
    Public Name As String
    Public TeamName As String
    Public Contributions As Decimal
End Class

Public Class TeamContributions
    Private _name As String
    Private _contributions As Decimal

    Public Property Name() As String
        Get
            Return _name
        End Get
        Set(ByVal value As String)
            _name = value
        End Set
    End Property

    Public Property Contributions() As Decimal
        Get
            Return _contributions
        End Get
        Set(ByVal value As Decimal)
            _contributions = value
        End Set
    End Property
End Class


Partial Public Class MainPage
    Inherits UserControl

    Private _employees As ListItemCollection

    Public Sub New()
        InitializeComponent()


        Dim context As ClientContext = New ClientContext(ApplicationContext.Current.Url)
        context.Load(context.Web)
        Dim employees As List = context.Web.Lists.GetByTitle("Employees")
        context.Load(employees)

        Dim query As CamlQuery = New CamlQuery()
        Dim camlQueryXml As String = Nothing

        query.ViewXml = camlQueryXml
        _employees = employees.GetItems(query)
        context.Load(_employees)
        context.ExecuteQueryAsync(New ClientRequestSucceededEventHandler(AddressOf OnRequestSucceeded), Nothing)


    End Sub


    Public Sub OnRequestSucceeded(ByVal sender As Object, ByVal args As ClientRequestSucceededEventArgs)
        ' this is not called on the UI thread
        Dispatcher.BeginInvoke(New Action(AddressOf BindData))
    End Sub

    Public Sub BindData()
        Dim employees As List(Of EmployeeContributions) = New List(Of EmployeeContributions)()

        ' get list item values into a strongly typed class
        For Each li As ListItem In _employees
            employees.Add(New EmployeeContributions() With { _
             .Name = li("Title").ToString(), _
             .TeamName = li("Team").ToString(), _
             .Contributions = Convert.ToDecimal(li("Contribution_x0020__x0028_in_x00")) _
             })
        Next

        Dim teams As List(Of TeamContributions) = employees _
                                                  .GroupBy(Function(e) e.TeamName) _
                                                      .Select(Function(t) New TeamContributions() With { _
                                                          .Name = t.Key, _
                                                          .Contributions = t.Sum(Function(e) e.Contributions) _
                                                          }).ToList()

        chart.DataContext = teams
    End Sub


End Class