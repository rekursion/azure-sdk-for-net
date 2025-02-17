// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Hci
{
    /// <summary>
    /// A class representing a collection of <see cref="UpdateRunResource" /> and their operations.
    /// Each <see cref="UpdateRunResource" /> in the collection will belong to the same instance of <see cref="UpdateResource" />.
    /// To get an <see cref="UpdateRunCollection" /> instance call the GetUpdateRuns method from an instance of <see cref="UpdateResource" />.
    /// </summary>
    public partial class UpdateRunCollection : ArmCollection, IEnumerable<UpdateRunResource>, IAsyncEnumerable<UpdateRunResource>
    {
        private readonly ClientDiagnostics _updateRunClientDiagnostics;
        private readonly UpdateRunsRestOperations _updateRunRestClient;

        /// <summary> Initializes a new instance of the <see cref="UpdateRunCollection"/> class for mocking. </summary>
        protected UpdateRunCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="UpdateRunCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal UpdateRunCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _updateRunClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Hci", UpdateRunResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(UpdateRunResource.ResourceType, out string updateRunApiVersion);
            _updateRunRestClient = new UpdateRunsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, updateRunApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != UpdateResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, UpdateResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Put Update runs for a specified update
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/clusters/{clusterName}/updates/{updateName}/updateRuns/{updateRunName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>UpdateRuns_Put</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="updateRunName"> The name of the Update Run. </param>
        /// <param name="data"> Properties of the updateRuns object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="updateRunName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="updateRunName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<UpdateRunResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string updateRunName, UpdateRunData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(updateRunName, nameof(updateRunName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _updateRunClientDiagnostics.CreateScope("UpdateRunCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _updateRunRestClient.PutAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, updateRunName, data, cancellationToken).ConfigureAwait(false);
                var operation = new HciArmOperation<UpdateRunResource>(Response.FromValue(new UpdateRunResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Put Update runs for a specified update
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/clusters/{clusterName}/updates/{updateName}/updateRuns/{updateRunName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>UpdateRuns_Put</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="updateRunName"> The name of the Update Run. </param>
        /// <param name="data"> Properties of the updateRuns object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="updateRunName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="updateRunName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<UpdateRunResource> CreateOrUpdate(WaitUntil waitUntil, string updateRunName, UpdateRunData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(updateRunName, nameof(updateRunName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _updateRunClientDiagnostics.CreateScope("UpdateRunCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _updateRunRestClient.Put(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, updateRunName, data, cancellationToken);
                var operation = new HciArmOperation<UpdateRunResource>(Response.FromValue(new UpdateRunResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the Update run for a specified update
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/clusters/{clusterName}/updates/{updateName}/updateRuns/{updateRunName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>UpdateRuns_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="updateRunName"> The name of the Update Run. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="updateRunName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="updateRunName"/> is null. </exception>
        public virtual async Task<Response<UpdateRunResource>> GetAsync(string updateRunName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(updateRunName, nameof(updateRunName));

            using var scope = _updateRunClientDiagnostics.CreateScope("UpdateRunCollection.Get");
            scope.Start();
            try
            {
                var response = await _updateRunRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, updateRunName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new UpdateRunResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the Update run for a specified update
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/clusters/{clusterName}/updates/{updateName}/updateRuns/{updateRunName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>UpdateRuns_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="updateRunName"> The name of the Update Run. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="updateRunName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="updateRunName"/> is null. </exception>
        public virtual Response<UpdateRunResource> Get(string updateRunName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(updateRunName, nameof(updateRunName));

            using var scope = _updateRunClientDiagnostics.CreateScope("UpdateRunCollection.Get");
            scope.Start();
            try
            {
                var response = _updateRunRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, updateRunName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new UpdateRunResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List all Update runs for a specified update
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/clusters/{clusterName}/updates/{updateName}/updateRuns</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>UpdateRuns_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="UpdateRunResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<UpdateRunResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _updateRunRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _updateRunRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new UpdateRunResource(Client, UpdateRunData.DeserializeUpdateRunData(e)), _updateRunClientDiagnostics, Pipeline, "UpdateRunCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List all Update runs for a specified update
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/clusters/{clusterName}/updates/{updateName}/updateRuns</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>UpdateRuns_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="UpdateRunResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<UpdateRunResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _updateRunRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _updateRunRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new UpdateRunResource(Client, UpdateRunData.DeserializeUpdateRunData(e)), _updateRunClientDiagnostics, Pipeline, "UpdateRunCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/clusters/{clusterName}/updates/{updateName}/updateRuns/{updateRunName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>UpdateRuns_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="updateRunName"> The name of the Update Run. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="updateRunName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="updateRunName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string updateRunName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(updateRunName, nameof(updateRunName));

            using var scope = _updateRunClientDiagnostics.CreateScope("UpdateRunCollection.Exists");
            scope.Start();
            try
            {
                var response = await _updateRunRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, updateRunName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/clusters/{clusterName}/updates/{updateName}/updateRuns/{updateRunName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>UpdateRuns_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="updateRunName"> The name of the Update Run. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="updateRunName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="updateRunName"/> is null. </exception>
        public virtual Response<bool> Exists(string updateRunName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(updateRunName, nameof(updateRunName));

            using var scope = _updateRunClientDiagnostics.CreateScope("UpdateRunCollection.Exists");
            scope.Start();
            try
            {
                var response = _updateRunRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, updateRunName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/clusters/{clusterName}/updates/{updateName}/updateRuns/{updateRunName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>UpdateRuns_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="updateRunName"> The name of the Update Run. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="updateRunName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="updateRunName"/> is null. </exception>
        public virtual async Task<NullableResponse<UpdateRunResource>> GetIfExistsAsync(string updateRunName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(updateRunName, nameof(updateRunName));

            using var scope = _updateRunClientDiagnostics.CreateScope("UpdateRunCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _updateRunRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, updateRunName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<UpdateRunResource>(response.GetRawResponse());
                return Response.FromValue(new UpdateRunResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/clusters/{clusterName}/updates/{updateName}/updateRuns/{updateRunName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>UpdateRuns_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="updateRunName"> The name of the Update Run. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="updateRunName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="updateRunName"/> is null. </exception>
        public virtual NullableResponse<UpdateRunResource> GetIfExists(string updateRunName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(updateRunName, nameof(updateRunName));

            using var scope = _updateRunClientDiagnostics.CreateScope("UpdateRunCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _updateRunRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, updateRunName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<UpdateRunResource>(response.GetRawResponse());
                return Response.FromValue(new UpdateRunResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<UpdateRunResource> IEnumerable<UpdateRunResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<UpdateRunResource> IAsyncEnumerable<UpdateRunResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
