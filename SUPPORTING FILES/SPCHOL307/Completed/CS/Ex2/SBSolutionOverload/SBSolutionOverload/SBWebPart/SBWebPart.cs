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
using System.ComponentModel;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using Microsoft.SharePoint;
using Microsoft.SharePoint.WebControls;

namespace SBSolutionOverload.SBWebPart
{
    [ToolboxItemAttribute(false)]
    public class SBWebPart : WebPart
    {
        protected override void CreateChildControls()
        {
            base.CreateChildControls();

            Label lbl = new Label();

            TextBox txt = new TextBox();
            Button btn = new Button();
            DateTime dt = DateTime.Now;
            btn.Text = "Show All Lists";
            btn.Click += delegate
            {
                do
                {
                    SPWebCollection Webs;
                    SPListCollection lists;
                    Webs = SPContext.Current.Site.AllWebs;
                    foreach (SPWeb web in Webs)
                    {
                        lists = web.Lists;
                        foreach (SPList list in lists)
                            lbl.Text = lbl.Text + "<br>" + list.Title;
                    }
                }
                while (dt.AddSeconds(int.Parse(txt.Text)).CompareTo(DateTime.Now) > 0);
            };
            Controls.Add(txt);
            Controls.Add(btn);

            Controls.Add(lbl);
        }
    }
}
