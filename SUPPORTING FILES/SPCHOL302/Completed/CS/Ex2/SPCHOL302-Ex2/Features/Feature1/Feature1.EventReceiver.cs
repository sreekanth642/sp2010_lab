//--------------------------------------------------------------------------------
// This file is a "Sample" from the SharePoint Foundation 2010
// Samples
//
// Copyright (c) Microsoft Corporation. All rights reserved.
//
// This source code is intended only as a supplement to Microsoft
// Development Tools and/or on-line documentation.  See these other
// materials for detailed information regarding Microsoft code samples.
// 
// THIS CODE AND INFORMATION ARE PROVIDED AS IS WITHOUT WARRANTY OF ANY
// KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
// IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
// PARTICULAR PURPOSE.
//--------------------------------------------------------------------------------

using System;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Security;
using System.Linq;
namespace SPCHOL302_Ex2.Features.Feature1
{
    /// <summary>
    /// This class handles events raised during feature activation, deactivation, installation, uninstallation, and upgrade.
    /// </summary>
    /// <remarks>
    /// The GUID attached to this class may be used during packaging and should not be modified.
    /// </remarks>

    [Guid("2986c95c-1f8d-4875-af82-5a7e0380906f")]
    public class Feature1EventReceiver : SPFeatureReceiver
    {
        // Uncomment the method below to handle the event raised after a feature has been activated.

        public override void FeatureActivated(SPFeatureReceiverProperties properties)
        {
            using (SPWeb spWeb = properties.Feature.Parent as SPWeb)
            {
                SPContentType newAnnouncement = spWeb
                    .ContentTypes
                    .Cast<SPContentType>()
                    .FirstOrDefault(c => c.Name == "New Announcements");
                if (newAnnouncement != null)
                {
                    newAnnouncement.Delete();
                }

                SPField newField = spWeb.Fields
                    .Cast<SPField>()
                    .FirstOrDefault(f => f.StaticName == "Team Project");
                if (newField != null)
                {
                    newField.Delete();
                }

                SPContentType myContentType =
                    new SPContentType(spWeb.ContentTypes["Announcement"],
                        spWeb.ContentTypes, "New Announcements");
                myContentType.Group = "Custom Content Types";

                spWeb.Fields.Add("Team Project", SPFieldType.Text, true);
                SPFieldLink projFeldLink = new SPFieldLink(spWeb.Fields["Team Project"]);
                myContentType.FieldLinks.Add(projFeldLink);

                SPFieldLink companyFieldLink = new SPFieldLink(spWeb.Fields["Company"]);
                myContentType.FieldLinks.Add(companyFieldLink);

                spWeb.ContentTypes.Add(myContentType);
                myContentType.Update();
            }           


        }


        // Uncomment the method below to handle the event raised before a feature is deactivated.

        public override void FeatureDeactivating(SPFeatureReceiverProperties properties)
        {
            using (SPWeb spWeb = properties.Feature.Parent as SPWeb)
            {
                SPContentType myContentType = spWeb.ContentTypes["New Announcements"];
                spWeb.ContentTypes.Delete(myContentType.Id);
                spWeb.Fields["Team Project"].Delete();
            }

        }


        // Uncomment the method below to handle the event raised after a feature has been installed.

        //public override void FeatureInstalled(SPFeatureReceiverProperties properties)
        //{
        //}


        // Uncomment the method below to handle the event raised before a feature is uninstalled.

        //public override void FeatureUninstalling(SPFeatureReceiverProperties properties)
        //{
        //}

        // Uncomment the method below to handle the event raised when a feature is upgrading.

        //public override void FeatureUpgrading(SPFeatureReceiverProperties properties, string upgradeActionName, System.Collections.Generic.IDictionary<string, string> parameters)
        //{
        //}
    }
}
