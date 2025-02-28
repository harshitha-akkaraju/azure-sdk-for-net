// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Verticals.AgriFood.Farming
{
    /// <summary> The Seasons service client. </summary>
    public partial class SeasonsClient
    {
        private static readonly string[] AuthorizationScopes = new string[] { "https://farmbeats.azure.net/.default" };
        private readonly TokenCredential _tokenCredential;
        private readonly HttpPipeline _pipeline;
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of SeasonsClient for mocking. </summary>
        protected SeasonsClient()
        {
        }

        /// <summary> Initializes a new instance of SeasonsClient. </summary>
        /// <param name="endpoint"> The endpoint of your FarmBeats resource (protocol and hostname, for example: https://{resourceName}.farmbeats.azure.net). </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="options"> The options for configuring the client. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> or <paramref name="credential"/> is null. </exception>
        public SeasonsClient(Uri endpoint, TokenCredential credential, FarmBeatsClientOptions options = null)
        {
            Argument.AssertNotNull(endpoint, nameof(endpoint));
            Argument.AssertNotNull(credential, nameof(credential));
            options ??= new FarmBeatsClientOptions();

            _clientDiagnostics = new ClientDiagnostics(options);
            _tokenCredential = credential;
            _pipeline = HttpPipelineBuilder.Build(options, Array.Empty<HttpPipelinePolicy>(), new HttpPipelinePolicy[] { new BearerTokenAuthenticationPolicy(_tokenCredential, AuthorizationScopes) }, new ResponseClassifier());
            _endpoint = endpoint;
            _apiVersion = options.Version;
        }

        /// <summary> Gets a specified season resource. </summary>
        /// <param name="seasonId"> ID of the season. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="seasonId"/> is null. </exception>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   startDateTime: string (ISO 8601 Format),
        ///   endDateTime: string (ISO 8601 Format),
        ///   year: number,
        ///   id: string,
        ///   eTag: string,
        ///   status: string,
        ///   createdDateTime: string (ISO 8601 Format),
        ///   modifiedDateTime: string (ISO 8601 Format),
        ///   name: string,
        ///   description: string,
        ///   properties: Dictionary&lt;string, AnyObject&gt;
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     target: string,
        ///     details: [Error],
        ///     innererror: {
        ///       code: string,
        ///       innererror: InnerError
        ///     }
        ///   },
        ///   traceId: string
        /// }
        /// </code>
        /// 
        /// </remarks>
#pragma warning disable AZC0002
        public virtual async Task<Response> GetSeasonAsync(string seasonId, RequestContext context = null)
#pragma warning restore AZC0002
        {
            Argument.AssertNotNull(seasonId, nameof(seasonId));

            using var scope = _clientDiagnostics.CreateScope("SeasonsClient.GetSeason");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetSeasonRequest(seasonId, context);
                return await _pipeline.ProcessMessageAsync(message, _clientDiagnostics, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a specified season resource. </summary>
        /// <param name="seasonId"> ID of the season. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="seasonId"/> is null. </exception>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   startDateTime: string (ISO 8601 Format),
        ///   endDateTime: string (ISO 8601 Format),
        ///   year: number,
        ///   id: string,
        ///   eTag: string,
        ///   status: string,
        ///   createdDateTime: string (ISO 8601 Format),
        ///   modifiedDateTime: string (ISO 8601 Format),
        ///   name: string,
        ///   description: string,
        ///   properties: Dictionary&lt;string, AnyObject&gt;
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     target: string,
        ///     details: [Error],
        ///     innererror: {
        ///       code: string,
        ///       innererror: InnerError
        ///     }
        ///   },
        ///   traceId: string
        /// }
        /// </code>
        /// 
        /// </remarks>
#pragma warning disable AZC0002
        public virtual Response GetSeason(string seasonId, RequestContext context = null)
#pragma warning restore AZC0002
        {
            Argument.AssertNotNull(seasonId, nameof(seasonId));

            using var scope = _clientDiagnostics.CreateScope("SeasonsClient.GetSeason");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetSeasonRequest(seasonId, context);
                return _pipeline.ProcessMessage(message, _clientDiagnostics, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a season resource. </summary>
        /// <param name="seasonId"> ID of the season resource. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="seasonId"/> is null. </exception>
        /// <remarks>
        /// Schema for <c>Request Body</c>:
        /// <code>{
        ///   startDateTime: string (ISO 8601 Format),
        ///   endDateTime: string (ISO 8601 Format),
        ///   year: number,
        ///   id: string,
        ///   eTag: string,
        ///   status: string,
        ///   createdDateTime: string (ISO 8601 Format),
        ///   modifiedDateTime: string (ISO 8601 Format),
        ///   name: string,
        ///   description: string,
        ///   properties: Dictionary&lt;string, AnyObject&gt;
        /// }
        /// </code>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   startDateTime: string (ISO 8601 Format),
        ///   endDateTime: string (ISO 8601 Format),
        ///   year: number,
        ///   id: string,
        ///   eTag: string,
        ///   status: string,
        ///   createdDateTime: string (ISO 8601 Format),
        ///   modifiedDateTime: string (ISO 8601 Format),
        ///   name: string,
        ///   description: string,
        ///   properties: Dictionary&lt;string, AnyObject&gt;
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     target: string,
        ///     details: [Error],
        ///     innererror: {
        ///       code: string,
        ///       innererror: InnerError
        ///     }
        ///   },
        ///   traceId: string
        /// }
        /// </code>
        /// 
        /// </remarks>
#pragma warning disable AZC0002
        public virtual async Task<Response> CreateOrUpdateAsync(string seasonId, RequestContent content, RequestContext context = null)
#pragma warning restore AZC0002
        {
            Argument.AssertNotNull(seasonId, nameof(seasonId));

            using var scope = _clientDiagnostics.CreateScope("SeasonsClient.CreateOrUpdate");
            scope.Start();
            try
            {
                using HttpMessage message = CreateCreateOrUpdateRequest(seasonId, content, context);
                return await _pipeline.ProcessMessageAsync(message, _clientDiagnostics, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a season resource. </summary>
        /// <param name="seasonId"> ID of the season resource. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="seasonId"/> is null. </exception>
        /// <remarks>
        /// Schema for <c>Request Body</c>:
        /// <code>{
        ///   startDateTime: string (ISO 8601 Format),
        ///   endDateTime: string (ISO 8601 Format),
        ///   year: number,
        ///   id: string,
        ///   eTag: string,
        ///   status: string,
        ///   createdDateTime: string (ISO 8601 Format),
        ///   modifiedDateTime: string (ISO 8601 Format),
        ///   name: string,
        ///   description: string,
        ///   properties: Dictionary&lt;string, AnyObject&gt;
        /// }
        /// </code>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   startDateTime: string (ISO 8601 Format),
        ///   endDateTime: string (ISO 8601 Format),
        ///   year: number,
        ///   id: string,
        ///   eTag: string,
        ///   status: string,
        ///   createdDateTime: string (ISO 8601 Format),
        ///   modifiedDateTime: string (ISO 8601 Format),
        ///   name: string,
        ///   description: string,
        ///   properties: Dictionary&lt;string, AnyObject&gt;
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     target: string,
        ///     details: [Error],
        ///     innererror: {
        ///       code: string,
        ///       innererror: InnerError
        ///     }
        ///   },
        ///   traceId: string
        /// }
        /// </code>
        /// 
        /// </remarks>
#pragma warning disable AZC0002
        public virtual Response CreateOrUpdate(string seasonId, RequestContent content, RequestContext context = null)
#pragma warning restore AZC0002
        {
            Argument.AssertNotNull(seasonId, nameof(seasonId));

            using var scope = _clientDiagnostics.CreateScope("SeasonsClient.CreateOrUpdate");
            scope.Start();
            try
            {
                using HttpMessage message = CreateCreateOrUpdateRequest(seasonId, content, context);
                return _pipeline.ProcessMessage(message, _clientDiagnostics, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes a specified season resource. </summary>
        /// <param name="seasonId"> ID of the season. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="seasonId"/> is null. </exception>
        /// <remarks>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     target: string,
        ///     details: [Error],
        ///     innererror: {
        ///       code: string,
        ///       innererror: InnerError
        ///     }
        ///   },
        ///   traceId: string
        /// }
        /// </code>
        /// 
        /// </remarks>
#pragma warning disable AZC0002
        public virtual async Task<Response> DeleteAsync(string seasonId, RequestContext context = null)
#pragma warning restore AZC0002
        {
            Argument.AssertNotNull(seasonId, nameof(seasonId));

            using var scope = _clientDiagnostics.CreateScope("SeasonsClient.Delete");
            scope.Start();
            try
            {
                using HttpMessage message = CreateDeleteRequest(seasonId, context);
                return await _pipeline.ProcessMessageAsync(message, _clientDiagnostics, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes a specified season resource. </summary>
        /// <param name="seasonId"> ID of the season. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="seasonId"/> is null. </exception>
        /// <remarks>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     target: string,
        ///     details: [Error],
        ///     innererror: {
        ///       code: string,
        ///       innererror: InnerError
        ///     }
        ///   },
        ///   traceId: string
        /// }
        /// </code>
        /// 
        /// </remarks>
#pragma warning disable AZC0002
        public virtual Response Delete(string seasonId, RequestContext context = null)
#pragma warning restore AZC0002
        {
            Argument.AssertNotNull(seasonId, nameof(seasonId));

            using var scope = _clientDiagnostics.CreateScope("SeasonsClient.Delete");
            scope.Start();
            try
            {
                using HttpMessage message = CreateDeleteRequest(seasonId, context);
                return _pipeline.ProcessMessage(message, _clientDiagnostics, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Returns a paginated list of season resources. </summary>
        /// <param name="minStartDateTime"> Minimum season start datetime, sample format: yyyy-MM-ddTHH:mm:ssZ. </param>
        /// <param name="maxStartDateTime"> Maximum season start datetime, sample format: yyyy-MM-ddTHH:mm:ssZ. </param>
        /// <param name="minEndDateTime"> Minimum season end datetime, sample format: yyyy-MM-ddTHH:mm:ssZ. </param>
        /// <param name="maxEndDateTime"> Maximum season end datetime, sample format: yyyy-MM-ddTHH:mm:ssZ. </param>
        /// <param name="years"> Years of the resource. </param>
        /// <param name="ids"> Ids of the resource. </param>
        /// <param name="names"> Names of the resource. </param>
        /// <param name="propertyFilters">
        /// Filters on key-value pairs within the Properties object.
        /// eg. &quot;{testKey} eq {testValue}&quot;.
        /// </param>
        /// <param name="statuses"> Statuses of the resource. </param>
        /// <param name="minCreatedDateTime"> Minimum creation date of resource (inclusive). </param>
        /// <param name="maxCreatedDateTime"> Maximum creation date of resource (inclusive). </param>
        /// <param name="minLastModifiedDateTime"> Minimum last modified date of resource (inclusive). </param>
        /// <param name="maxLastModifiedDateTime"> Maximum last modified date of resource (inclusive). </param>
        /// <param name="maxPageSize">
        /// Maximum number of items needed (inclusive).
        /// Minimum = 10, Maximum = 1000, Default value = 50.
        /// </param>
        /// <param name="skipToken"> Skip token for getting next set of results. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   value: [
        ///     {
        ///       startDateTime: string (ISO 8601 Format),
        ///       endDateTime: string (ISO 8601 Format),
        ///       year: number,
        ///       id: string,
        ///       eTag: string,
        ///       status: string,
        ///       createdDateTime: string (ISO 8601 Format),
        ///       modifiedDateTime: string (ISO 8601 Format),
        ///       name: string,
        ///       description: string,
        ///       properties: Dictionary&lt;string, AnyObject&gt;
        ///     }
        ///   ],
        ///   $skipToken: string,
        ///   nextLink: string
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     target: string,
        ///     details: [Error],
        ///     innererror: {
        ///       code: string,
        ///       innererror: InnerError
        ///     }
        ///   },
        ///   traceId: string
        /// }
        /// </code>
        /// 
        /// </remarks>
#pragma warning disable AZC0002
        public virtual AsyncPageable<BinaryData> GetSeasonsAsync(DateTimeOffset? minStartDateTime = null, DateTimeOffset? maxStartDateTime = null, DateTimeOffset? minEndDateTime = null, DateTimeOffset? maxEndDateTime = null, IEnumerable<int> years = null, IEnumerable<string> ids = null, IEnumerable<string> names = null, IEnumerable<string> propertyFilters = null, IEnumerable<string> statuses = null, DateTimeOffset? minCreatedDateTime = null, DateTimeOffset? maxCreatedDateTime = null, DateTimeOffset? minLastModifiedDateTime = null, DateTimeOffset? maxLastModifiedDateTime = null, int? maxPageSize = null, string skipToken = null, RequestContext context = null)
#pragma warning restore AZC0002
        {
            return PageableHelpers.CreateAsyncPageable(CreateEnumerableAsync, _clientDiagnostics, "SeasonsClient.GetSeasons");
            async IAsyncEnumerable<Page<BinaryData>> CreateEnumerableAsync(string nextLink, int? pageSizeHint, [EnumeratorCancellation] CancellationToken cancellationToken = default)
            {
                do
                {
                    var message = string.IsNullOrEmpty(nextLink)
                        ? CreateGetSeasonsRequest(minStartDateTime, maxStartDateTime, minEndDateTime, maxEndDateTime, years, ids, names, propertyFilters, statuses, minCreatedDateTime, maxCreatedDateTime, minLastModifiedDateTime, maxLastModifiedDateTime, maxPageSize, skipToken, context)
                        : CreateGetSeasonsNextPageRequest(nextLink, minStartDateTime, maxStartDateTime, minEndDateTime, maxEndDateTime, years, ids, names, propertyFilters, statuses, minCreatedDateTime, maxCreatedDateTime, minLastModifiedDateTime, maxLastModifiedDateTime, maxPageSize, skipToken, context);
                    var page = await LowLevelPageableHelpers.ProcessMessageAsync(_pipeline, message, _clientDiagnostics, context, "value", "nextLink", cancellationToken).ConfigureAwait(false);
                    nextLink = page.ContinuationToken;
                    yield return page;
                } while (!string.IsNullOrEmpty(nextLink));
            }
        }

        /// <summary> Returns a paginated list of season resources. </summary>
        /// <param name="minStartDateTime"> Minimum season start datetime, sample format: yyyy-MM-ddTHH:mm:ssZ. </param>
        /// <param name="maxStartDateTime"> Maximum season start datetime, sample format: yyyy-MM-ddTHH:mm:ssZ. </param>
        /// <param name="minEndDateTime"> Minimum season end datetime, sample format: yyyy-MM-ddTHH:mm:ssZ. </param>
        /// <param name="maxEndDateTime"> Maximum season end datetime, sample format: yyyy-MM-ddTHH:mm:ssZ. </param>
        /// <param name="years"> Years of the resource. </param>
        /// <param name="ids"> Ids of the resource. </param>
        /// <param name="names"> Names of the resource. </param>
        /// <param name="propertyFilters">
        /// Filters on key-value pairs within the Properties object.
        /// eg. &quot;{testKey} eq {testValue}&quot;.
        /// </param>
        /// <param name="statuses"> Statuses of the resource. </param>
        /// <param name="minCreatedDateTime"> Minimum creation date of resource (inclusive). </param>
        /// <param name="maxCreatedDateTime"> Maximum creation date of resource (inclusive). </param>
        /// <param name="minLastModifiedDateTime"> Minimum last modified date of resource (inclusive). </param>
        /// <param name="maxLastModifiedDateTime"> Maximum last modified date of resource (inclusive). </param>
        /// <param name="maxPageSize">
        /// Maximum number of items needed (inclusive).
        /// Minimum = 10, Maximum = 1000, Default value = 50.
        /// </param>
        /// <param name="skipToken"> Skip token for getting next set of results. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   value: [
        ///     {
        ///       startDateTime: string (ISO 8601 Format),
        ///       endDateTime: string (ISO 8601 Format),
        ///       year: number,
        ///       id: string,
        ///       eTag: string,
        ///       status: string,
        ///       createdDateTime: string (ISO 8601 Format),
        ///       modifiedDateTime: string (ISO 8601 Format),
        ///       name: string,
        ///       description: string,
        ///       properties: Dictionary&lt;string, AnyObject&gt;
        ///     }
        ///   ],
        ///   $skipToken: string,
        ///   nextLink: string
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     target: string,
        ///     details: [Error],
        ///     innererror: {
        ///       code: string,
        ///       innererror: InnerError
        ///     }
        ///   },
        ///   traceId: string
        /// }
        /// </code>
        /// 
        /// </remarks>
#pragma warning disable AZC0002
        public virtual Pageable<BinaryData> GetSeasons(DateTimeOffset? minStartDateTime = null, DateTimeOffset? maxStartDateTime = null, DateTimeOffset? minEndDateTime = null, DateTimeOffset? maxEndDateTime = null, IEnumerable<int> years = null, IEnumerable<string> ids = null, IEnumerable<string> names = null, IEnumerable<string> propertyFilters = null, IEnumerable<string> statuses = null, DateTimeOffset? minCreatedDateTime = null, DateTimeOffset? maxCreatedDateTime = null, DateTimeOffset? minLastModifiedDateTime = null, DateTimeOffset? maxLastModifiedDateTime = null, int? maxPageSize = null, string skipToken = null, RequestContext context = null)
#pragma warning restore AZC0002
        {
            return PageableHelpers.CreatePageable(CreateEnumerable, _clientDiagnostics, "SeasonsClient.GetSeasons");
            IEnumerable<Page<BinaryData>> CreateEnumerable(string nextLink, int? pageSizeHint)
            {
                do
                {
                    var message = string.IsNullOrEmpty(nextLink)
                        ? CreateGetSeasonsRequest(minStartDateTime, maxStartDateTime, minEndDateTime, maxEndDateTime, years, ids, names, propertyFilters, statuses, minCreatedDateTime, maxCreatedDateTime, minLastModifiedDateTime, maxLastModifiedDateTime, maxPageSize, skipToken, context)
                        : CreateGetSeasonsNextPageRequest(nextLink, minStartDateTime, maxStartDateTime, minEndDateTime, maxEndDateTime, years, ids, names, propertyFilters, statuses, minCreatedDateTime, maxCreatedDateTime, minLastModifiedDateTime, maxLastModifiedDateTime, maxPageSize, skipToken, context);
                    var page = LowLevelPageableHelpers.ProcessMessage(_pipeline, message, _clientDiagnostics, context, "value", "nextLink");
                    nextLink = page.ContinuationToken;
                    yield return page;
                } while (!string.IsNullOrEmpty(nextLink));
            }
        }

        internal HttpMessage CreateGetSeasonsRequest(DateTimeOffset? minStartDateTime, DateTimeOffset? maxStartDateTime, DateTimeOffset? minEndDateTime, DateTimeOffset? maxEndDateTime, IEnumerable<int> years, IEnumerable<string> ids, IEnumerable<string> names, IEnumerable<string> propertyFilters, IEnumerable<string> statuses, DateTimeOffset? minCreatedDateTime, DateTimeOffset? maxCreatedDateTime, DateTimeOffset? minLastModifiedDateTime, DateTimeOffset? maxLastModifiedDateTime, int? maxPageSize, string skipToken, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/seasons", false);
            if (minStartDateTime != null)
            {
                uri.AppendQuery("minStartDateTime", minStartDateTime.Value, "O", true);
            }
            if (maxStartDateTime != null)
            {
                uri.AppendQuery("maxStartDateTime", maxStartDateTime.Value, "O", true);
            }
            if (minEndDateTime != null)
            {
                uri.AppendQuery("minEndDateTime", minEndDateTime.Value, "O", true);
            }
            if (maxEndDateTime != null)
            {
                uri.AppendQuery("maxEndDateTime", maxEndDateTime.Value, "O", true);
            }
            if (years != null)
            {
                foreach (var param in years)
                {
                    uri.AppendQuery("years", param, true);
                }
            }
            if (ids != null)
            {
                foreach (var param in ids)
                {
                    uri.AppendQuery("ids", param, true);
                }
            }
            if (names != null)
            {
                foreach (var param in names)
                {
                    uri.AppendQuery("names", param, true);
                }
            }
            if (propertyFilters != null)
            {
                foreach (var param in propertyFilters)
                {
                    uri.AppendQuery("propertyFilters", param, true);
                }
            }
            if (statuses != null)
            {
                foreach (var param in statuses)
                {
                    uri.AppendQuery("statuses", param, true);
                }
            }
            if (minCreatedDateTime != null)
            {
                uri.AppendQuery("minCreatedDateTime", minCreatedDateTime.Value, "O", true);
            }
            if (maxCreatedDateTime != null)
            {
                uri.AppendQuery("maxCreatedDateTime", maxCreatedDateTime.Value, "O", true);
            }
            if (minLastModifiedDateTime != null)
            {
                uri.AppendQuery("minLastModifiedDateTime", minLastModifiedDateTime.Value, "O", true);
            }
            if (maxLastModifiedDateTime != null)
            {
                uri.AppendQuery("maxLastModifiedDateTime", maxLastModifiedDateTime.Value, "O", true);
            }
            if (maxPageSize != null)
            {
                uri.AppendQuery("$maxPageSize", maxPageSize.Value, true);
            }
            if (skipToken != null)
            {
                uri.AppendQuery("$skipToken", skipToken, true);
            }
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.ResponseClassifier = ResponseClassifier200.Instance;
            return message;
        }

        internal HttpMessage CreateGetSeasonRequest(string seasonId, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/seasons/", false);
            uri.AppendPath(seasonId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.ResponseClassifier = ResponseClassifier200.Instance;
            return message;
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string seasonId, RequestContent content, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context);
            var request = message.Request;
            request.Method = RequestMethod.Patch;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/seasons/", false);
            uri.AppendPath(seasonId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/merge-patch+json");
            request.Content = content;
            message.ResponseClassifier = ResponseClassifier200201.Instance;
            return message;
        }

        internal HttpMessage CreateDeleteRequest(string seasonId, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context);
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/seasons/", false);
            uri.AppendPath(seasonId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.ResponseClassifier = ResponseClassifier204.Instance;
            return message;
        }

        internal HttpMessage CreateGetSeasonsNextPageRequest(string nextLink, DateTimeOffset? minStartDateTime, DateTimeOffset? maxStartDateTime, DateTimeOffset? minEndDateTime, DateTimeOffset? maxEndDateTime, IEnumerable<int> years, IEnumerable<string> ids, IEnumerable<string> names, IEnumerable<string> propertyFilters, IEnumerable<string> statuses, DateTimeOffset? minCreatedDateTime, DateTimeOffset? maxCreatedDateTime, DateTimeOffset? minLastModifiedDateTime, DateTimeOffset? maxLastModifiedDateTime, int? maxPageSize, string skipToken, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.ResponseClassifier = ResponseClassifier200.Instance;
            return message;
        }

        private sealed class ResponseClassifier200 : ResponseClassifier
        {
            private static ResponseClassifier _instance;
            public static ResponseClassifier Instance => _instance ??= new ResponseClassifier200();
            public override bool IsErrorResponse(HttpMessage message)
            {
                return message.Response.Status switch
                {
                    200 => false,
                    _ => true
                };
            }
        }
        private sealed class ResponseClassifier200201 : ResponseClassifier
        {
            private static ResponseClassifier _instance;
            public static ResponseClassifier Instance => _instance ??= new ResponseClassifier200201();
            public override bool IsErrorResponse(HttpMessage message)
            {
                return message.Response.Status switch
                {
                    200 => false,
                    201 => false,
                    _ => true
                };
            }
        }
        private sealed class ResponseClassifier204 : ResponseClassifier
        {
            private static ResponseClassifier _instance;
            public static ResponseClassifier Instance => _instance ??= new ResponseClassifier204();
            public override bool IsErrorResponse(HttpMessage message)
            {
                return message.Response.Status switch
                {
                    204 => false,
                    _ => true
                };
            }
        }
    }
}
