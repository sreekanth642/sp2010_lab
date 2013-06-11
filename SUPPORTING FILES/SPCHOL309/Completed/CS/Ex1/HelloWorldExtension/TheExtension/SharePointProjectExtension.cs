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

using System.ComponentModel.Composition;
using Microsoft.VisualStudio.SharePoint;
using System.Linq;
using System.Windows;
using System;
using System.Collections.Generic;
using System.Threading;

/// <summary>
/// Empty VSIX Project.
/// </summary>
namespace TheExtension
{

    [Export(typeof(ISharePointProjectExtension))]
    public class SharePointProjectExtension : ISharePointProjectExtension
    {

        public void Initialize(ISharePointProjectService projectService)
        {
            var items = from pi in projectService.ProjectItemTypes
                        where pi.Key == "Microsoft.VisualStudio.SharePoint.ListDefinition"
                        select pi.Value;
            var listType = items.FirstOrDefault();
            listType.ProjectItemMenuItemsRequested += ContextMenuRequested;
        }
        void ContextMenuRequested(object sender, SharePointProjectItemMenuItemsRequestedEventArgs e)
        {
            var mi = e.ViewMenuItems.Add("Hello SharePoint Extensibility!");
            mi.Click += ContextMenuClicked;
        }
        void ContextMenuClicked(object sender, MenuItemEventArgs e)
        {
            MessageBox.Show("Hello From a SharePoint project extension");
        }


    }

}
