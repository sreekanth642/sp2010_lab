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
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

''' <summary>
''' All the methods for retrieving, updating and deleting data are implemented in this class file.
''' The samples below show the finder and specific finder method for Entity1.
''' </summary>
''' 

Public Class CustomerService

    Public Shared d As Dictionary(Of Integer, Customer) = Nothing

    Public Shared Function ReadItem(ByVal id As Integer) As Customer
        Dim e As New Customer()
        Dim c = d([id])
        e.CustomerId = c.CustomerId
        e.Message = c.Message
        e.FirstName = c.FirstName
        e.LastName = c.LastName
        Return e
    End Function

    Public Shared Function ReadList() As IEnumerable(Of Customer)

        If d Is Nothing Then
            d = New Dictionary(Of Integer, Customer)
            For i As Integer = 0 To 9
                Dim e As New Customer()
                e.CustomerId = i
                e.Message = e.CustomerId & " Item Data"
                e.FirstName = e.CustomerId & " First Name"
                e.LastName = e.CustomerId & "Last Name"
                d.Add(i, e)
            Next
        End If

        Return d.Values
    End Function

    Public Shared Sub Update(ByVal customer As Customer, ByVal id As Integer)
        d([id]).FirstName = customer.FirstName
        d([id]).LastName = customer.LastName
        d([id]).Message = customer.Message
    End Sub
End Class


