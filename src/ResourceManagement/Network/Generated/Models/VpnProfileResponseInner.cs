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
    using System.Linq;

    /// <summary>
    /// Vpn Profile Response for package generation.
    /// </summary>
    public partial class VpnProfileResponseInner
    {
        /// <summary>
        /// Initializes a new instance of the VpnProfileResponseInner class.
        /// </summary>
        public VpnProfileResponseInner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VpnProfileResponseInner class.
        /// </summary>
        /// <param name="profileUrl">URL to the VPN profile.</param>
        public VpnProfileResponseInner(string profileUrl = default(string))
        {
            ProfileUrl = profileUrl;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets URL to the VPN profile.
        /// </summary>
        [JsonProperty(PropertyName = "profileUrl")]
        public string ProfileUrl { get; set; }

    }
}
