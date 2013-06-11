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
using System.Security.Permissions;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Security;
using Microsoft.SharePoint.Utilities;
using Microsoft.SharePoint.Workflow;

namespace Bugs.BugListItemEvent
{
    /// <summary>
    /// List Item Events
    /// </summary>
    public class BugListItemEvent : SPItemEventReceiver
    {
        /// <summary>
        /// An item is being added.
        /// </summary>
        public override void ItemAdding(SPItemEventProperties properties)
        {
            base.ItemAdding(properties);
            try
            {
                this.EventFiringEnabled = false;
                AutoAssign(properties);
            }
            catch (Exception ex)
            {
                //ToLog ex
                return;
            }
            finally
            {
                this.EventFiringEnabled = true;
            }
        }

        /// <summary>
        /// An item is being updated.
        /// </summary>
        public override void ItemUpdating(SPItemEventProperties properties)
        {
            base.ItemUpdating(properties);
            try
            {
                this.EventFiringEnabled = false;
                AutoAssign(properties);
            }
            catch (Exception ex)
            {
                //ToLog ex
                return;
            }
            finally
            {
                this.EventFiringEnabled = true;
            }
        }

        /// <summary>
        /// An item is being deleted.
        /// </summary>
        public override void ItemDeleting(SPItemEventProperties properties)
        {
            base.ItemDeleting(properties);
try
{
    properties.Cancel = true;
    properties.ErrorMessage = "Bugs can only be resolved not deleted!";
}
catch (Exception ex)
{
    //ToLog ex
    return;
}
finally
{
    this.EventFiringEnabled = true;
}
        }

        private static void AutoAssign(SPItemEventProperties properties)
        {
            string projectName = properties.AfterProperties["BugProject"].ToString();
            SPList projectList = properties.Web.GetList("Lists/Projects");
            foreach (SPListItem item in projectList.Items)
            {
                if (item.Title.ToLower().Contains(projectName.ToLower()))
                {
                    string contact = item["Primary Contact"].ToString();
                    if (contact.Contains(";#"))
                    {
                        contact = contact.Split('#')[1];
                    }
                    properties.AfterProperties["BugAssignedTo"] = contact;
                    break;
                }
            }
        }
    }
}
