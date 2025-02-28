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
using Azure.ResourceManager.Cdn.Models;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Cdn
{
    /// <summary> A class representing collection of AfdCustomDomain and their operations over its parent. </summary>
    public partial class AfdCustomDomainCollection : ArmCollection, IEnumerable<AfdCustomDomain>, IAsyncEnumerable<AfdCustomDomain>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly AfdCustomDomainsRestOperations _afdCustomDomainsRestClient;

        /// <summary> Initializes a new instance of the <see cref="AfdCustomDomainCollection"/> class for mocking. </summary>
        protected AfdCustomDomainCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AfdCustomDomainCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal AfdCustomDomainCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            ClientOptions.TryGetApiVersion(AfdCustomDomain.ResourceType, out string apiVersion);
            _afdCustomDomainsRestClient = new AfdCustomDomainsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != Profile.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, Profile.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// <summary> Creates a new domain within the specified profile. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="customDomainName"> Name of the domain under the profile which is unique globally. </param>
        /// <param name="customDomain"> Domain properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="customDomainName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="customDomainName"/> or <paramref name="customDomain"/> is null. </exception>
        public virtual AfdCustomDomainCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string customDomainName, AfdCustomDomainData customDomain, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(customDomainName, nameof(customDomainName));
            if (customDomain == null)
            {
                throw new ArgumentNullException(nameof(customDomain));
            }

            using var scope = _clientDiagnostics.CreateScope("AfdCustomDomainCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _afdCustomDomainsRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, customDomainName, customDomain, cancellationToken);
                var operation = new AfdCustomDomainCreateOrUpdateOperation(this, _clientDiagnostics, Pipeline, _afdCustomDomainsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, customDomainName, customDomain).Request, response);
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

        /// <summary> Creates a new domain within the specified profile. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="customDomainName"> Name of the domain under the profile which is unique globally. </param>
        /// <param name="customDomain"> Domain properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="customDomainName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="customDomainName"/> or <paramref name="customDomain"/> is null. </exception>
        public async virtual Task<AfdCustomDomainCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string customDomainName, AfdCustomDomainData customDomain, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(customDomainName, nameof(customDomainName));
            if (customDomain == null)
            {
                throw new ArgumentNullException(nameof(customDomain));
            }

            using var scope = _clientDiagnostics.CreateScope("AfdCustomDomainCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _afdCustomDomainsRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, customDomainName, customDomain, cancellationToken).ConfigureAwait(false);
                var operation = new AfdCustomDomainCreateOrUpdateOperation(this, _clientDiagnostics, Pipeline, _afdCustomDomainsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, customDomainName, customDomain).Request, response);
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

        /// <summary> Gets an existing AzureFrontDoor domain with the specified domain name under the specified subscription, resource group and profile. </summary>
        /// <param name="customDomainName"> Name of the domain under the profile which is unique globally. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="customDomainName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="customDomainName"/> is null. </exception>
        public virtual Response<AfdCustomDomain> Get(string customDomainName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(customDomainName, nameof(customDomainName));

            using var scope = _clientDiagnostics.CreateScope("AfdCustomDomainCollection.Get");
            scope.Start();
            try
            {
                var response = _afdCustomDomainsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, customDomainName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AfdCustomDomain(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets an existing AzureFrontDoor domain with the specified domain name under the specified subscription, resource group and profile. </summary>
        /// <param name="customDomainName"> Name of the domain under the profile which is unique globally. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="customDomainName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="customDomainName"/> is null. </exception>
        public async virtual Task<Response<AfdCustomDomain>> GetAsync(string customDomainName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(customDomainName, nameof(customDomainName));

            using var scope = _clientDiagnostics.CreateScope("AfdCustomDomainCollection.Get");
            scope.Start();
            try
            {
                var response = await _afdCustomDomainsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, customDomainName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new AfdCustomDomain(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="customDomainName"> Name of the domain under the profile which is unique globally. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="customDomainName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="customDomainName"/> is null. </exception>
        public virtual Response<AfdCustomDomain> GetIfExists(string customDomainName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(customDomainName, nameof(customDomainName));

            using var scope = _clientDiagnostics.CreateScope("AfdCustomDomainCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _afdCustomDomainsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, customDomainName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<AfdCustomDomain>(null, response.GetRawResponse());
                return Response.FromValue(new AfdCustomDomain(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="customDomainName"> Name of the domain under the profile which is unique globally. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="customDomainName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="customDomainName"/> is null. </exception>
        public async virtual Task<Response<AfdCustomDomain>> GetIfExistsAsync(string customDomainName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(customDomainName, nameof(customDomainName));

            using var scope = _clientDiagnostics.CreateScope("AfdCustomDomainCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _afdCustomDomainsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, customDomainName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<AfdCustomDomain>(null, response.GetRawResponse());
                return Response.FromValue(new AfdCustomDomain(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="customDomainName"> Name of the domain under the profile which is unique globally. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="customDomainName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="customDomainName"/> is null. </exception>
        public virtual Response<bool> Exists(string customDomainName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(customDomainName, nameof(customDomainName));

            using var scope = _clientDiagnostics.CreateScope("AfdCustomDomainCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(customDomainName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="customDomainName"> Name of the domain under the profile which is unique globally. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="customDomainName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="customDomainName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string customDomainName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(customDomainName, nameof(customDomainName));

            using var scope = _clientDiagnostics.CreateScope("AfdCustomDomainCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(customDomainName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists existing AzureFrontDoor domains. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AfdCustomDomain" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AfdCustomDomain> GetAll(CancellationToken cancellationToken = default)
        {
            Page<AfdCustomDomain> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("AfdCustomDomainCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _afdCustomDomainsRestClient.ListByProfile(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new AfdCustomDomain(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<AfdCustomDomain> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("AfdCustomDomainCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _afdCustomDomainsRestClient.ListByProfileNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new AfdCustomDomain(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists existing AzureFrontDoor domains. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AfdCustomDomain" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AfdCustomDomain> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<AfdCustomDomain>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("AfdCustomDomainCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _afdCustomDomainsRestClient.ListByProfileAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new AfdCustomDomain(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<AfdCustomDomain>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("AfdCustomDomainCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _afdCustomDomainsRestClient.ListByProfileNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new AfdCustomDomain(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<AfdCustomDomain> IEnumerable<AfdCustomDomain>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<AfdCustomDomain> IAsyncEnumerable<AfdCustomDomain>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, AfdCustomDomain, AfdCustomDomainData> Construct() { }
    }
}
