// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DeploymentManager
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ServiceTopologiesOperations.
    /// </summary>
    public static partial class ServiceTopologiesOperationsExtensions
    {
            /// <summary>
            /// Creates or updates a service topology.
            /// </summary>
            /// <remarks>
            /// Synchronously creates a new service topology or updates an existing service
            /// topology.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='serviceTopologyInfo'>
            /// Source topology object defines the resource.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='serviceTopologyName'>
            /// The name of the service topology .
            /// </param>
            public static ServiceTopologyResource CreateOrUpdate(this IServiceTopologiesOperations operations, ServiceTopologyResource serviceTopologyInfo, string resourceGroupName, string serviceTopologyName)
            {
                return operations.CreateOrUpdateAsync(serviceTopologyInfo, resourceGroupName, serviceTopologyName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a service topology.
            /// </summary>
            /// <remarks>
            /// Synchronously creates a new service topology or updates an existing service
            /// topology.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='serviceTopologyInfo'>
            /// Source topology object defines the resource.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='serviceTopologyName'>
            /// The name of the service topology .
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ServiceTopologyResource> CreateOrUpdateAsync(this IServiceTopologiesOperations operations, ServiceTopologyResource serviceTopologyInfo, string resourceGroupName, string serviceTopologyName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(serviceTopologyInfo, resourceGroupName, serviceTopologyName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the service topology.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='serviceTopologyName'>
            /// The name of the service topology .
            /// </param>
            public static ServiceTopologyResource Get(this IServiceTopologiesOperations operations, string resourceGroupName, string serviceTopologyName)
            {
                return operations.GetAsync(resourceGroupName, serviceTopologyName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the service topology.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='serviceTopologyName'>
            /// The name of the service topology .
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ServiceTopologyResource> GetAsync(this IServiceTopologiesOperations operations, string resourceGroupName, string serviceTopologyName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, serviceTopologyName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the service topology.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='serviceTopologyName'>
            /// The name of the service topology .
            /// </param>
            public static void Delete(this IServiceTopologiesOperations operations, string resourceGroupName, string serviceTopologyName)
            {
                operations.DeleteAsync(resourceGroupName, serviceTopologyName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the service topology.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='serviceTopologyName'>
            /// The name of the service topology .
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IServiceTopologiesOperations operations, string resourceGroupName, string serviceTopologyName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, serviceTopologyName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}
