// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Storage.Fluent.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The capability information in the specified SKU, including file
    /// encryption, network ACLs, change notification, etc.
    /// </summary>
    public partial class SKUCapability
    {
        /// <summary>
        /// Initializes a new instance of the SKUCapability class.
        /// </summary>
        public SKUCapability()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SKUCapability class.
        /// </summary>
        /// <param name="name">The name of capability, The capability
        /// information in the specified SKU, including file encryption,
        /// network ACLs, change notification, etc.</param>
        /// <param name="value">A string value to indicate states of given
        /// capability. Possibly 'true' or 'false'.</param>
        public SKUCapability(string name = default(string), string value = default(string))
        {
            Name = name;
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the name of capability, The capability information in the
        /// specified SKU, including file encryption, network ACLs, change
        /// notification, etc.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets a string value to indicate states of given capability.
        /// Possibly 'true' or 'false'.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; private set; }

    }
}
