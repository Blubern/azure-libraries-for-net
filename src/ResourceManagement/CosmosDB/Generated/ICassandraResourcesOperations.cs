// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.CosmosDB.Fluent
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// CassandraResourcesOperations operations.
    /// </summary>
    public partial interface ICassandraResourcesOperations
    {
        /// <summary>
        /// Lists the Cassandra keyspaces under an existing Azure Cosmos DB
        /// database account.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of an Azure resource group.
        /// </param>
        /// <param name='accountName'>
        /// Cosmos DB database account name.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IEnumerable<CassandraKeyspaceGetResultsInner>>> ListCassandraKeyspacesWithHttpMessagesAsync(string resourceGroupName, string accountName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the Cassandra keyspaces under an existing Azure Cosmos DB
        /// database account with the provided name.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of an Azure resource group.
        /// </param>
        /// <param name='accountName'>
        /// Cosmos DB database account name.
        /// </param>
        /// <param name='keyspaceName'>
        /// Cosmos DB keyspace name.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<CassandraKeyspaceGetResultsInner>> GetCassandraKeyspaceWithHttpMessagesAsync(string resourceGroupName, string accountName, string keyspaceName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Create or update an Azure Cosmos DB Cassandra keyspace
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of an Azure resource group.
        /// </param>
        /// <param name='accountName'>
        /// Cosmos DB database account name.
        /// </param>
        /// <param name='keyspaceName'>
        /// Cosmos DB keyspace name.
        /// </param>
        /// <param name='createUpdateCassandraKeyspaceParameters'>
        /// The parameters to provide for the current Cassandra keyspace.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<CassandraKeyspaceGetResultsInner>> CreateUpdateCassandraKeyspaceWithHttpMessagesAsync(string resourceGroupName, string accountName, string keyspaceName, CassandraKeyspaceCreateUpdateParameters createUpdateCassandraKeyspaceParameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes an existing Azure Cosmos DB Cassandra keyspace.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of an Azure resource group.
        /// </param>
        /// <param name='accountName'>
        /// Cosmos DB database account name.
        /// </param>
        /// <param name='keyspaceName'>
        /// Cosmos DB keyspace name.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> DeleteCassandraKeyspaceWithHttpMessagesAsync(string resourceGroupName, string accountName, string keyspaceName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the RUs per second of the Cassandra Keyspace under an existing
        /// Azure Cosmos DB database account with the provided name.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of an Azure resource group.
        /// </param>
        /// <param name='accountName'>
        /// Cosmos DB database account name.
        /// </param>
        /// <param name='keyspaceName'>
        /// Cosmos DB keyspace name.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<ThroughputSettingsGetResultsInner>> GetCassandraKeyspaceThroughputWithHttpMessagesAsync(string resourceGroupName, string accountName, string keyspaceName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Update RUs per second of an Azure Cosmos DB Cassandra Keyspace
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of an Azure resource group.
        /// </param>
        /// <param name='accountName'>
        /// Cosmos DB database account name.
        /// </param>
        /// <param name='keyspaceName'>
        /// Cosmos DB keyspace name.
        /// </param>
        /// <param name='updateThroughputParameters'>
        /// The RUs per second of the parameters to provide for the current
        /// Cassandra Keyspace.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<ThroughputSettingsGetResultsInner>> UpdateCassandraKeyspaceThroughputWithHttpMessagesAsync(string resourceGroupName, string accountName, string keyspaceName, ThroughputSettingsUpdateParameters updateThroughputParameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists the Cassandra table under an existing Azure Cosmos DB
        /// database account.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of an Azure resource group.
        /// </param>
        /// <param name='accountName'>
        /// Cosmos DB database account name.
        /// </param>
        /// <param name='keyspaceName'>
        /// Cosmos DB keyspace name.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IEnumerable<CassandraTableGetResultsInner>>> ListCassandraTablesWithHttpMessagesAsync(string resourceGroupName, string accountName, string keyspaceName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the Cassandra table under an existing Azure Cosmos DB database
        /// account.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of an Azure resource group.
        /// </param>
        /// <param name='accountName'>
        /// Cosmos DB database account name.
        /// </param>
        /// <param name='keyspaceName'>
        /// Cosmos DB keyspace name.
        /// </param>
        /// <param name='tableName'>
        /// Cosmos DB table name.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<CassandraTableGetResultsInner>> GetCassandraTableWithHttpMessagesAsync(string resourceGroupName, string accountName, string keyspaceName, string tableName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Create or update an Azure Cosmos DB Cassandra Table
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of an Azure resource group.
        /// </param>
        /// <param name='accountName'>
        /// Cosmos DB database account name.
        /// </param>
        /// <param name='keyspaceName'>
        /// Cosmos DB keyspace name.
        /// </param>
        /// <param name='tableName'>
        /// Cosmos DB table name.
        /// </param>
        /// <param name='createUpdateCassandraTableParameters'>
        /// The parameters to provide for the current Cassandra Table.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<CassandraTableGetResultsInner>> CreateUpdateCassandraTableWithHttpMessagesAsync(string resourceGroupName, string accountName, string keyspaceName, string tableName, CassandraTableCreateUpdateParameters createUpdateCassandraTableParameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes an existing Azure Cosmos DB Cassandra table.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of an Azure resource group.
        /// </param>
        /// <param name='accountName'>
        /// Cosmos DB database account name.
        /// </param>
        /// <param name='keyspaceName'>
        /// Cosmos DB keyspace name.
        /// </param>
        /// <param name='tableName'>
        /// Cosmos DB table name.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> DeleteCassandraTableWithHttpMessagesAsync(string resourceGroupName, string accountName, string keyspaceName, string tableName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the RUs per second of the Cassandra table under an existing
        /// Azure Cosmos DB database account with the provided name.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of an Azure resource group.
        /// </param>
        /// <param name='accountName'>
        /// Cosmos DB database account name.
        /// </param>
        /// <param name='keyspaceName'>
        /// Cosmos DB keyspace name.
        /// </param>
        /// <param name='tableName'>
        /// Cosmos DB table name.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<ThroughputSettingsGetResultsInner>> GetCassandraTableThroughputWithHttpMessagesAsync(string resourceGroupName, string accountName, string keyspaceName, string tableName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Update RUs per second of an Azure Cosmos DB Cassandra table
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of an Azure resource group.
        /// </param>
        /// <param name='accountName'>
        /// Cosmos DB database account name.
        /// </param>
        /// <param name='keyspaceName'>
        /// Cosmos DB keyspace name.
        /// </param>
        /// <param name='tableName'>
        /// Cosmos DB table name.
        /// </param>
        /// <param name='updateThroughputParameters'>
        /// The RUs per second of the parameters to provide for the current
        /// Cassandra table.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<ThroughputSettingsGetResultsInner>> UpdateCassandraTableThroughputWithHttpMessagesAsync(string resourceGroupName, string accountName, string keyspaceName, string tableName, ThroughputSettingsUpdateParameters updateThroughputParameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Create or update an Azure Cosmos DB Cassandra keyspace
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of an Azure resource group.
        /// </param>
        /// <param name='accountName'>
        /// Cosmos DB database account name.
        /// </param>
        /// <param name='keyspaceName'>
        /// Cosmos DB keyspace name.
        /// </param>
        /// <param name='createUpdateCassandraKeyspaceParameters'>
        /// The parameters to provide for the current Cassandra keyspace.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<CassandraKeyspaceGetResultsInner>> BeginCreateUpdateCassandraKeyspaceWithHttpMessagesAsync(string resourceGroupName, string accountName, string keyspaceName, CassandraKeyspaceCreateUpdateParameters createUpdateCassandraKeyspaceParameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes an existing Azure Cosmos DB Cassandra keyspace.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of an Azure resource group.
        /// </param>
        /// <param name='accountName'>
        /// Cosmos DB database account name.
        /// </param>
        /// <param name='keyspaceName'>
        /// Cosmos DB keyspace name.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> BeginDeleteCassandraKeyspaceWithHttpMessagesAsync(string resourceGroupName, string accountName, string keyspaceName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Update RUs per second of an Azure Cosmos DB Cassandra Keyspace
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of an Azure resource group.
        /// </param>
        /// <param name='accountName'>
        /// Cosmos DB database account name.
        /// </param>
        /// <param name='keyspaceName'>
        /// Cosmos DB keyspace name.
        /// </param>
        /// <param name='updateThroughputParameters'>
        /// The RUs per second of the parameters to provide for the current
        /// Cassandra Keyspace.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<ThroughputSettingsGetResultsInner>> BeginUpdateCassandraKeyspaceThroughputWithHttpMessagesAsync(string resourceGroupName, string accountName, string keyspaceName, ThroughputSettingsUpdateParameters updateThroughputParameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Create or update an Azure Cosmos DB Cassandra Table
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of an Azure resource group.
        /// </param>
        /// <param name='accountName'>
        /// Cosmos DB database account name.
        /// </param>
        /// <param name='keyspaceName'>
        /// Cosmos DB keyspace name.
        /// </param>
        /// <param name='tableName'>
        /// Cosmos DB table name.
        /// </param>
        /// <param name='createUpdateCassandraTableParameters'>
        /// The parameters to provide for the current Cassandra Table.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<CassandraTableGetResultsInner>> BeginCreateUpdateCassandraTableWithHttpMessagesAsync(string resourceGroupName, string accountName, string keyspaceName, string tableName, CassandraTableCreateUpdateParameters createUpdateCassandraTableParameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes an existing Azure Cosmos DB Cassandra table.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of an Azure resource group.
        /// </param>
        /// <param name='accountName'>
        /// Cosmos DB database account name.
        /// </param>
        /// <param name='keyspaceName'>
        /// Cosmos DB keyspace name.
        /// </param>
        /// <param name='tableName'>
        /// Cosmos DB table name.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> BeginDeleteCassandraTableWithHttpMessagesAsync(string resourceGroupName, string accountName, string keyspaceName, string tableName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Update RUs per second of an Azure Cosmos DB Cassandra table
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of an Azure resource group.
        /// </param>
        /// <param name='accountName'>
        /// Cosmos DB database account name.
        /// </param>
        /// <param name='keyspaceName'>
        /// Cosmos DB keyspace name.
        /// </param>
        /// <param name='tableName'>
        /// Cosmos DB table name.
        /// </param>
        /// <param name='updateThroughputParameters'>
        /// The RUs per second of the parameters to provide for the current
        /// Cassandra table.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<ThroughputSettingsGetResultsInner>> BeginUpdateCassandraTableThroughputWithHttpMessagesAsync(string resourceGroupName, string accountName, string keyspaceName, string tableName, ThroughputSettingsUpdateParameters updateThroughputParameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
