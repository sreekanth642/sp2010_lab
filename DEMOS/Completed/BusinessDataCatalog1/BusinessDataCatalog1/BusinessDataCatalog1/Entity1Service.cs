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

namespace BusinessDataCatalog1.BusinessDataCatalog1
{
    /// <summary>
    /// All the methods for retrieving, updating and deleting data are implemented in this class file.
    /// The samples below show the finder and specific finder method for Entity1.
    /// </summary>
    public class Entity1Service
    {
    public static Dictionary<string, Entity1> d = new Dictionary<string, Entity1>()
        {
            {"0", new Entity1(){Identifier1="0", Message="Paul"}},
            {"1", new Entity1(){Identifier1="1", Message="Peter"}}
        };     
        /// <summary>
        /// This is a sample specific finder method for Entity1. If you want to delete or rename the method think about changing the xml
        /// in the BDC model file as well.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Entity1</returns>
        public static Entity1 GetEntityById(string id)
        {
            return new Entity1() { Identifier1 = d[id].Identifier1, Message = d[id].Message };
        }
        /// <summary>
        /// This is a sample specific method for Entity1. If you want to delete or rename the method think about changing the xml
        /// in the BDC model file as well.
        /// </summary>
        /// <returns>IEnumerable of Entity1</returns>
        public static IEnumerable<Entity1> FindAllEntities()
        {
            return d.Values;
        }

        public static void Update(Entity1 Entity1, string Identifier1)
        {
            d[Entity1.Identifier1].Message = Entity1.Message;
        }
    }
}
