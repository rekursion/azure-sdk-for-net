// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> CopyComputeScale properties for managed integration runtime. </summary>
    public partial class CopyComputeScaleProperties
    {
        /// <summary> Initializes a new instance of CopyComputeScaleProperties. </summary>
        public CopyComputeScaleProperties()
        {
            AdditionalProperties = new ChangeTrackingDictionary<string, BinaryData>();
        }

        /// <summary> Initializes a new instance of CopyComputeScaleProperties. </summary>
        /// <param name="dataIntegrationUnit"> DIU number setting reserved for copy activity execution. Supported values are multiples of 4 in range 4-256. </param>
        /// <param name="timeToLive"> Time to live (in minutes) setting of integration runtime which will execute copy activity. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal CopyComputeScaleProperties(int? dataIntegrationUnit, int? timeToLive, IDictionary<string, BinaryData> additionalProperties)
        {
            DataIntegrationUnit = dataIntegrationUnit;
            TimeToLive = timeToLive;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> DIU number setting reserved for copy activity execution. Supported values are multiples of 4 in range 4-256. </summary>
        public int? DataIntegrationUnit { get; set; }
        /// <summary> Time to live (in minutes) setting of integration runtime which will execute copy activity. </summary>
        public int? TimeToLive { get; set; }
        /// <summary>
        /// Additional Properties
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formated json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        public IDictionary<string, BinaryData> AdditionalProperties { get; }
    }
}
