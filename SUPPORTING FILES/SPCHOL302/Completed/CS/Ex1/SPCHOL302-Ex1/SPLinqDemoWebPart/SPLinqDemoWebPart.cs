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
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using Microsoft.SharePoint;
using Microsoft.SharePoint.WebControls;

namespace SPCHOL302_Ex1.SPLinqDemoWebPart
{
    public class SPLinqDemoWebPart : WebPart
    {
        protected const string _ascxPath = @"~/_CONTROLTEMPLATES/SPCHOL302_Ex1/SPLinqDemoWebPart/SPLinqDemoWebPartUserControl.ascx";

        public SPLinqDemoWebPart()
        {
        }

        protected override void CreateChildControls()
        {
            try
            {
                Control control = this.Page.LoadControl(_ascxPath);
                Controls.Add(control);
            }
            finally
            {
                base.CreateChildControls();
            }
        }

        protected override void Render(HtmlTextWriter writer)
        {
            base.Render(writer);
        }
    }
}
