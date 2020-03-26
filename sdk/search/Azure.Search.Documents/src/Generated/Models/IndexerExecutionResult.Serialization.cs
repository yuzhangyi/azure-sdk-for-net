// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Documents.Models
{
    public partial class IndexerExecutionResult
    {
        internal static IndexerExecutionResult DeserializeIndexerExecutionResult(JsonElement element)
        {
            IndexerExecutionStatus status = default;
            string errorMessage = default;
            DateTimeOffset? startTime = default;
            DateTimeOffset? endTime = default;
            IReadOnlyList<ItemError> errors = default;
            IReadOnlyList<ItemWarning> warnings = default;
            int itemsProcessed = default;
            int itemsFailed = default;
            string initialTrackingState = default;
            string finalTrackingState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("status"))
                {
                    status = property.Value.GetString().ToIndexerExecutionStatus();
                    continue;
                }
                if (property.NameEquals("errorMessage"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    errorMessage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("startTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startTime = property.Value.GetDateTimeOffset("S");
                    continue;
                }
                if (property.NameEquals("endTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    endTime = property.Value.GetDateTimeOffset("S");
                    continue;
                }
                if (property.NameEquals("errors"))
                {
                    List<ItemError> array = new List<ItemError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ItemError.DeserializeItemError(item));
                    }
                    errors = array;
                    continue;
                }
                if (property.NameEquals("warnings"))
                {
                    List<ItemWarning> array = new List<ItemWarning>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ItemWarning.DeserializeItemWarning(item));
                    }
                    warnings = array;
                    continue;
                }
                if (property.NameEquals("itemsProcessed"))
                {
                    itemsProcessed = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("itemsFailed"))
                {
                    itemsFailed = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("initialTrackingState"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    initialTrackingState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("finalTrackingState"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    finalTrackingState = property.Value.GetString();
                    continue;
                }
            }
            return new IndexerExecutionResult(status, errorMessage, startTime, endTime, errors, warnings, itemsProcessed, itemsFailed, initialTrackingState, finalTrackingState);
        }
    }
}
