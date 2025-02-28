// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Compute.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Compute
{
    /// <summary> A class representing the GalleryImageVersion data model. </summary>
    public partial class GalleryImageVersionData : TrackedResource
    {
        /// <summary> Initializes a new instance of GalleryImageVersionData. </summary>
        /// <param name="location"> The location. </param>
        public GalleryImageVersionData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of GalleryImageVersionData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="publishingProfile"> The publishing profile of a gallery image Version. </param>
        /// <param name="provisioningState"> The provisioning state, which only appears in the response. </param>
        /// <param name="storageProfile"> This is the storage profile of a Gallery Image Version. </param>
        /// <param name="replicationStatus"> This is the replication status of the gallery image version. </param>
        internal GalleryImageVersionData(ResourceIdentifier id, string name, ResourceType type, IDictionary<string, string> tags, AzureLocation location, GalleryImageVersionPublishingProfile publishingProfile, GalleryImageVersionPropertiesProvisioningState? provisioningState, GalleryImageVersionStorageProfile storageProfile, ReplicationStatus replicationStatus) : base(id, name, type, tags, location)
        {
            PublishingProfile = publishingProfile;
            ProvisioningState = provisioningState;
            StorageProfile = storageProfile;
            ReplicationStatus = replicationStatus;
        }

        /// <summary> The publishing profile of a gallery image Version. </summary>
        public GalleryImageVersionPublishingProfile PublishingProfile { get; set; }
        /// <summary> The provisioning state, which only appears in the response. </summary>
        public GalleryImageVersionPropertiesProvisioningState? ProvisioningState { get; }
        /// <summary> This is the storage profile of a Gallery Image Version. </summary>
        public GalleryImageVersionStorageProfile StorageProfile { get; set; }
        /// <summary> This is the replication status of the gallery image version. </summary>
        public ReplicationStatus ReplicationStatus { get; }
    }
}
