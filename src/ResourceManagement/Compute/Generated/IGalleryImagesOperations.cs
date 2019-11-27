// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Fluent
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// GalleryImagesOperations operations.
    /// </summary>
    public partial interface IGalleryImagesOperations
    {
        /// <summary>
        /// Create or update a gallery Image Definition.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='galleryName'>
        /// The name of the Shared Image Gallery in which the Image Definition
        /// is to be created.
        /// </param>
        /// <param name='galleryImageName'>
        /// The name of the gallery Image Definition to be created or updated.
        /// The allowed characters are alphabets and numbers with dots, dashes,
        /// and periods allowed in the middle. The maximum length is 80
        /// characters.
        /// </param>
        /// <param name='galleryImage'>
        /// Parameters supplied to the create or update gallery image
        /// operation.
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
        Task<AzureOperationResponse<GalleryImageInner>> CreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string galleryName, string galleryImageName, GalleryImageInner galleryImage, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Update a gallery Image Definition.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='galleryName'>
        /// The name of the Shared Image Gallery in which the Image Definition
        /// is to be updated.
        /// </param>
        /// <param name='galleryImageName'>
        /// The name of the gallery Image Definition to be updated. The allowed
        /// characters are alphabets and numbers with dots, dashes, and periods
        /// allowed in the middle. The maximum length is 80 characters.
        /// </param>
        /// <param name='galleryImage'>
        /// Parameters supplied to the update gallery image operation.
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
        Task<AzureOperationResponse<GalleryImageInner>> UpdateWithHttpMessagesAsync(string resourceGroupName, string galleryName, string galleryImageName, GalleryImageUpdate galleryImage, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Retrieves information about a gallery Image Definition.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='galleryName'>
        /// The name of the Shared Image Gallery from which the Image
        /// Definitions are to be retrieved.
        /// </param>
        /// <param name='galleryImageName'>
        /// The name of the gallery Image Definition to be retrieved.
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
        Task<AzureOperationResponse<GalleryImageInner>> GetWithHttpMessagesAsync(string resourceGroupName, string galleryName, string galleryImageName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Delete a gallery image.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='galleryName'>
        /// The name of the Shared Image Gallery in which the Image Definition
        /// is to be deleted.
        /// </param>
        /// <param name='galleryImageName'>
        /// The name of the gallery Image Definition to be deleted.
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
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string resourceGroupName, string galleryName, string galleryImageName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// List gallery Image Definitions in a gallery.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='galleryName'>
        /// The name of the Shared Image Gallery from which Image Definitions
        /// are to be listed.
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
        Task<AzureOperationResponse<IPage<GalleryImageInner>>> ListByGalleryWithHttpMessagesAsync(string resourceGroupName, string galleryName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Create or update a gallery Image Definition.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='galleryName'>
        /// The name of the Shared Image Gallery in which the Image Definition
        /// is to be created.
        /// </param>
        /// <param name='galleryImageName'>
        /// The name of the gallery Image Definition to be created or updated.
        /// The allowed characters are alphabets and numbers with dots, dashes,
        /// and periods allowed in the middle. The maximum length is 80
        /// characters.
        /// </param>
        /// <param name='galleryImage'>
        /// Parameters supplied to the create or update gallery image
        /// operation.
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
        Task<AzureOperationResponse<GalleryImageInner>> BeginCreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string galleryName, string galleryImageName, GalleryImageInner galleryImage, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Update a gallery Image Definition.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='galleryName'>
        /// The name of the Shared Image Gallery in which the Image Definition
        /// is to be updated.
        /// </param>
        /// <param name='galleryImageName'>
        /// The name of the gallery Image Definition to be updated. The allowed
        /// characters are alphabets and numbers with dots, dashes, and periods
        /// allowed in the middle. The maximum length is 80 characters.
        /// </param>
        /// <param name='galleryImage'>
        /// Parameters supplied to the update gallery image operation.
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
        Task<AzureOperationResponse<GalleryImageInner>> BeginUpdateWithHttpMessagesAsync(string resourceGroupName, string galleryName, string galleryImageName, GalleryImageUpdate galleryImage, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Delete a gallery image.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='galleryName'>
        /// The name of the Shared Image Gallery in which the Image Definition
        /// is to be deleted.
        /// </param>
        /// <param name='galleryImageName'>
        /// The name of the gallery Image Definition to be deleted.
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
        Task<AzureOperationResponse> BeginDeleteWithHttpMessagesAsync(string resourceGroupName, string galleryName, string galleryImageName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// List gallery Image Definitions in a gallery.
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
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
        Task<AzureOperationResponse<IPage<GalleryImageInner>>> ListByGalleryNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
