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
    /// Properties of the revoked VPN client certificate of
    /// VpnServerConfiguration.
    /// </summary>
    public partial class VpnServerConfigVpnClientRevokedCertificate
    {
        /// <summary>
        /// Initializes a new instance of the
        /// VpnServerConfigVpnClientRevokedCertificate class.
        /// </summary>
        public VpnServerConfigVpnClientRevokedCertificate()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// VpnServerConfigVpnClientRevokedCertificate class.
        /// </summary>
        /// <param name="name">The certificate name.</param>
        /// <param name="thumbprint">The revoked VPN client certificate
        /// thumbprint.</param>
        public VpnServerConfigVpnClientRevokedCertificate(string name = default(string), string thumbprint = default(string))
        {
            Name = name;
            Thumbprint = thumbprint;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the certificate name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the revoked VPN client certificate thumbprint.
        /// </summary>
        [JsonProperty(PropertyName = "thumbprint")]
        public string Thumbprint { get; set; }

    }
}