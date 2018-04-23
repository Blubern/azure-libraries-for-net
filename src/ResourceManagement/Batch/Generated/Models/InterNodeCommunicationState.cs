// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Batch.Fluent.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for InterNodeCommunicationState.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum InterNodeCommunicationState
    {
        [EnumMember(Value = "Enabled")]
        Enabled,
        [EnumMember(Value = "Disabled")]
        Disabled
    }
    internal static class InterNodeCommunicationStateEnumExtension
    {
        internal static string ToSerializedValue(this InterNodeCommunicationState? value)
        {
            return value == null ? null : ((InterNodeCommunicationState)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this InterNodeCommunicationState value)
        {
            switch( value )
            {
                case InterNodeCommunicationState.Enabled:
                    return "Enabled";
                case InterNodeCommunicationState.Disabled:
                    return "Disabled";
            }
            return null;
        }

        internal static InterNodeCommunicationState? ParseInterNodeCommunicationState(this string value)
        {
            switch( value )
            {
                case "Enabled":
                    return InterNodeCommunicationState.Enabled;
                case "Disabled":
                    return InterNodeCommunicationState.Disabled;
            }
            return null;
        }
    }
}