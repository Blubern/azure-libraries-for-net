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
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// An activity log alert resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ActivityLogAlertResourceInner : Microsoft.Azure.Management.ResourceManager.Fluent.Resource
    {
        /// <summary>
        /// Initializes a new instance of the ActivityLogAlertResourceInner
        /// class.
        /// </summary>
        public ActivityLogAlertResourceInner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ActivityLogAlertResourceInner
        /// class.
        /// </summary>
        /// <param name="scopes">A list of resourceIds that will be used as
        /// prefixes. The alert will only apply to activityLogs with
        /// resourceIds that fall under one of these prefixes. This list must
        /// include at least one item.</param>
        /// <param name="condition">The condition that will cause this alert to
        /// activate.</param>
        /// <param name="actions">The actions that will activate when the
        /// condition is met.</param>
        /// <param name="enabled">Indicates whether this activity log alert is
        /// enabled. If an activity log alert is not enabled, then none of its
        /// actions will be activated.</param>
        /// <param name="description">A description of this activity log
        /// alert.</param>
        public ActivityLogAlertResourceInner(IList<string> scopes, ActivityLogAlertAllOfCondition condition, ActivityLogAlertActionList actions, string location = default(string), string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), bool? enabled = default(bool?), string description = default(string))
            : base(location, id, name, type, tags)
        {
            Scopes = scopes;
            Enabled = enabled;
            Condition = condition;
            Actions = actions;
            Description = description;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a list of resourceIds that will be used as prefixes.
        /// The alert will only apply to activityLogs with resourceIds that
        /// fall under one of these prefixes. This list must include at least
        /// one item.
        /// </summary>
        [JsonProperty(PropertyName = "properties.scopes")]
        public IList<string> Scopes { get; set; }

        /// <summary>
        /// Gets or sets indicates whether this activity log alert is enabled.
        /// If an activity log alert is not enabled, then none of its actions
        /// will be activated.
        /// </summary>
        [JsonProperty(PropertyName = "properties.enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Gets or sets the condition that will cause this alert to activate.
        /// </summary>
        [JsonProperty(PropertyName = "properties.condition")]
        public ActivityLogAlertAllOfCondition Condition { get; set; }

        /// <summary>
        /// Gets or sets the actions that will activate when the condition is
        /// met.
        /// </summary>
        [JsonProperty(PropertyName = "properties.actions")]
        public ActivityLogAlertActionList Actions { get; set; }

        /// <summary>
        /// Gets or sets a description of this activity log alert.
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            if (Scopes == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Scopes");
            }
            if (Condition == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Condition");
            }
            if (Actions == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Actions");
            }
            if (Condition != null)
            {
                Condition.Validate();
            }
        }
    }
}
