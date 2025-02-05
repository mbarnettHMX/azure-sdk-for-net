// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CognitiveServices.Models
{
    public partial class CommitmentPlanAssociation
    {
        internal static CommitmentPlanAssociation DeserializeCommitmentPlanAssociation(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> commitmentPlanId = default;
            Optional<string> commitmentPlanLocation = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("commitmentPlanId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    commitmentPlanId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("commitmentPlanLocation"u8))
                {
                    commitmentPlanLocation = property.Value.GetString();
                    continue;
                }
            }
            return new CommitmentPlanAssociation(commitmentPlanId.Value, commitmentPlanLocation.Value);
        }
    }
}
