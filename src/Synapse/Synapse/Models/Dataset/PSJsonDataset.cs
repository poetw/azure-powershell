// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Commands.Synapse.Models
{
    using global::Azure.Analytics.Synapse.Artifacts.Models;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Json dataset.
    /// </summary>
    [Newtonsoft.Json.JsonObject("Json")]
    [Rest.Serialization.JsonTransformation]
    public partial class PSJsonDataset : PSDataset
    {
        /// <summary>
        /// Initializes a new instance of the PSJsonDataset class.
        /// </summary>
        public PSJsonDataset()
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the location of the json data storage.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.location")]
        public DatasetLocation Location { get; set; }

        /// <summary>
        /// Gets or sets the code page name of the preferred encoding. If not
        /// specified, the default value is UTF-8, unless BOM denotes another
        /// Unicode encoding. Refer to the name column of the table in the
        /// following link to set supported values:
        /// https://msdn.microsoft.com/library/system.text.encoding.aspx. Type:
        /// string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.encodingName")]
        public object EncodingName { get; set; }

        /// <summary>
        /// Gets or sets the data compression method used for the json dataset.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.compression")]
        public DatasetCompression Compression { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Location == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Location");
            }
        }

        public override Dataset ToSdkObject()
        {
            var dataset = new JsonDataset(this.LinkedServiceName);
            dataset.Location = this.Location;
            dataset.EncodingName = this.EncodingName;
            dataset.Compression = this.Compression;
            SetProperties(dataset);
            return dataset;
        }
    }
}

