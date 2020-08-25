// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.AI.AnomalyDetector.Models;
using Azure.Core.Pipeline;

namespace Azure.AI.AnomalyDetector
{
    /// <summary> The AnomalyDetector service client. </summary>
    public partial class AnomalyDetectorClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal AnomalyDetectorRestClient RestClient { get; }
        /// <summary> Initializes a new instance of AnomalyDetectorClient for mocking. </summary>
        protected AnomalyDetectorClient()
        {
        }
        /// <summary> Initializes a new instance of AnomalyDetectorClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> Supported Cognitive Services endpoints (protocol and hostname, for example: https://westus2.api.cognitive.microsoft.com). </param>
        internal AnomalyDetectorClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string endpoint)
        {
            RestClient = new AnomalyDetectorRestClient(clientDiagnostics, pipeline, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> This operation generates a model using an entire series, each point is detected with the same model. With this method, points before and after a certain point are used to determine whether it is an anomaly. The entire detection can give user an overall status of the time series. </summary>
        /// <param name="body"> Time series points and period if needed. Advanced model parameters can also be set in the request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<EntireDetectResponse>> EntireDetectAsync(Request body, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AnomalyDetectorClient.EntireDetect");
            scope.Start();
            try
            {
                return await RestClient.EntireDetectAsync(body, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> This operation generates a model using an entire series, each point is detected with the same model. With this method, points before and after a certain point are used to determine whether it is an anomaly. The entire detection can give user an overall status of the time series. </summary>
        /// <param name="body"> Time series points and period if needed. Advanced model parameters can also be set in the request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<EntireDetectResponse> EntireDetect(Request body, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AnomalyDetectorClient.EntireDetect");
            scope.Start();
            try
            {
                return RestClient.EntireDetect(body, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> This operation generates a model using points before the latest one. With this method, only historical points are used to determine whether the target point is an anomaly. The latest point detecting operation matches the scenario of real-time monitoring of business metrics. </summary>
        /// <param name="body"> Time series points and period if needed. Advanced model parameters can also be set in the request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<LastDetectResponse>> LastDetectAsync(Request body, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AnomalyDetectorClient.LastDetect");
            scope.Start();
            try
            {
                return await RestClient.LastDetectAsync(body, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> This operation generates a model using points before the latest one. With this method, only historical points are used to determine whether the target point is an anomaly. The latest point detecting operation matches the scenario of real-time monitoring of business metrics. </summary>
        /// <param name="body"> Time series points and period if needed. Advanced model parameters can also be set in the request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<LastDetectResponse> LastDetect(Request body, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AnomalyDetectorClient.LastDetect");
            scope.Start();
            try
            {
                return RestClient.LastDetect(body, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Evaluate change point score of every series point. </summary>
        /// <param name="body"> Time series points and granularity is needed. Advanced model parameters can also be set in the request if needed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ChangePointDetectResponse>> ChangePointDetectAsync(ChangePointDetectRequest body, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AnomalyDetectorClient.ChangePointDetect");
            scope.Start();
            try
            {
                return await RestClient.ChangePointDetectAsync(body, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Evaluate change point score of every series point. </summary>
        /// <param name="body"> Time series points and granularity is needed. Advanced model parameters can also be set in the request if needed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ChangePointDetectResponse> ChangePointDetect(ChangePointDetectRequest body, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AnomalyDetectorClient.ChangePointDetect");
            scope.Start();
            try
            {
                return RestClient.ChangePointDetect(body, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}