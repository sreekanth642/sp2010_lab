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

Imports Microsoft.SharePoint.Administration


''' <summary>
''' This class handles events raised during feature activation, deactivation, installation, uninstallation, and upgrade.
''' </summary>
''' <remarks>
''' The GUID attached to this class may be used during packaging and should not be modified.
''' </remarks>

<GuidAttribute("cc679752-dc2a-4692-8946-7e300c2f4163")> _
Public Class SPCHOL305Ex1FeatureEventReceiver 
    Inherits SPFeatureReceiver

    ' Uncomment the method below to handle the event raised after a feature has been activated.


    Public Overloads Overrides Sub FeatureActivated(ByVal properties As SPFeatureReceiverProperties)
        Dim wappCurrent As SPWebApplication = DirectCast(properties.Feature.Parent, SPWebApplication)
        Dim modAuthorizedType As New SPWebConfigModification()
        modAuthorizedType.Name = "AuthType"
        modAuthorizedType.Owner = "SPDActivityDemo"
        modAuthorizedType.Path = "configuration/System.Workflow.ComponentModel.WorkflowCompiler/authorizedTypes"
        modAuthorizedType.Type = SPWebConfigModification.SPWebConfigModificationType.EnsureChildNode
        modAuthorizedType.Value = "<authorizedType Assembly=""SPDActivityDemo, " & "Version=1.0.0.0, Culture=neutral, PublicKeyToken=a66e91d2ee2fa8f8"" " & "Namespace=""SPDActivityDemo"" TypeName=""*"" Authorized=""True"" />"
        wappCurrent.WebConfigModifications.Add(modAuthorizedType)
        wappCurrent.WebService.ApplyWebConfigModifications()
    End Sub





    ' Uncomment the method below to handle the event raised before a feature is deactivated.

    'Public Overrides Sub FeatureDeactivating(ByVal properties As SPFeatureReceiverProperties)
    'End Sub


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
