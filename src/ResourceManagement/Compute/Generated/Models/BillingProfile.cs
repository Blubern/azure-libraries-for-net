// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Fluent.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Specifies the billing related details of a Azure Spot VM or VMSS.
    /// &lt;br&gt;&lt;br&gt;Minimum api-version: 2019-03-01.
    /// </summary>
    public partial class BillingProfile
    {
        /// <summary>
        /// Initializes a new instance of the BillingProfile class.
        /// </summary>
        public BillingProfile()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BillingProfile class.
        /// </summary>
        /// <param name="maxPrice">Specifies the maximum price you are willing
        /// to pay for a Azure Spot VM/VMSS. This price is in US Dollars.
        /// &lt;br&gt;&lt;br&gt; This price will be compared with the current
        /// Azure Spot price for the VM size. Also, the prices are compared at
        /// the time of create/update of Azure Spot VM/VMSS and the operation
        /// will only succeed if  the maxPrice is greater than the current
        /// Azure Spot price. &lt;br&gt;&lt;br&gt; The maxPrice will also be
        /// used for evicting a Azure Spot VM/VMSS if the current Azure Spot
        /// price goes beyond the maxPrice after creation of VM/VMSS.
        /// &lt;br&gt;&lt;br&gt; Possible values are: &lt;br&gt;&lt;br&gt; -
        /// Any decimal value greater than zero. Example: 0.01538
        /// &lt;br&gt;&lt;br&gt; -1 – indicates default price to be up-to
        /// on-demand. &lt;br&gt;&lt;br&gt; You can set the maxPrice to -1 to
        /// indicate that the Azure Spot VM/VMSS should not be evicted for
        /// price reasons. Also, the default max price is -1 if it is not
        /// provided by you. &lt;br&gt;&lt;br&gt;Minimum api-version:
        /// 2019-03-01.</param>
        public BillingProfile(double? maxPrice = default(double?))
        {
            MaxPrice = maxPrice;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets specifies the maximum price you are willing to pay for
        /// a Azure Spot VM/VMSS. This price is in US Dollars.
        /// &amp;lt;br&amp;gt;&amp;lt;br&amp;gt; This price will be compared
        /// with the current Azure Spot price for the VM size. Also, the prices
        /// are compared at the time of create/update of Azure Spot VM/VMSS and
        /// the operation will only succeed if  the maxPrice is greater than
        /// the current Azure Spot price. &amp;lt;br&amp;gt;&amp;lt;br&amp;gt;
        /// The maxPrice will also be used for evicting a Azure Spot VM/VMSS if
        /// the current Azure Spot price goes beyond the maxPrice after
        /// creation of VM/VMSS. &amp;lt;br&amp;gt;&amp;lt;br&amp;gt; Possible
        /// values are: &amp;lt;br&amp;gt;&amp;lt;br&amp;gt; - Any decimal
        /// value greater than zero. Example: 0.01538
        /// &amp;lt;br&amp;gt;&amp;lt;br&amp;gt; -1 – indicates default price
        /// to be up-to on-demand. &amp;lt;br&amp;gt;&amp;lt;br&amp;gt; You can
        /// set the maxPrice to -1 to indicate that the Azure Spot VM/VMSS
        /// should not be evicted for price reasons. Also, the default max
        /// price is -1 if it is not provided by you.
        /// &amp;lt;br&amp;gt;&amp;lt;br&amp;gt;Minimum api-version:
        /// 2019-03-01.
        /// </summary>
        [JsonProperty(PropertyName = "maxPrice")]
        public double? MaxPrice { get; set; }

    }
}
