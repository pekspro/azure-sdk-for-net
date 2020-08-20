// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class MaxSizeCapability
    {
        internal static MaxSizeCapability DeserializeMaxSizeCapability(JsonElement element)
        {
            Optional<int> limit = default;
            Optional<MaxSizeUnit> unit = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("limit"))
                {
                    limit = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("unit"))
                {
                    unit = new MaxSizeUnit(property.Value.GetString());
                    continue;
                }
            }
            return new MaxSizeCapability(Optional.ToNullable(limit), Optional.ToNullable(unit));
        }
    }
}