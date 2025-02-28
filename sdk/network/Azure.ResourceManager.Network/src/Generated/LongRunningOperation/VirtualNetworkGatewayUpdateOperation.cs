// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Network;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Updates a virtual network gateway tags. </summary>
    public partial class VirtualNetworkGatewayUpdateOperation : Operation<VirtualNetworkGateway>, IOperationSource<VirtualNetworkGateway>
    {
        private readonly OperationInternals<VirtualNetworkGateway> _operation;

        private readonly ArmResource _operationBase;

        /// <summary> Initializes a new instance of VirtualNetworkGatewayUpdateOperation for mocking. </summary>
        protected VirtualNetworkGatewayUpdateOperation()
        {
        }

        internal VirtualNetworkGatewayUpdateOperation(ArmResource operationsBase, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<VirtualNetworkGateway>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.AzureAsyncOperation, "VirtualNetworkGatewayUpdateOperation");
            _operationBase = operationsBase;
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override VirtualNetworkGateway Value => _operation.Value;

        /// <inheritdoc />
        public override bool HasCompleted => _operation.HasCompleted;

        /// <inheritdoc />
        public override bool HasValue => _operation.HasValue;

        /// <inheritdoc />
        public override Response GetRawResponse() => _operation.GetRawResponse();

        /// <inheritdoc />
        public override Response UpdateStatus(CancellationToken cancellationToken = default) => _operation.UpdateStatus(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response> UpdateStatusAsync(CancellationToken cancellationToken = default) => _operation.UpdateStatusAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<VirtualNetworkGateway>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<VirtualNetworkGateway>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        VirtualNetworkGateway IOperationSource<VirtualNetworkGateway>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = VirtualNetworkGatewayData.DeserializeVirtualNetworkGatewayData(document.RootElement);
            return new VirtualNetworkGateway(_operationBase, data);
        }

        async ValueTask<VirtualNetworkGateway> IOperationSource<VirtualNetworkGateway>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = VirtualNetworkGatewayData.DeserializeVirtualNetworkGatewayData(document.RootElement);
            return new VirtualNetworkGateway(_operationBase, data);
        }
    }
}
