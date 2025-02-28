// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A class representing the LogicalDatabaseTransparentDataEncryption data model. </summary>
    public partial class LogicalDatabaseTransparentDataEncryptionData : Resource
    {
        /// <summary> Initializes a new instance of LogicalDatabaseTransparentDataEncryptionData. </summary>
        public LogicalDatabaseTransparentDataEncryptionData()
        {
        }

        /// <summary> Initializes a new instance of LogicalDatabaseTransparentDataEncryptionData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="state"> Specifies the state of the transparent data encryption. </param>
        internal LogicalDatabaseTransparentDataEncryptionData(ResourceIdentifier id, string name, ResourceType type, TransparentDataEncryptionState? state) : base(id, name, type)
        {
            State = state;
        }

        /// <summary> Specifies the state of the transparent data encryption. </summary>
        public TransparentDataEncryptionState? State { get; set; }
    }
}
