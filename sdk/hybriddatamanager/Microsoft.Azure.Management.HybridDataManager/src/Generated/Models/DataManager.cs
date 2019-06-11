// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.HybridData.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The DataManager resource.
    /// </summary>
    public partial class DataManager : Resource
    {
        /// <summary>
        /// Initializes a new instance of the DataManager class.
        /// </summary>
        public DataManager()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DataManager class.
        /// </summary>
        /// <param name="location">The location of the resource. This will be
        /// one of the supported and registered Azure Geo Regions (e.g. West
        /// US, East
        /// US, Southeast Asia, etc.). The geo region of a resource cannot be
        /// changed once it is created, but if an identical geo
        /// region is specified on update the request will succeed.</param>
        /// <param name="id">The Resource Id.</param>
        /// <param name="name">The Resource Name.</param>
        /// <param name="type">The Resource type.</param>
        /// <param name="tags">The list of key value pairs that describe the
        /// resource. These tags can be used in viewing and grouping this
        /// resource
        /// (across resource groups).</param>
        /// <param name="sku">The sku type.</param>
        /// <param name="etag">Etag of the Resource.</param>
        public DataManager(string location, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), Sku sku = default(Sku), string etag = default(string))
            : base(location, id, name, type, tags, sku)
        {
            Etag = etag;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets etag of the Resource.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}