// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Fluent.Models
{
    using Microsoft.Azure.Management.ResourceManager;
    using Microsoft.Azure.Management.ResourceManager.Fluent;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A common class for general resource information
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class VirtualNetworkGatewayConnectionInner : Management.ResourceManager.Fluent.Resource
    {
        /// <summary>
        /// Initializes a new instance of the
        /// VirtualNetworkGatewayConnectionInner class.
        /// </summary>
        public VirtualNetworkGatewayConnectionInner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// VirtualNetworkGatewayConnectionInner class.
        /// </summary>
        /// <param name="virtualNetworkGateway1">The reference to virtual
        /// network gateway resource.</param>
        /// <param name="connectionType">Gateway connection type. Possible
        /// values are: 'Ipsec','Vnet2Vnet','ExpressRoute', and 'VPNClient.
        /// Possible values include: 'IPsec', 'Vnet2Vnet', 'ExpressRoute',
        /// 'VPNClient'</param>
        /// <param name="authorizationKey">The authorizationKey.</param>
        /// <param name="virtualNetworkGateway2">The reference to virtual
        /// network gateway resource.</param>
        /// <param name="localNetworkGateway2">The reference to local network
        /// gateway resource.</param>
        /// <param name="routingWeight">The routing weight.</param>
        /// <param name="sharedKey">The IPSec shared key.</param>
        /// <param name="connectionStatus">Virtual network Gateway connection
        /// status. Possible values are 'Unknown', 'Connecting', 'Connected'
        /// and 'NotConnected'. Possible values include: 'Unknown',
        /// 'Connecting', 'Connected', 'NotConnected'</param>
        /// <param name="tunnelConnectionStatus">Collection of all tunnels'
        /// connection health status.</param>
        /// <param name="egressBytesTransferred">The egress bytes transferred
        /// in this connection.</param>
        /// <param name="ingressBytesTransferred">The ingress bytes transferred
        /// in this connection.</param>
        /// <param name="peer">The reference to peerings resource.</param>
        /// <param name="enableBgp">EnableBgp flag</param>
        /// <param name="usePolicyBasedTrafficSelectors">Enable policy-based
        /// traffic selectors.</param>
        /// <param name="ipsecPolicies">The IPSec Policies to be considered by
        /// this connection.</param>
        /// <param name="resourceGuid">The resource GUID property of the
        /// VirtualNetworkGatewayConnection resource.</param>
        /// <param name="provisioningState">The provisioning state of the
        /// VirtualNetworkGatewayConnection resource. Possible values are:
        /// 'Updating', 'Deleting', and 'Failed'.</param>
        /// <param name="etag">Gets a unique read-only string that changes
        /// whenever the resource is updated.</param>
        public VirtualNetworkGatewayConnectionInner(Management.ResourceManager.Fluent.SubResource virtualNetworkGateway1, VirtualNetworkGatewayConnectionType connectionType, string location = default(string), string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string authorizationKey = default(string), Management.ResourceManager.Fluent.SubResource virtualNetworkGateway2 = default(Management.ResourceManager.Fluent.SubResource), Management.ResourceManager.Fluent.SubResource localNetworkGateway2 = default(Management.ResourceManager.Fluent.SubResource), int? routingWeight = default(int?), string sharedKey = default(string), VirtualNetworkGatewayConnectionStatus connectionStatus = default(VirtualNetworkGatewayConnectionStatus), IList<TunnelConnectionHealth> tunnelConnectionStatus = default(IList<TunnelConnectionHealth>), long? egressBytesTransferred = default(long?), long? ingressBytesTransferred = default(long?), Management.ResourceManager.Fluent.SubResource peer = default(Management.ResourceManager.Fluent.SubResource), bool? enableBgp = default(bool?), bool? usePolicyBasedTrafficSelectors = default(bool?), IList<IpsecPolicy> ipsecPolicies = default(IList<IpsecPolicy>), string resourceGuid = default(string), string provisioningState = default(string), string etag = default(string))
            : base(location, id, name, type, tags)
        {
            AuthorizationKey = authorizationKey;
            VirtualNetworkGateway1 = virtualNetworkGateway1;
            VirtualNetworkGateway2 = virtualNetworkGateway2;
            LocalNetworkGateway2 = localNetworkGateway2;
            ConnectionType = connectionType;
            RoutingWeight = routingWeight;
            SharedKey = sharedKey;
            ConnectionStatus = connectionStatus;
            TunnelConnectionStatus = tunnelConnectionStatus;
            EgressBytesTransferred = egressBytesTransferred;
            IngressBytesTransferred = ingressBytesTransferred;
            Peer = peer;
            EnableBgp = enableBgp;
            UsePolicyBasedTrafficSelectors = usePolicyBasedTrafficSelectors;
            IpsecPolicies = ipsecPolicies;
            ResourceGuid = resourceGuid;
            ProvisioningState = provisioningState;
            Etag = etag;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the authorizationKey.
        /// </summary>
        [JsonProperty(PropertyName = "properties.authorizationKey")]
        public string AuthorizationKey { get; set; }

        /// <summary>
        /// Gets or sets the reference to virtual network gateway resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.virtualNetworkGateway1")]
        public Management.ResourceManager.Fluent.SubResource VirtualNetworkGateway1 { get; set; }

        /// <summary>
        /// Gets or sets the reference to virtual network gateway resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.virtualNetworkGateway2")]
        public Management.ResourceManager.Fluent.SubResource VirtualNetworkGateway2 { get; set; }

        /// <summary>
        /// Gets or sets the reference to local network gateway resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.localNetworkGateway2")]
        public Management.ResourceManager.Fluent.SubResource LocalNetworkGateway2 { get; set; }

        /// <summary>
        /// Gets or sets gateway connection type. Possible values are:
        /// 'Ipsec','Vnet2Vnet','ExpressRoute', and 'VPNClient. Possible values
        /// include: 'IPsec', 'Vnet2Vnet', 'ExpressRoute', 'VPNClient'
        /// </summary>
        [JsonProperty(PropertyName = "properties.connectionType")]
        public VirtualNetworkGatewayConnectionType ConnectionType { get; set; }

        /// <summary>
        /// Gets or sets the routing weight.
        /// </summary>
        [JsonProperty(PropertyName = "properties.routingWeight")]
        public int? RoutingWeight { get; set; }

        /// <summary>
        /// Gets or sets the IPSec shared key.
        /// </summary>
        [JsonProperty(PropertyName = "properties.sharedKey")]
        public string SharedKey { get; set; }

        /// <summary>
        /// Gets virtual network Gateway connection status. Possible values are
        /// 'Unknown', 'Connecting', 'Connected' and 'NotConnected'. Possible
        /// values include: 'Unknown', 'Connecting', 'Connected',
        /// 'NotConnected'
        /// </summary>
        [JsonProperty(PropertyName = "properties.connectionStatus")]
        public VirtualNetworkGatewayConnectionStatus ConnectionStatus { get; private set; }

        /// <summary>
        /// Gets collection of all tunnels' connection health status.
        /// </summary>
        [JsonProperty(PropertyName = "properties.tunnelConnectionStatus")]
        public IList<TunnelConnectionHealth> TunnelConnectionStatus { get; private set; }

        /// <summary>
        /// Gets the egress bytes transferred in this connection.
        /// </summary>
        [JsonProperty(PropertyName = "properties.egressBytesTransferred")]
        public long? EgressBytesTransferred { get; private set; }

        /// <summary>
        /// Gets the ingress bytes transferred in this connection.
        /// </summary>
        [JsonProperty(PropertyName = "properties.ingressBytesTransferred")]
        public long? IngressBytesTransferred { get; private set; }

        /// <summary>
        /// Gets or sets the reference to peerings resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.peer")]
        public Management.ResourceManager.Fluent.SubResource Peer { get; set; }

        /// <summary>
        /// Gets or sets enableBgp flag
        /// </summary>
        [JsonProperty(PropertyName = "properties.enableBgp")]
        public bool? EnableBgp { get; set; }

        /// <summary>
        /// Gets or sets enable policy-based traffic selectors.
        /// </summary>
        [JsonProperty(PropertyName = "properties.usePolicyBasedTrafficSelectors")]
        public bool? UsePolicyBasedTrafficSelectors { get; set; }

        /// <summary>
        /// Gets or sets the IPSec Policies to be considered by this
        /// connection.
        /// </summary>
        [JsonProperty(PropertyName = "properties.ipsecPolicies")]
        public IList<IpsecPolicy> IpsecPolicies { get; set; }

        /// <summary>
        /// Gets or sets the resource GUID property of the
        /// VirtualNetworkGatewayConnection resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.resourceGuid")]
        public string ResourceGuid { get; set; }

        /// <summary>
        /// Gets the provisioning state of the VirtualNetworkGatewayConnection
        /// resource. Possible values are: 'Updating', 'Deleting', and
        /// 'Failed'.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets a unique read-only string that changes whenever the resource
        /// is updated.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            if (VirtualNetworkGateway1 == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "VirtualNetworkGateway1");
            }
            if (ConnectionType == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ConnectionType");
            }
            if (IpsecPolicies != null)
            {
                foreach (var element in IpsecPolicies)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
