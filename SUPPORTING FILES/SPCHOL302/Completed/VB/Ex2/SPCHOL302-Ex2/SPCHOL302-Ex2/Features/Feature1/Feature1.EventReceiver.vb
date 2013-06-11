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
Imports System.Runtime.InteropServices
Imports System.Security.Permissions
Imports Microsoft.SharePoint
Imports Microsoft.SharePoint.Security
Imports System.Linq
''' <summary>
''' This class handles events raised during feature activation, deactivation, installation, uninstallation, and upgrade.
''' </summary>
''' <remarks>
''' The GUID attached to this class may be used during packaging and should not be modified.
''' </remarks>

<GuidAttribute("f5c30540-b4bd-45d0-9715-d0f390c310d8")> _
Public Class Feature1EventReceiver 
    Inherits SPFeatureReceiver

    ' Uncomment the method below to handle the event raised after a feature has been activated.

    Public Overrides Sub FeatureActivated(ByVal properties As SPFeatureReceiverProperties)
        Using spWeb As SPWeb = TryCast(properties.Feature.Parent, SPWeb)
            Dim newAnnouncement As SPContentType = _
                   spWeb.ContentTypes _
                   .Cast(Of SPContentType) _
                   .FirstOrDefault(Function(c) c.Name = "New Announcements")
            If newAnnouncement IsNot Nothing Then
                newAnnouncement.Delete()
            End If

            Dim newField As SPField = _
                   spWeb.Fields _
                   .Cast(Of SPField) _
                   .FirstOrDefault(Function(f) f.StaticName = "Team Project")
            If newField IsNot Nothing Then
                newField.Delete()
            End If

            Dim myContentType As New SPContentType _
                     (spWeb.ContentTypes("Announcement"), _
                      spWeb.ContentTypes, "New Announcements")
            myContentType.Group = "Custom Content Types"

            spWeb.Fields.Add("Team Project", SPFieldType.Text, True)
            Dim projFeldLink As New SPFieldLink(spWeb.Fields("Team Project"))
            myContentType.FieldLinks.Add(projFeldLink)

            Dim companyFieldLink As New SPFieldLink(spWeb.Fields("Company"))
            myContentType.FieldLinks.Add(companyFieldLink)

            spWeb.ContentTypes.Add(myContentType)
            myContentType.Update()
        End Using

    End Sub


    ' Uncomment the method below to handle the event raised before a feature is deactivated.

    Public Overrides Sub FeatureDeactivating(ByVal properties As SPFeatureReceiverProperties)
        Using spWeb As SPWeb = TryCast(properties.Feature.Parent, SPWeb)
            Dim myContentType As SPContentType = spWeb.ContentTypes("New Announcements")
            spWeb.ContentTypes.Delete(myContentType.Id)
            spWeb.Fields("Team Project").Delete()
        End Using

    End Sub



    ' Uncomment the method below to handle the event raised after a feature has been installed.

    'Public Overrides Sub FeatureInstalled(ByVal properties As SPFeatureReceiverProperties)
    'End Sub


    ' Uncomment the method below to handle the event raised before a feature is uninstalled.

    'Public Overrides Sub FeatureUninstalling(ByVal properties As SPFeatureReceiverProperties)
    'End Sub

    ' Uncomment the method below to handle the event raised when a feature is upgrading.

    'Public Overrides Sub FeatureUpgrading(ByVal properties As Microsoft.SharePoint.SPFeatureReceiverProperties, ByVal upgradeActionName As String, ByVal parameters As System.Collections.Generic.IDictionary(Of String, String))
    'End Sub

End Class
