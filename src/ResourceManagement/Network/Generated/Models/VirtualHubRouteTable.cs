// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Fluent.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// VirtualHub route table.
    /// </summary>
    public partial class VirtualHubRouteTable
    {
        /// <summary>
        /// Initializes a new instance of the VirtualHubRouteTable class.
        /// </summary>
        public VirtualHubRouteTable()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VirtualHubRouteTable class.
        /// </summary>
        /// <param name="routes">List of all routes.</param>
        public VirtualHubRouteTable(IList<VirtualHubRoute> routes = default(IList<VirtualHubRoute>))
        {
            Routes = routes;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets list of all routes.
        /// </summary>
        [JsonProperty(PropertyName = "routes")]
        public IList<VirtualHubRoute> Routes { get; set; }

    }
}
