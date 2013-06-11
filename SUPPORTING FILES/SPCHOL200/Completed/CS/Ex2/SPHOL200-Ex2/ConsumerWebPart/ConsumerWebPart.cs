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

namespace SPHOL200_Ex2.ConsumerWebPart
{
    public class ConsumerWebPart : WebPart
    {
        IProject _provider = null;
        Label _lbl = null;

        public ConsumerWebPart()
        {
        }

        protected override void CreateChildControls()
        {
            base.CreateChildControls();

            try
            {
                _lbl = new Label();

                if (_provider != null)
                {
                    if (_provider.Id > 0)
                    {
                        _lbl.Text = _provider.Name + " was selected.";
                    }
                    else
                    {
                        _lbl.Text = "Nothing was selected.";
                    }
                }
                else
                {
                    _lbl.Text = "No Provider Web Part Connected.";
                }

                this.Controls.Add(_lbl);
            }
            catch (Exception ex)
            {
                this.Controls.Clear();
                this.Controls.Add(new LiteralControl(ex.Message));
            }
        }

        [ConnectionConsumer("Project Name and ID")]
        public void ThisNameDoesNotMatter(IProject providerInterface)
        {
            _provider = providerInterface;
        }      
    }
}
