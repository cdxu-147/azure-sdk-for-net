// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.12.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Intune
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;

    public static partial class AndroidOperationsExtensions
    {
            /// <summary>
            /// Returns Intune Android policies.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='hostName'>
            /// Location hostName for the tenant
            /// </param>
            /// <param name='filter'>
            /// The filter to apply on the operation.
            /// </param>
            /// <param name='top'>
            /// </param>
            /// <param name='select'>
            /// select specific fields in entity.
            /// </param>
            public static IPage<AndroidMAMPolicy> GetMAMPolicies(this IAndroidOperations operations, string hostName, string filter = default(string), int? top = default(int?), string select = default(string))
            {
                return Task.Factory.StartNew(s => ((IAndroidOperations)s).GetMAMPoliciesAsync(hostName, filter, top, select), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns Intune Android policies.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='hostName'>
            /// Location hostName for the tenant
            /// </param>
            /// <param name='filter'>
            /// The filter to apply on the operation.
            /// </param>
            /// <param name='top'>
            /// </param>
            /// <param name='select'>
            /// select specific fields in entity.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<AndroidMAMPolicy>> GetMAMPoliciesAsync( this IAndroidOperations operations, string hostName, string filter = default(string), int? top = default(int?), string select = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<IPage<AndroidMAMPolicy>> result = await operations.GetMAMPoliciesWithHttpMessagesAsync(hostName, filter, top, select, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Returns AndroidMAMPolicy with given Id.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='hostName'>
            /// Location hostName for the tenant
            /// </param>
            /// <param name='policyId'>
            /// policy unique Id
            /// </param>
            /// <param name='select'>
            /// select specific fields in entity.
            /// </param>
            public static AndroidMAMPolicy GetMAMPolicyById(this IAndroidOperations operations, string hostName, string policyId, string select = default(string))
            {
                return Task.Factory.StartNew(s => ((IAndroidOperations)s).GetMAMPolicyByIdAsync(hostName, policyId, select), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns AndroidMAMPolicy with given Id.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='hostName'>
            /// Location hostName for the tenant
            /// </param>
            /// <param name='policyId'>
            /// policy unique Id
            /// </param>
            /// <param name='select'>
            /// select specific fields in entity.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AndroidMAMPolicy> GetMAMPolicyByIdAsync( this IAndroidOperations operations, string hostName, string policyId, string select = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<AndroidMAMPolicy> result = await operations.GetMAMPolicyByIdWithHttpMessagesAsync(hostName, policyId, select, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Creates or updates AndroidMAMPolicy.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='hostName'>
            /// Location hostName for the tenant
            /// </param>
            /// <param name='policyId'>
            /// policy unique Id
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the Create or update an android policy operation.
            /// </param>
            public static AndroidMAMPolicy CreateOrUpdateMAMPolicy(this IAndroidOperations operations, string hostName, string policyId, AndroidMAMPolicy parameters)
            {
                return Task.Factory.StartNew(s => ((IAndroidOperations)s).CreateOrUpdateMAMPolicyAsync(hostName, policyId, parameters), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates AndroidMAMPolicy.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='hostName'>
            /// Location hostName for the tenant
            /// </param>
            /// <param name='policyId'>
            /// policy unique Id
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the Create or update an android policy operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AndroidMAMPolicy> CreateOrUpdateMAMPolicyAsync( this IAndroidOperations operations, string hostName, string policyId, AndroidMAMPolicy parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<AndroidMAMPolicy> result = await operations.CreateOrUpdateMAMPolicyWithHttpMessagesAsync(hostName, policyId, parameters, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Patch AndroidMAMPolicy.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='hostName'>
            /// Location hostName for the tenant
            /// </param>
            /// <param name='policyId'>
            /// policy unique Id
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the Create or update an android policy operation.
            /// </param>
            public static AndroidMAMPolicy PatchMAMPolicy(this IAndroidOperations operations, string hostName, string policyId, AndroidMAMPolicy parameters)
            {
                return Task.Factory.StartNew(s => ((IAndroidOperations)s).PatchMAMPolicyAsync(hostName, policyId, parameters), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Patch AndroidMAMPolicy.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='hostName'>
            /// Location hostName for the tenant
            /// </param>
            /// <param name='policyId'>
            /// policy unique Id
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the Create or update an android policy operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AndroidMAMPolicy> PatchMAMPolicyAsync( this IAndroidOperations operations, string hostName, string policyId, AndroidMAMPolicy parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<AndroidMAMPolicy> result = await operations.PatchMAMPolicyWithHttpMessagesAsync(hostName, policyId, parameters, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Delete Android Policy
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='hostName'>
            /// Location hostName for the tenant
            /// </param>
            /// <param name='policyId'>
            /// policy unique Id
            /// </param>
            public static void DeleteMAMPolicy(this IAndroidOperations operations, string hostName, string policyId)
            {
                Task.Factory.StartNew(s => ((IAndroidOperations)s).DeleteMAMPolicyAsync(hostName, policyId), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete Android Policy
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='hostName'>
            /// Location hostName for the tenant
            /// </param>
            /// <param name='policyId'>
            /// policy unique Id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteMAMPolicyAsync( this IAndroidOperations operations, string hostName, string policyId, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.DeleteMAMPolicyWithHttpMessagesAsync(hostName, policyId, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Get apps for an AndroidMAMPolicy.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='hostName'>
            /// Location hostName for the tenant
            /// </param>
            /// <param name='policyId'>
            /// policy unique Id
            /// </param>
            /// <param name='filter'>
            /// The filter to apply on the operation.
            /// </param>
            /// <param name='top'>
            /// </param>
            /// <param name='select'>
            /// select specific fields in entity.
            /// </param>
            public static IPage<Application> GetAppForMAMPolicy(this IAndroidOperations operations, string hostName, string policyId, string filter = default(string), int? top = default(int?), string select = default(string))
            {
                return Task.Factory.StartNew(s => ((IAndroidOperations)s).GetAppForMAMPolicyAsync(hostName, policyId, filter, top, select), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get apps for an AndroidMAMPolicy.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='hostName'>
            /// Location hostName for the tenant
            /// </param>
            /// <param name='policyId'>
            /// policy unique Id
            /// </param>
            /// <param name='filter'>
            /// The filter to apply on the operation.
            /// </param>
            /// <param name='top'>
            /// </param>
            /// <param name='select'>
            /// select specific fields in entity.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Application>> GetAppForMAMPolicyAsync( this IAndroidOperations operations, string hostName, string policyId, string filter = default(string), int? top = default(int?), string select = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<IPage<Application>> result = await operations.GetAppForMAMPolicyWithHttpMessagesAsync(hostName, policyId, filter, top, select, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Add app to an AndroidMAMPolicy.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='hostName'>
            /// Location hostName for the tenant
            /// </param>
            /// <param name='policyId'>
            /// policy unique Id
            /// </param>
            /// <param name='appId'>
            /// application unique Id
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the Create or update app to an android policy
            /// operation.
            /// </param>
            public static void AddAppForPolicy(this IAndroidOperations operations, string hostName, string policyId, string appId, MAMPolicyAppIdOrGroupIdPayload parameters)
            {
                Task.Factory.StartNew(s => ((IAndroidOperations)s).AddAppForPolicyAsync(hostName, policyId, appId, parameters), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Add app to an AndroidMAMPolicy.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='hostName'>
            /// Location hostName for the tenant
            /// </param>
            /// <param name='policyId'>
            /// policy unique Id
            /// </param>
            /// <param name='appId'>
            /// application unique Id
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the Create or update app to an android policy
            /// operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task AddAppForPolicyAsync( this IAndroidOperations operations, string hostName, string policyId, string appId, MAMPolicyAppIdOrGroupIdPayload parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.AddAppForPolicyWithHttpMessagesAsync(hostName, policyId, appId, parameters, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Delete App for Android Policy
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='hostName'>
            /// Location hostName for the tenant
            /// </param>
            /// <param name='policyId'>
            /// policy unique Id
            /// </param>
            /// <param name='appId'>
            /// application unique Id
            /// </param>
            public static void DeleteAppForMAMPolicy(this IAndroidOperations operations, string hostName, string policyId, string appId)
            {
                Task.Factory.StartNew(s => ((IAndroidOperations)s).DeleteAppForMAMPolicyAsync(hostName, policyId, appId), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete App for Android Policy
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='hostName'>
            /// Location hostName for the tenant
            /// </param>
            /// <param name='policyId'>
            /// policy unique Id
            /// </param>
            /// <param name='appId'>
            /// application unique Id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAppForMAMPolicyAsync( this IAndroidOperations operations, string hostName, string policyId, string appId, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.DeleteAppForMAMPolicyWithHttpMessagesAsync(hostName, policyId, appId, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Returns groups for a given AndroidMAMPolicy.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='hostName'>
            /// Location hostName for the tenant
            /// </param>
            /// <param name='policyId'>
            /// policy name for the tenant
            /// </param>
            public static IPage<Group> GetGroupsForMAMPolicy(this IAndroidOperations operations, string hostName, string policyId)
            {
                return Task.Factory.StartNew(s => ((IAndroidOperations)s).GetGroupsForMAMPolicyAsync(hostName, policyId), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns groups for a given AndroidMAMPolicy.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='hostName'>
            /// Location hostName for the tenant
            /// </param>
            /// <param name='policyId'>
            /// policy name for the tenant
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Group>> GetGroupsForMAMPolicyAsync( this IAndroidOperations operations, string hostName, string policyId, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<IPage<Group>> result = await operations.GetGroupsForMAMPolicyWithHttpMessagesAsync(hostName, policyId, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Add group to an AndroidMAMPolicy.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='hostName'>
            /// Location hostName for the tenant
            /// </param>
            /// <param name='policyId'>
            /// policy unique Id
            /// </param>
            /// <param name='groupId'>
            /// group Id
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the Create or update app to an android policy
            /// operation.
            /// </param>
            public static void AddGroupForPolicy(this IAndroidOperations operations, string hostName, string policyId, string groupId, MAMPolicyAppIdOrGroupIdPayload parameters)
            {
                Task.Factory.StartNew(s => ((IAndroidOperations)s).AddGroupForPolicyAsync(hostName, policyId, groupId, parameters), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Add group to an AndroidMAMPolicy.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='hostName'>
            /// Location hostName for the tenant
            /// </param>
            /// <param name='policyId'>
            /// policy unique Id
            /// </param>
            /// <param name='groupId'>
            /// group Id
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the Create or update app to an android policy
            /// operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task AddGroupForPolicyAsync( this IAndroidOperations operations, string hostName, string policyId, string groupId, MAMPolicyAppIdOrGroupIdPayload parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.AddGroupForPolicyWithHttpMessagesAsync(hostName, policyId, groupId, parameters, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Delete Group for Android Policy
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='hostName'>
            /// Location hostName for the tenant
            /// </param>
            /// <param name='policyId'>
            /// policy unique Id
            /// </param>
            /// <param name='groupId'>
            /// application unique Id
            /// </param>
            public static void DeleteGroupForMAMPolicy(this IAndroidOperations operations, string hostName, string policyId, string groupId)
            {
                Task.Factory.StartNew(s => ((IAndroidOperations)s).DeleteGroupForMAMPolicyAsync(hostName, policyId, groupId), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete Group for Android Policy
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='hostName'>
            /// Location hostName for the tenant
            /// </param>
            /// <param name='policyId'>
            /// policy unique Id
            /// </param>
            /// <param name='groupId'>
            /// application unique Id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteGroupForMAMPolicyAsync( this IAndroidOperations operations, string hostName, string policyId, string groupId, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.DeleteGroupForMAMPolicyWithHttpMessagesAsync(hostName, policyId, groupId, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Returns Intune Android policies.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<AndroidMAMPolicy> GetMAMPoliciesNext(this IAndroidOperations operations, string nextPageLink)
            {
                return Task.Factory.StartNew(s => ((IAndroidOperations)s).GetMAMPoliciesNextAsync(nextPageLink), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns Intune Android policies.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<AndroidMAMPolicy>> GetMAMPoliciesNextAsync( this IAndroidOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<IPage<AndroidMAMPolicy>> result = await operations.GetMAMPoliciesNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Get apps for an AndroidMAMPolicy.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<Application> GetAppForMAMPolicyNext(this IAndroidOperations operations, string nextPageLink)
            {
                return Task.Factory.StartNew(s => ((IAndroidOperations)s).GetAppForMAMPolicyNextAsync(nextPageLink), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get apps for an AndroidMAMPolicy.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Application>> GetAppForMAMPolicyNextAsync( this IAndroidOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<IPage<Application>> result = await operations.GetAppForMAMPolicyNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Returns groups for a given AndroidMAMPolicy.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<Group> GetGroupsForMAMPolicyNext(this IAndroidOperations operations, string nextPageLink)
            {
                return Task.Factory.StartNew(s => ((IAndroidOperations)s).GetGroupsForMAMPolicyNextAsync(nextPageLink), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns groups for a given AndroidMAMPolicy.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Group>> GetGroupsForMAMPolicyNextAsync( this IAndroidOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<IPage<Group>> result = await operations.GetGroupsForMAMPolicyNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

    }
}
