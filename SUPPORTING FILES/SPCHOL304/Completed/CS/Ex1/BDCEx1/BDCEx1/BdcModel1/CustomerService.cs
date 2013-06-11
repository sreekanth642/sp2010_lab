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
using System.Text;

namespace BDCEx1.BdcModel1
{
    /// <summary>
    /// All the methods for retrieving, updating and deleting data are implemented in this class file.
    /// The samples below show the finder and specific finder method for Entity1.
    /// </summary>
    public class CustomerService
    {
        public static Dictionary<Int32, Customer> d = null;

        public static Customer ReadItem(Int32 id)
        {
            // take a copy for SharePoint
            Customer c = new Customer();
            Customer e = d[id];
            c.CustomerId = e.CustomerId;
            c.FirstName = e.FirstName;
            c.LastName = e.LastName;
            c.Message = e.Message;
            return c;
        }

        public static IEnumerable<Customer> ReadList()
        {
            // this is usually the first method called so check for null
            if (d == null)
            {
                d = new Dictionary<Int32, Customer>();
                for (int i = 0; i < 10; i++)
                {
                    Customer e = new Customer();
                    e.CustomerId = i;
                    e.Message = i + " Item Data";
                    e.FirstName = i + " First Name";
                    e.LastName = i + " Last Name";
                    d.Add(i, e);
                }
            }
            return d.Values;
        }

        public static void Update(Customer customer, Int32 id)
        {
            d[id].FirstName = customer.FirstName;
            d[id].LastName = customer.LastName;
            d[id].Message = customer.Message;
        }

    }
}
