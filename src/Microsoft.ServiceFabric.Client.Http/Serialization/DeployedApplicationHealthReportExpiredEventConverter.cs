// ------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace Microsoft.ServiceFabric.Client.Http.Serialization
{
    using System;
    using System.Collections.Generic;
    using Microsoft.ServiceFabric.Common;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// Converter for <see cref="DeployedApplicationHealthReportExpiredEvent" />.
    /// </summary>
    internal class DeployedApplicationHealthReportExpiredEventConverter
    {
        /// <summary>
        /// Deserializes the JSON representation of the object.
        /// </summary>
        /// <param name="reader">The <see cref="T: Newtonsoft.Json.JsonReader" /> to read from.</param>
        /// <returns>The object Value.</returns>
        internal static DeployedApplicationHealthReportExpiredEvent Deserialize(JsonReader reader)
        {
            return reader.Deserialize(GetFromJsonProperties);
        }

        /// <summary>
        /// Gets the object from Json properties.
        /// </summary>
        /// <param name="reader">The <see cref="T: Newtonsoft.Json.JsonReader" /> to read from, reader must be placed at first property.</param>
        /// <returns>The object Value.</returns>
        internal static DeployedApplicationHealthReportExpiredEvent GetFromJsonProperties(JsonReader reader)
        {
            var eventInstanceId = default(Guid?);
            var timeStamp = default(DateTime?);
            var hasCorrelatedEvents = default(bool?);
            var applicationId = default(string);
            var applicationInstanceId = default(long?);
            var nodeName = default(NodeName);
            var sourceId = default(string);
            var property = default(string);
            var healthState = default(string);
            var timeToLiveMs = default(long?);
            var sequenceNumber = default(long?);
            var description = default(string);
            var removeWhenExpired = default(bool?);
            var sourceUtcTimestamp = default(DateTime?);

            do
            {
                var propName = reader.ReadPropertyName();
                if (string.Compare("EventInstanceId", propName, StringComparison.Ordinal) == 0)
                {
                    eventInstanceId = reader.ReadValueAsGuid();
                }
                else if (string.Compare("TimeStamp", propName, StringComparison.Ordinal) == 0)
                {
                    timeStamp = reader.ReadValueAsDateTime();
                }
                else if (string.Compare("HasCorrelatedEvents", propName, StringComparison.Ordinal) == 0)
                {
                    hasCorrelatedEvents = reader.ReadValueAsBool();
                }
                else if (string.Compare("ApplicationId", propName, StringComparison.Ordinal) == 0)
                {
                    applicationId = reader.ReadValueAsString();
                }
                else if (string.Compare("ApplicationInstanceId", propName, StringComparison.Ordinal) == 0)
                {
                    applicationInstanceId = reader.ReadValueAsLong();
                }
                else if (string.Compare("NodeName", propName, StringComparison.Ordinal) == 0)
                {
                    nodeName = NodeNameConverter.Deserialize(reader);
                }
                else if (string.Compare("SourceId", propName, StringComparison.Ordinal) == 0)
                {
                    sourceId = reader.ReadValueAsString();
                }
                else if (string.Compare("Property", propName, StringComparison.Ordinal) == 0)
                {
                    property = reader.ReadValueAsString();
                }
                else if (string.Compare("HealthState", propName, StringComparison.Ordinal) == 0)
                {
                    healthState = reader.ReadValueAsString();
                }
                else if (string.Compare("TimeToLiveMs", propName, StringComparison.Ordinal) == 0)
                {
                    timeToLiveMs = reader.ReadValueAsLong();
                }
                else if (string.Compare("SequenceNumber", propName, StringComparison.Ordinal) == 0)
                {
                    sequenceNumber = reader.ReadValueAsLong();
                }
                else if (string.Compare("Description", propName, StringComparison.Ordinal) == 0)
                {
                    description = reader.ReadValueAsString();
                }
                else if (string.Compare("RemoveWhenExpired", propName, StringComparison.Ordinal) == 0)
                {
                    removeWhenExpired = reader.ReadValueAsBool();
                }
                else if (string.Compare("SourceUtcTimestamp", propName, StringComparison.Ordinal) == 0)
                {
                    sourceUtcTimestamp = reader.ReadValueAsDateTime();
                }
                else
                {
                    reader.SkipPropertyValue();
                }
            }
            while (reader.TokenType != JsonToken.EndObject);

            return new DeployedApplicationHealthReportExpiredEvent(
                eventInstanceId: eventInstanceId,
                timeStamp: timeStamp,
                hasCorrelatedEvents: hasCorrelatedEvents,
                applicationId: applicationId,
                applicationInstanceId: applicationInstanceId,
                nodeName: nodeName,
                sourceId: sourceId,
                property: property,
                healthState: healthState,
                timeToLiveMs: timeToLiveMs,
                sequenceNumber: sequenceNumber,
                description: description,
                removeWhenExpired: removeWhenExpired,
                sourceUtcTimestamp: sourceUtcTimestamp);
        }

        /// <summary>
        /// Serializes the object to JSON.
        /// </summary>
        /// <param name="writer">The <see cref="T: Newtonsoft.Json.JsonWriter" /> to write to.</param>
        /// <param name="obj">The object to serialize to JSON.</param>
        internal static void Serialize(JsonWriter writer, DeployedApplicationHealthReportExpiredEvent obj)
        {
            // Required properties are always serialized, optional properties are serialized when not null.
            writer.WriteStartObject();
            writer.WriteProperty(obj.Kind.ToString(), "Kind", JsonWriterExtensions.WriteStringValue);
            writer.WriteProperty(obj.EventInstanceId, "EventInstanceId", JsonWriterExtensions.WriteGuidValue);
            writer.WriteProperty(obj.TimeStamp, "TimeStamp", JsonWriterExtensions.WriteDateTimeValue);
            writer.WriteProperty(obj.ApplicationId, "ApplicationId", JsonWriterExtensions.WriteStringValue);
            writer.WriteProperty(obj.ApplicationInstanceId, "ApplicationInstanceId", JsonWriterExtensions.WriteLongValue);
            writer.WriteProperty(obj.NodeName, "NodeName", NodeNameConverter.Serialize);
            writer.WriteProperty(obj.SourceId, "SourceId", JsonWriterExtensions.WriteStringValue);
            writer.WriteProperty(obj.Property, "Property", JsonWriterExtensions.WriteStringValue);
            writer.WriteProperty(obj.HealthState, "HealthState", JsonWriterExtensions.WriteStringValue);
            writer.WriteProperty(obj.TimeToLiveMs, "TimeToLiveMs", JsonWriterExtensions.WriteLongValue);
            writer.WriteProperty(obj.SequenceNumber, "SequenceNumber", JsonWriterExtensions.WriteLongValue);
            writer.WriteProperty(obj.Description, "Description", JsonWriterExtensions.WriteStringValue);
            writer.WriteProperty(obj.RemoveWhenExpired, "RemoveWhenExpired", JsonWriterExtensions.WriteBoolValue);
            writer.WriteProperty(obj.SourceUtcTimestamp, "SourceUtcTimestamp", JsonWriterExtensions.WriteDateTimeValue);
            if (obj.HasCorrelatedEvents != null)
            {
                writer.WriteProperty(obj.HasCorrelatedEvents, "HasCorrelatedEvents", JsonWriterExtensions.WriteBoolValue);
            }

            writer.WriteEndObject();
        }
    }
}
