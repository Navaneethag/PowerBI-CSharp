// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api.V2
{
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.IO;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Dataflows operations.
    /// </summary>
    public partial interface IDataflows
    {
        /// <summary>
        /// Exports the specified dataflow definition to a .json file.
        /// </summary>
        /// <remarks>
        /// &lt;br/&gt;**Required scope**: Dataflow.ReadWrite.All or
        /// Dataflow.Read.All &lt;br/&gt;To set the permissions scope, see
        /// [Register an
        /// app](https://docs.microsoft.com/power-bi/developer/register-app).
        /// </remarks>
        /// <param name='groupId'>
        /// The workspace id
        /// </param>
        /// <param name='dataflowId'>
        /// The dataflow id
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<Stream>> GetDataflowWithHttpMessagesAsync(string groupId, string dataflowId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes a dataflow from the CDS for Analytics storage, including
        /// its definition file and actual model.
        /// </summary>
        /// <remarks>
        /// &lt;br/&gt;**Required scope**: Dataflow.ReadWrite.All &lt;br/&gt;To
        /// set the permissions scope, see [Register an
        /// app](https://docs.microsoft.com/power-bi/developer/register-app).
        /// </remarks>
        /// <param name='groupId'>
        /// The workspace id
        /// </param>
        /// <param name='dataflowId'>
        /// The dataflow id
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<object>> DeleteDataflowWithHttpMessagesAsync(string groupId, string dataflowId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Triggers a refresh for the specified dataflow.
        /// </summary>
        /// <remarks>
        /// &lt;br/&gt;**Required scope**: Dataflow.ReadWrite.All &lt;br/&gt;To
        /// set the permissions scope, see [Register an
        /// app](https://docs.microsoft.com/power-bi/developer/register-app).
        /// </remarks>
        /// <param name='groupId'>
        /// The workspace id
        /// </param>
        /// <param name='dataflowId'>
        /// The dataflow id
        /// </param>
        /// <param name='refreshRequest'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<object>> RefreshDataflowWithHttpMessagesAsync(string groupId, string dataflowId, RefreshRequest refreshRequest = default(RefreshRequest), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns a list of all of datasources defined in the specified
        /// dataflow.
        /// </summary>
        /// <remarks>
        /// &lt;br/&gt;**Required scope**: Dataflow.ReadWrite.All or
        /// Dataflow.Read.All &lt;br/&gt;To set the permissions scope, see
        /// [Register an
        /// app](https://docs.microsoft.com/power-bi/developer/register-app).
        /// </remarks>
        /// <param name='groupId'>
        /// The workspace id
        /// </param>
        /// <param name='dataflowId'>
        /// The dataflow id
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<ODataResponseListDatasource>> GetDataflowDataSourcesWithHttpMessagesAsync(string groupId, string dataflowId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns a list of all dataflows from the specified workspace.
        /// </summary>
        /// <remarks>
        /// &lt;br/&gt;**Required scope**: Dataflow.ReadWrite.All or
        /// Dataflow.Read.All &lt;br/&gt;To set the permissions scope, see
        /// [Register an
        /// app](https://docs.microsoft.com/power-bi/developer/register-app).
        /// </remarks>
        /// <param name='groupId'>
        /// The workspace id
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<ODataResponseListDataflowMetadata>> GetDataflowsWithHttpMessagesAsync(string groupId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}