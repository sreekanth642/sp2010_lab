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

namespace SPHOL200_Ex2.ProviderWebPart
{
    public class ProviderWebPart : Microsoft.SharePoint.WebPartPages.WebPart, IProject
    {
        DropDownList _projectPicker = null;

        int IProject.Id
        {
            get { return int.Parse(_projectPicker.SelectedValue); }
        }

        string IProject.Name
        {
            get { return _projectPicker.SelectedItem.ToString(); }
        }

        public ProviderWebPart()
        {
        }

        protected override void CreateChildControls()
        {
            base.CreateChildControls();

            try
            {
                _projectPicker = new DropDownList();

                using (SPSite spSite = new SPSite(SPContext.Current.Web.Url))
                using (SPWeb spWeb = spSite.OpenWeb())
                {
                    SPList projectsList = spWeb.Lists["Projects"];

                    foreach (SPListItem project in projectsList.Items)
                    {
                        _projectPicker.Items.Add(new ListItem(project.Title, project.ID.ToString()));
                    }
                }

                _projectPicker.AutoPostBack = true;

                this.Controls.Add(_projectPicker);
            }
            catch (Exception ex)
            {
                this.Controls.Clear();
                this.Controls.Add(new LiteralControl(ex.Message));
            }
        }

        [ConnectionProvider("Project Name and ID")]
        public IProject NameDoesNotMatter()
        {
            return this;
        }
    }
}
