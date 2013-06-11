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
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using SPCHOL303_Ex2.ServiceReference1;
using System.Net;
        
namespace SPCHOL303_Ex2
{
    public partial class Form1 : Form
    {
        TeamSiteDataContext context =
               new TeamSiteDataContext(new Uri("http://intranet.contoso.com/_vti_bin/ListData.svc"));
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            context.Credentials = CredentialCache.DefaultCredentials;
            employeesBindingSource.DataSource = context.Employees;

        }

        private void employeesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

            context.SaveChanges();

        }

        private void employeesBindingSource_CurrentChanged(object sender, EventArgs e)
        {

            context.UpdateObject(employeesBindingSource.Current);
        
        }
    }
}
