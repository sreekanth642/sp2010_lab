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
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.SharePoint.Client;

namespace SilverlightEmployeeContributionsGraph
{
    public class EmployeeContributions
    {
        public string Name { get; set; }
        public string TeamName { get; set; }
        public decimal Contributions { get; set; }
    }

    public class TeamContributions
    {
        public string Name { get; set; }
        public decimal Contributions { get; set; }
    }

    public partial class MainPage : UserControl
    {
        private ListItemCollection _employees;

        public MainPage()
        {
            InitializeComponent();

            ClientContext context = new ClientContext(ApplicationContext.Current.Url);
            context.Load(context.Web);
            List employees = context.Web.Lists.GetByTitle("Employees");
            context.Load(employees);

            CamlQuery query = new CamlQuery();
            string camlQueryXml = null;

            query.ViewXml = camlQueryXml;
            _employees = employees.GetItems(query);
            context.Load(_employees);
            context.ExecuteQueryAsync(new ClientRequestSucceededEventHandler(OnRequestSucceeded), null);
        }

        private void OnRequestSucceeded(Object sender, ClientRequestSucceededEventArgs args)
        {
            // this is not called on the UI thread
            Dispatcher.BeginInvoke(BindData);
        }

        private void BindData()
        {
            List<EmployeeContributions> employees = new List<EmployeeContributions>();

            // get list item values into a strongly typed class
            foreach (ListItem li in _employees)
            {
                employees.Add(new EmployeeContributions
                {
                    Name = li["Title"].ToString(),
                    TeamName = li["Team"].ToString(),
                    Contributions = Convert.ToDecimal(li["Contribution_x0020__x0028_in_x00"])
                });
            }

            // use linq to group employees on team name and then total team contributions
            List<TeamContributions> teams = employees
                .GroupBy(e => e.TeamName)
                .Select(t => new TeamContributions
                {
                    Name = t.Key,
                    Contributions = t.Sum(e => e.Contributions)
                }).ToList();

            chart.DataContext = teams; // must be on UI thread
        }
    }
}
