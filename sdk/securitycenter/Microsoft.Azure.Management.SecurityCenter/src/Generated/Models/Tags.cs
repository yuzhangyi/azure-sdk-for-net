// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Security.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A list of key value pairs that describe the resource.
    /// </summary>
    public partial class Tags
    {
        /// <summary>
        /// Initializes a new instance of the Tags class.
        /// </summary>
        public Tags()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Tags class.
        /// </summary>
        /// <param name="tagsProperty">A list of key value pairs that describe
        /// the resource.</param>
        public Tags(IDictionary<string, string> tagsProperty = default(IDictionary<string, string>))
        {
            TagsProperty = tagsProperty;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a list of key value pairs that describe the resource.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> TagsProperty { get; set; }

    }
}
