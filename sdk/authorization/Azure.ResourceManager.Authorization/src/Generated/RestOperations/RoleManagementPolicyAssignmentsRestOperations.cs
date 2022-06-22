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
using Azure.ResourceManager.Authorization.Models;

namespace Azure.ResourceManager.Authorization
{
    internal partial class RoleManagementPolicyAssignmentsRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of RoleManagementPolicyAssignmentsRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public RoleManagementPolicyAssignmentsRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2020-10-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateGetRequest(string scope, string roleManagementPolicyAssignmentName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(scope, false);
            uri.AppendPath("/providers/Microsoft.Authorization/roleManagementPolicyAssignments/", false);
            uri.AppendPath(roleManagementPolicyAssignmentName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get the specified role management policy assignment for a resource scope. </summary>
        /// <param name="scope"> The scope of the role management policy. </param>
        /// <param name="roleManagementPolicyAssignmentName"> The name of format {guid_guid} the role management policy assignment to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scope"/> or <paramref name="roleManagementPolicyAssignmentName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="roleManagementPolicyAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<RoleManagementPolicyAssignmentData>> GetAsync(string scope, string roleManagementPolicyAssignmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(scope, nameof(scope));
            Argument.AssertNotNullOrEmpty(roleManagementPolicyAssignmentName, nameof(roleManagementPolicyAssignmentName));

            using var message = CreateGetRequest(scope, roleManagementPolicyAssignmentName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RoleManagementPolicyAssignmentData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = RoleManagementPolicyAssignmentData.DeserializeRoleManagementPolicyAssignmentData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((RoleManagementPolicyAssignmentData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get the specified role management policy assignment for a resource scope. </summary>
        /// <param name="scope"> The scope of the role management policy. </param>
        /// <param name="roleManagementPolicyAssignmentName"> The name of format {guid_guid} the role management policy assignment to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scope"/> or <paramref name="roleManagementPolicyAssignmentName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="roleManagementPolicyAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<RoleManagementPolicyAssignmentData> Get(string scope, string roleManagementPolicyAssignmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(scope, nameof(scope));
            Argument.AssertNotNullOrEmpty(roleManagementPolicyAssignmentName, nameof(roleManagementPolicyAssignmentName));

            using var message = CreateGetRequest(scope, roleManagementPolicyAssignmentName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RoleManagementPolicyAssignmentData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = RoleManagementPolicyAssignmentData.DeserializeRoleManagementPolicyAssignmentData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((RoleManagementPolicyAssignmentData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateRequest(string scope, string roleManagementPolicyAssignmentName, RoleManagementPolicyAssignmentData data)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(scope, false);
            uri.AppendPath("/providers/Microsoft.Authorization/roleManagementPolicyAssignments/", false);
            uri.AppendPath(roleManagementPolicyAssignmentName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(data);
            request.Content = content;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Create a role management policy assignment. </summary>
        /// <param name="scope"> The scope of the role management policy assignment to upsert. </param>
        /// <param name="roleManagementPolicyAssignmentName"> The name of format {guid_guid} the role management policy assignment to upsert. </param>
        /// <param name="data"> Parameters for the role management policy assignment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scope"/>, <paramref name="roleManagementPolicyAssignmentName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="roleManagementPolicyAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<RoleManagementPolicyAssignmentData>> CreateAsync(string scope, string roleManagementPolicyAssignmentName, RoleManagementPolicyAssignmentData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(scope, nameof(scope));
            Argument.AssertNotNullOrEmpty(roleManagementPolicyAssignmentName, nameof(roleManagementPolicyAssignmentName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateRequest(scope, roleManagementPolicyAssignmentName, data);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 201:
                    {
                        RoleManagementPolicyAssignmentData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = RoleManagementPolicyAssignmentData.DeserializeRoleManagementPolicyAssignmentData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Create a role management policy assignment. </summary>
        /// <param name="scope"> The scope of the role management policy assignment to upsert. </param>
        /// <param name="roleManagementPolicyAssignmentName"> The name of format {guid_guid} the role management policy assignment to upsert. </param>
        /// <param name="data"> Parameters for the role management policy assignment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scope"/>, <paramref name="roleManagementPolicyAssignmentName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="roleManagementPolicyAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<RoleManagementPolicyAssignmentData> Create(string scope, string roleManagementPolicyAssignmentName, RoleManagementPolicyAssignmentData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(scope, nameof(scope));
            Argument.AssertNotNullOrEmpty(roleManagementPolicyAssignmentName, nameof(roleManagementPolicyAssignmentName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateRequest(scope, roleManagementPolicyAssignmentName, data);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 201:
                    {
                        RoleManagementPolicyAssignmentData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = RoleManagementPolicyAssignmentData.DeserializeRoleManagementPolicyAssignmentData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteRequest(string scope, string roleManagementPolicyAssignmentName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(scope, false);
            uri.AppendPath("/providers/Microsoft.Authorization/roleManagementPolicyAssignments/", false);
            uri.AppendPath(roleManagementPolicyAssignmentName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Delete a role management policy assignment. </summary>
        /// <param name="scope"> The scope of the role management policy assignment to delete. </param>
        /// <param name="roleManagementPolicyAssignmentName"> The name of format {guid_guid} the role management policy assignment to delete. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scope"/> or <paramref name="roleManagementPolicyAssignmentName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="roleManagementPolicyAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> DeleteAsync(string scope, string roleManagementPolicyAssignmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(scope, nameof(scope));
            Argument.AssertNotNullOrEmpty(roleManagementPolicyAssignmentName, nameof(roleManagementPolicyAssignmentName));

            using var message = CreateDeleteRequest(scope, roleManagementPolicyAssignmentName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Delete a role management policy assignment. </summary>
        /// <param name="scope"> The scope of the role management policy assignment to delete. </param>
        /// <param name="roleManagementPolicyAssignmentName"> The name of format {guid_guid} the role management policy assignment to delete. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scope"/> or <paramref name="roleManagementPolicyAssignmentName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="roleManagementPolicyAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Delete(string scope, string roleManagementPolicyAssignmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(scope, nameof(scope));
            Argument.AssertNotNullOrEmpty(roleManagementPolicyAssignmentName, nameof(roleManagementPolicyAssignmentName));

            using var message = CreateDeleteRequest(scope, roleManagementPolicyAssignmentName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListForScopeRequest(string scope)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(scope, false);
            uri.AppendPath("/providers/Microsoft.Authorization/roleManagementPolicyAssignments", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets role management assignment policies for a resource scope. </summary>
        /// <param name="scope"> The scope of the role management policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scope"/> is null. </exception>
        public async Task<Response<RoleManagementPolicyAssignmentListResult>> ListForScopeAsync(string scope, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(scope, nameof(scope));

            using var message = CreateListForScopeRequest(scope);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RoleManagementPolicyAssignmentListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = RoleManagementPolicyAssignmentListResult.DeserializeRoleManagementPolicyAssignmentListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets role management assignment policies for a resource scope. </summary>
        /// <param name="scope"> The scope of the role management policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scope"/> is null. </exception>
        public Response<RoleManagementPolicyAssignmentListResult> ListForScope(string scope, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(scope, nameof(scope));

            using var message = CreateListForScopeRequest(scope);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RoleManagementPolicyAssignmentListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = RoleManagementPolicyAssignmentListResult.DeserializeRoleManagementPolicyAssignmentListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListForScopeNextPageRequest(string nextLink, string scope)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets role management assignment policies for a resource scope. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="scope"> The scope of the role management policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> or <paramref name="scope"/> is null. </exception>
        public async Task<Response<RoleManagementPolicyAssignmentListResult>> ListForScopeNextPageAsync(string nextLink, string scope, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNull(scope, nameof(scope));

            using var message = CreateListForScopeNextPageRequest(nextLink, scope);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RoleManagementPolicyAssignmentListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = RoleManagementPolicyAssignmentListResult.DeserializeRoleManagementPolicyAssignmentListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets role management assignment policies for a resource scope. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="scope"> The scope of the role management policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> or <paramref name="scope"/> is null. </exception>
        public Response<RoleManagementPolicyAssignmentListResult> ListForScopeNextPage(string nextLink, string scope, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNull(scope, nameof(scope));

            using var message = CreateListForScopeNextPageRequest(nextLink, scope);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RoleManagementPolicyAssignmentListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = RoleManagementPolicyAssignmentListResult.DeserializeRoleManagementPolicyAssignmentListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
