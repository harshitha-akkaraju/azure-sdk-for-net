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
    /// <summary> A class representing collection of PublicCertificate and their operations over its parent. </summary>
    public partial class SitePublicCertificateCollection : ArmCollection, IEnumerable<SitePublicCertificate>, IAsyncEnumerable<SitePublicCertificate>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly WebAppsRestOperations _webAppsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SitePublicCertificateCollection"/> class for mocking. </summary>
        protected SitePublicCertificateCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SitePublicCertificateCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal SitePublicCertificateCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            ClientOptions.TryGetApiVersion(SitePublicCertificate.ResourceType, out string apiVersion);
            _webAppsRestClient = new WebAppsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != WebSite.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, WebSite.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/publicCertificates/{publicCertificateName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}
        /// OperationId: WebApps_CreateOrUpdatePublicCertificate
        /// <summary> Description for Creates a hostname binding for an app. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="publicCertificateName"> Public certificate name. </param>
        /// <param name="publicCertificate"> Public certificate details. This is the JSON representation of a PublicCertificate object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="publicCertificateName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="publicCertificateName"/> or <paramref name="publicCertificate"/> is null. </exception>
        public virtual SitePublicCertificateCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string publicCertificateName, PublicCertificateData publicCertificate, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(publicCertificateName, nameof(publicCertificateName));
            if (publicCertificate == null)
            {
                throw new ArgumentNullException(nameof(publicCertificate));
            }

            using var scope = _clientDiagnostics.CreateScope("SitePublicCertificateCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _webAppsRestClient.CreateOrUpdatePublicCertificate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, publicCertificateName, publicCertificate, cancellationToken);
                var operation = new SitePublicCertificateCreateOrUpdateOperation(this, response);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/publicCertificates/{publicCertificateName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}
        /// OperationId: WebApps_CreateOrUpdatePublicCertificate
        /// <summary> Description for Creates a hostname binding for an app. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="publicCertificateName"> Public certificate name. </param>
        /// <param name="publicCertificate"> Public certificate details. This is the JSON representation of a PublicCertificate object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="publicCertificateName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="publicCertificateName"/> or <paramref name="publicCertificate"/> is null. </exception>
        public async virtual Task<SitePublicCertificateCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string publicCertificateName, PublicCertificateData publicCertificate, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(publicCertificateName, nameof(publicCertificateName));
            if (publicCertificate == null)
            {
                throw new ArgumentNullException(nameof(publicCertificate));
            }

            using var scope = _clientDiagnostics.CreateScope("SitePublicCertificateCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _webAppsRestClient.CreateOrUpdatePublicCertificateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, publicCertificateName, publicCertificate, cancellationToken).ConfigureAwait(false);
                var operation = new SitePublicCertificateCreateOrUpdateOperation(this, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/publicCertificates/{publicCertificateName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}
        /// OperationId: WebApps_GetPublicCertificate
        /// <summary> Description for Get the named public certificate for an app (or deployment slot, if specified). </summary>
        /// <param name="publicCertificateName"> Public certificate name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="publicCertificateName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="publicCertificateName"/> is null. </exception>
        public virtual Response<SitePublicCertificate> Get(string publicCertificateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(publicCertificateName, nameof(publicCertificateName));

            using var scope = _clientDiagnostics.CreateScope("SitePublicCertificateCollection.Get");
            scope.Start();
            try
            {
                var response = _webAppsRestClient.GetPublicCertificate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, publicCertificateName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SitePublicCertificate(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/publicCertificates/{publicCertificateName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}
        /// OperationId: WebApps_GetPublicCertificate
        /// <summary> Description for Get the named public certificate for an app (or deployment slot, if specified). </summary>
        /// <param name="publicCertificateName"> Public certificate name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="publicCertificateName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="publicCertificateName"/> is null. </exception>
        public async virtual Task<Response<SitePublicCertificate>> GetAsync(string publicCertificateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(publicCertificateName, nameof(publicCertificateName));

            using var scope = _clientDiagnostics.CreateScope("SitePublicCertificateCollection.Get");
            scope.Start();
            try
            {
                var response = await _webAppsRestClient.GetPublicCertificateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, publicCertificateName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new SitePublicCertificate(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="publicCertificateName"> Public certificate name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="publicCertificateName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="publicCertificateName"/> is null. </exception>
        public virtual Response<SitePublicCertificate> GetIfExists(string publicCertificateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(publicCertificateName, nameof(publicCertificateName));

            using var scope = _clientDiagnostics.CreateScope("SitePublicCertificateCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _webAppsRestClient.GetPublicCertificate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, publicCertificateName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<SitePublicCertificate>(null, response.GetRawResponse());
                return Response.FromValue(new SitePublicCertificate(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="publicCertificateName"> Public certificate name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="publicCertificateName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="publicCertificateName"/> is null. </exception>
        public async virtual Task<Response<SitePublicCertificate>> GetIfExistsAsync(string publicCertificateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(publicCertificateName, nameof(publicCertificateName));

            using var scope = _clientDiagnostics.CreateScope("SitePublicCertificateCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _webAppsRestClient.GetPublicCertificateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, publicCertificateName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<SitePublicCertificate>(null, response.GetRawResponse());
                return Response.FromValue(new SitePublicCertificate(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="publicCertificateName"> Public certificate name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="publicCertificateName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="publicCertificateName"/> is null. </exception>
        public virtual Response<bool> Exists(string publicCertificateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(publicCertificateName, nameof(publicCertificateName));

            using var scope = _clientDiagnostics.CreateScope("SitePublicCertificateCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(publicCertificateName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="publicCertificateName"> Public certificate name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="publicCertificateName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="publicCertificateName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string publicCertificateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(publicCertificateName, nameof(publicCertificateName));

            using var scope = _clientDiagnostics.CreateScope("SitePublicCertificateCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(publicCertificateName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/publicCertificates
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}
        /// OperationId: WebApps_ListPublicCertificates
        /// <summary> Description for Get public certificates for an app or a deployment slot. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SitePublicCertificate" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SitePublicCertificate> GetAll(CancellationToken cancellationToken = default)
        {
            Page<SitePublicCertificate> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SitePublicCertificateCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _webAppsRestClient.ListPublicCertificates(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SitePublicCertificate(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SitePublicCertificate> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SitePublicCertificateCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _webAppsRestClient.ListPublicCertificatesNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SitePublicCertificate(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/publicCertificates
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}
        /// OperationId: WebApps_ListPublicCertificates
        /// <summary> Description for Get public certificates for an app or a deployment slot. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SitePublicCertificate" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SitePublicCertificate> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SitePublicCertificate>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SitePublicCertificateCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _webAppsRestClient.ListPublicCertificatesAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SitePublicCertificate(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SitePublicCertificate>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SitePublicCertificateCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _webAppsRestClient.ListPublicCertificatesNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SitePublicCertificate(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<SitePublicCertificate> IEnumerable<SitePublicCertificate>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SitePublicCertificate> IAsyncEnumerable<SitePublicCertificate>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, SitePublicCertificate, PublicCertificateData> Construct() { }
    }
}
