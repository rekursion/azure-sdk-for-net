// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Qumulo
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    internal partial class SubscriptionResourceExtensionClient : ArmResource
    {
        private ClientDiagnostics _qumuloFileSystemResourceFileSystemsClientDiagnostics;
        private FileSystemsRestOperations _qumuloFileSystemResourceFileSystemsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SubscriptionResourceExtensionClient"/> class for mocking. </summary>
        protected SubscriptionResourceExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SubscriptionResourceExtensionClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SubscriptionResourceExtensionClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics QumuloFileSystemResourceFileSystemsClientDiagnostics => _qumuloFileSystemResourceFileSystemsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Qumulo", QumuloFileSystemResource.ResourceType.Namespace, Diagnostics);
        private FileSystemsRestOperations QumuloFileSystemResourceFileSystemsRestClient => _qumuloFileSystemResourceFileSystemsRestClient ??= new FileSystemsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(QumuloFileSystemResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// List FileSystemResource resources by subscription ID
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Qumulo.Storage/fileSystems</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FileSystems_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="QumuloFileSystemResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<QumuloFileSystemResource> GetQumuloFileSystemResourcesAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => QumuloFileSystemResourceFileSystemsRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => QumuloFileSystemResourceFileSystemsRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new QumuloFileSystemResource(Client, QumuloFileSystemResourceData.DeserializeQumuloFileSystemResourceData(e)), QumuloFileSystemResourceFileSystemsClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetQumuloFileSystemResources", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List FileSystemResource resources by subscription ID
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Qumulo.Storage/fileSystems</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FileSystems_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="QumuloFileSystemResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<QumuloFileSystemResource> GetQumuloFileSystemResources(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => QumuloFileSystemResourceFileSystemsRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => QumuloFileSystemResourceFileSystemsRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new QumuloFileSystemResource(Client, QumuloFileSystemResourceData.DeserializeQumuloFileSystemResourceData(e)), QumuloFileSystemResourceFileSystemsClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetQumuloFileSystemResources", "value", "nextLink", cancellationToken);
        }
    }
}
