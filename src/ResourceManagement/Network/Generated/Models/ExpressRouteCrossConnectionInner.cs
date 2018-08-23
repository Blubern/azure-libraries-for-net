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
    /// ExpressRouteCrossConnection resource
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ExpressRouteCrossConnectionInner : Management.ResourceManager.Fluent.Resource
    {
        /// <summary>
        /// Initializes a new instance of the ExpressRouteCrossConnectionInner
        /// class.
        /// </summary>
        public ExpressRouteCrossConnectionInner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ExpressRouteCrossConnectionInner
        /// class.
        /// </summary>
        /// <param name="primaryAzurePort">The name of the primary
        /// port.</param>
        /// <param name="secondaryAzurePort">The name of the secondary
        /// port.</param>
        /// <param name="sTag">The identifier of the circuit traffic.</param>
        /// <param name="peeringLocation">The peering location of the
        /// ExpressRoute circuit.</param>
        /// <param name="bandwidthInMbps">The circuit bandwidth In
        /// Mbps.</param>
        /// <param name="expressRouteCircuit">The ExpressRouteCircuit</param>
        /// <param name="serviceProviderProvisioningState">The provisioning
        /// state of the circuit in the connectivity provider system. Possible
        /// values are 'NotProvisioned', 'Provisioning', 'Provisioned'.
        /// Possible values include: 'NotProvisioned', 'Provisioning',
        /// 'Provisioned', 'Deprovisioning'</param>
        /// <param name="serviceProviderNotes">Additional read only notes set
        /// by the connectivity provider.</param>
        /// <param name="provisioningState">Gets the provisioning state of the
        /// public IP resource. Possible values are: 'Updating', 'Deleting',
        /// and 'Failed'.</param>
        /// <param name="peerings">The list of peerings.</param>
        /// <param name="etag">Gets a unique read-only string that changes
        /// whenever the resource is updated.</param>
        public ExpressRouteCrossConnectionInner(string location = default(string), string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string primaryAzurePort = default(string), string secondaryAzurePort = default(string), int? sTag = default(int?), string peeringLocation = default(string), int? bandwidthInMbps = default(int?), ExpressRouteCircuitReference expressRouteCircuit = default(ExpressRouteCircuitReference), ServiceProviderProvisioningState serviceProviderProvisioningState = default(ServiceProviderProvisioningState), string serviceProviderNotes = default(string), string provisioningState = default(string), IList<ExpressRouteCrossConnectionPeeringInner> peerings = default(IList<ExpressRouteCrossConnectionPeeringInner>), string etag = default(string))
            : base(location, id, name, type, tags)
        {
            PrimaryAzurePort = primaryAzurePort;
            SecondaryAzurePort = secondaryAzurePort;
            STag = sTag;
            PeeringLocation = peeringLocation;
            BandwidthInMbps = bandwidthInMbps;
            ExpressRouteCircuit = expressRouteCircuit;
            ServiceProviderProvisioningState = serviceProviderProvisioningState;
            ServiceProviderNotes = serviceProviderNotes;
            ProvisioningState = provisioningState;
            Peerings = peerings;
            Etag = etag;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the name of the primary  port.
        /// </summary>
        [JsonProperty(PropertyName = "properties.primaryAzurePort")]
        public string PrimaryAzurePort { get; private set; }

        /// <summary>
        /// Gets the name of the secondary  port.
        /// </summary>
        [JsonProperty(PropertyName = "properties.secondaryAzurePort")]
        public string SecondaryAzurePort { get; private set; }

        /// <summary>
        /// Gets the identifier of the circuit traffic.
        /// </summary>
        [JsonProperty(PropertyName = "properties.sTag")]
        public int? STag { get; private set; }

        /// <summary>
        /// Gets or sets the peering location of the ExpressRoute circuit.
        /// </summary>
        [JsonProperty(PropertyName = "properties.peeringLocation")]
        public string PeeringLocation { get; set; }

        /// <summary>
        /// Gets or sets the circuit bandwidth In Mbps.
        /// </summary>
        [JsonProperty(PropertyName = "properties.bandwidthInMbps")]
        public int? BandwidthInMbps { get; set; }

        /// <summary>
        /// Gets or sets the ExpressRouteCircuit
        /// </summary>
        [JsonProperty(PropertyName = "properties.expressRouteCircuit")]
        public ExpressRouteCircuitReference ExpressRouteCircuit { get; set; }

        /// <summary>
        /// Gets or sets the provisioning state of the circuit in the
        /// connectivity provider system. Possible values are 'NotProvisioned',
        /// 'Provisioning', 'Provisioned'. Possible values include:
        /// 'NotProvisioned', 'Provisioning', 'Provisioned', 'Deprovisioning'
        /// </summary>
        [JsonProperty(PropertyName = "properties.serviceProviderProvisioningState")]
        public ServiceProviderProvisioningState ServiceProviderProvisioningState { get; set; }

        /// <summary>
        /// Gets or sets additional read only notes set by the connectivity
        /// provider.
        /// </summary>
        [JsonProperty(PropertyName = "properties.serviceProviderNotes")]
        public string ServiceProviderNotes { get; set; }

        /// <summary>
        /// Gets the provisioning state of the public IP resource. Possible
        /// values are: 'Updating', 'Deleting', and 'Failed'.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets the list of peerings.
        /// </summary>
        [JsonProperty(PropertyName = "properties.peerings")]
        public IList<ExpressRouteCrossConnectionPeeringInner> Peerings { get; set; }

        /// <summary>
        /// Gets a unique read-only string that changes whenever the resource
        /// is updated.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            if (Peerings != null)
            {
                foreach (var element in Peerings)
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
