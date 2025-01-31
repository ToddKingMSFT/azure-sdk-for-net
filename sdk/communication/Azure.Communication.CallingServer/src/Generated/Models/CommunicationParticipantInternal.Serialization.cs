// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Communication;
using Azure.Core;

namespace Azure.Communication.CallingServer
{
    internal partial class CommunicationParticipantInternal
    {
        internal static CommunicationParticipantInternal DeserializeCommunicationParticipantInternal(JsonElement element)
        {
            Optional<CommunicationIdentifierModel> identifier = default;
            Optional<string> participantId = default;
            Optional<bool> isMuted = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("identifier"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    identifier = CommunicationIdentifierModel.DeserializeCommunicationIdentifierModel(property.Value);
                    continue;
                }
                if (property.NameEquals("participantId"))
                {
                    participantId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isMuted"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isMuted = property.Value.GetBoolean();
                    continue;
                }
            }
            return new CommunicationParticipantInternal(identifier.Value, participantId.Value, Optional.ToNullable(isMuted));
        }
    }
}
