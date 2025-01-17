// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class GrantAccessData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("access"u8);
            writer.WriteStringValue(Access.ToString());
            writer.WritePropertyName("durationInSeconds"u8);
            writer.WriteNumberValue(DurationInSeconds);
            if (Optional.IsDefined(GetSecureVmGuestStateSas))
            {
                writer.WritePropertyName("getSecureVMGuestStateSAS"u8);
                writer.WriteBooleanValue(GetSecureVmGuestStateSas.Value);
            }
            writer.WriteEndObject();
        }
    }
}
