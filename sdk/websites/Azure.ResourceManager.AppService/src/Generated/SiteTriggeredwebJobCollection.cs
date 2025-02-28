// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A class representing collection of TriggeredWebJob and their operations over its parent. </summary>
    public partial class SiteTriggeredwebJobCollection : ArmCollection, IEnumerable<SiteTriggeredwebJob>, IAsyncEnumerable<SiteTriggeredwebJob>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly WebAppsRestOperations _webAppsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SiteTriggeredwebJobCollection"/> class for mocking. </summary>
        protected SiteTriggeredwebJobCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SiteTriggeredwebJobCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal SiteTriggeredwebJobCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            ClientOptions.TryGetApiVersion(SiteTriggeredwebJob.ResourceType, out string apiVersion);
            _webAppsRestClient = new WebAppsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SiteSlot.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SiteSlot.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/triggeredwebjobs/{webJobName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}
        /// OperationId: WebApps_GetTriggeredWebJobSlot
        /// <summary> Description for Gets a triggered web job by its ID for an app, or a deployment slot. </summary>
        /// <param name="webJobName"> Name of Web Job. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="webJobName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="webJobName"/> is null. </exception>
        public virtual Response<SiteTriggeredwebJob> Get(string webJobName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(webJobName, nameof(webJobName));

            using var scope = _clientDiagnostics.CreateScope("SiteTriggeredwebJobCollection.Get");
            scope.Start();
            try
            {
                var response = _webAppsRestClient.GetTriggeredWebJobSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, webJobName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteTriggeredwebJob(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/triggeredwebjobs/{webJobName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}
        /// OperationId: WebApps_GetTriggeredWebJobSlot
        /// <summary> Description for Gets a triggered web job by its ID for an app, or a deployment slot. </summary>
        /// <param name="webJobName"> Name of Web Job. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="webJobName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="webJobName"/> is null. </exception>
        public async virtual Task<Response<SiteTriggeredwebJob>> GetAsync(string webJobName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(webJobName, nameof(webJobName));

            using var scope = _clientDiagnostics.CreateScope("SiteTriggeredwebJobCollection.Get");
            scope.Start();
            try
            {
                var response = await _webAppsRestClient.GetTriggeredWebJobSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, webJobName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new SiteTriggeredwebJob(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="webJobName"> Name of Web Job. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="webJobName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="webJobName"/> is null. </exception>
        public virtual Response<SiteTriggeredwebJob> GetIfExists(string webJobName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(webJobName, nameof(webJobName));

            using var scope = _clientDiagnostics.CreateScope("SiteTriggeredwebJobCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _webAppsRestClient.GetTriggeredWebJobSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, webJobName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<SiteTriggeredwebJob>(null, response.GetRawResponse());
                return Response.FromValue(new SiteTriggeredwebJob(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="webJobName"> Name of Web Job. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="webJobName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="webJobName"/> is null. </exception>
        public async virtual Task<Response<SiteTriggeredwebJob>> GetIfExistsAsync(string webJobName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(webJobName, nameof(webJobName));

            using var scope = _clientDiagnostics.CreateScope("SiteTriggeredwebJobCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _webAppsRestClient.GetTriggeredWebJobSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, webJobName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<SiteTriggeredwebJob>(null, response.GetRawResponse());
                return Response.FromValue(new SiteTriggeredwebJob(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="webJobName"> Name of Web Job. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="webJobName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="webJobName"/> is null. </exception>
        public virtual Response<bool> Exists(string webJobName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(webJobName, nameof(webJobName));

            using var scope = _clientDiagnostics.CreateScope("SiteTriggeredwebJobCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(webJobName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="webJobName"> Name of Web Job. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="webJobName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="webJobName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string webJobName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(webJobName, nameof(webJobName));

            using var scope = _clientDiagnostics.CreateScope("SiteTriggeredwebJobCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(webJobName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/triggeredwebjobs
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}
        /// OperationId: WebApps_ListTriggeredWebJobsSlot
        /// <summary> Description for List triggered web jobs for an app, or a deployment slot. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SiteTriggeredwebJob" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SiteTriggeredwebJob> GetAll(CancellationToken cancellationToken = default)
        {
            Page<SiteTriggeredwebJob> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SiteTriggeredwebJobCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _webAppsRestClient.ListTriggeredWebJobsSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteTriggeredwebJob(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SiteTriggeredwebJob> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SiteTriggeredwebJobCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _webAppsRestClient.ListTriggeredWebJobsSlotNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteTriggeredwebJob(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/triggeredwebjobs
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}
        /// OperationId: WebApps_ListTriggeredWebJobsSlot
        /// <summary> Description for List triggered web jobs for an app, or a deployment slot. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SiteTriggeredwebJob" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SiteTriggeredwebJob> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SiteTriggeredwebJob>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SiteTriggeredwebJobCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _webAppsRestClient.ListTriggeredWebJobsSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteTriggeredwebJob(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SiteTriggeredwebJob>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SiteTriggeredwebJobCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _webAppsRestClient.ListTriggeredWebJobsSlotNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteTriggeredwebJob(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<SiteTriggeredwebJob> IEnumerable<SiteTriggeredwebJob>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SiteTriggeredwebJob> IAsyncEnumerable<SiteTriggeredwebJob>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, SiteTriggeredwebJob, TriggeredWebJobData> Construct() { }
    }
}
