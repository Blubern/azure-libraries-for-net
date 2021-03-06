// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Monitor.Fluent.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Specifies the metric alert rule criteria for a web test resource.
    /// </summary>
    [Newtonsoft.Json.JsonObject("Microsoft.Azure.Monitor.WebtestLocationAvailabilityCriteria")]
    public partial class WebtestLocationAvailabilityCriteria : MetricAlertCriteria
    {
        /// <summary>
        /// Initializes a new instance of the
        /// WebtestLocationAvailabilityCriteria class.
        /// </summary>
        public WebtestLocationAvailabilityCriteria()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// WebtestLocationAvailabilityCriteria class.
        /// </summary>
        /// <param name="webTestId">The Application Insights web test
        /// Id.</param>
        /// <param name="componentId">The Application Insights resource
        /// Id.</param>
        /// <param name="failedLocationCount">The number of failed
        /// locations.</param>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        public WebtestLocationAvailabilityCriteria(string webTestId, string componentId, double failedLocationCount, IDictionary<string, object> additionalProperties = default(IDictionary<string, object>))
            : base(additionalProperties)
        {
            WebTestId = webTestId;
            ComponentId = componentId;
            FailedLocationCount = failedLocationCount;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the Application Insights web test Id.
        /// </summary>
        [JsonProperty(PropertyName = "webTestId")]
        public string WebTestId { get; set; }

        /// <summary>
        /// Gets or sets the Application Insights resource Id.
        /// </summary>
        [JsonProperty(PropertyName = "componentId")]
        public string ComponentId { get; set; }

        /// <summary>
        /// Gets or sets the number of failed locations.
        /// </summary>
        [JsonProperty(PropertyName = "failedLocationCount")]
        public double FailedLocationCount { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (WebTestId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "WebTestId");
            }
            if (ComponentId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ComponentId");
            }
        }
    }
}
