/*
 * Ed-Fi Operational Data Store API
 *
 * The Ed-Fi ODS / API enables applications to read and write education data stored in an Ed-Fi ODS through a secure REST interface.  ***  > *Note: Consumers of ODS / API information should sanitize all data for display and storage. The ODS / API provides reasonable safeguards against cross-site scripting attacks and other malicious content, but the platform does not and cannot guarantee that the data it contains is free of all potentially harmful content.*  *** 
 *
 * The version of the OpenAPI document: 3
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = EdFi.OdsApi.Sdk.Client.OpenAPIDateConverter;

namespace EdFi.OdsApi.Sdk.Models.All
{
    /// <summary>
    /// EdFiInterventionURI
    /// </summary>
    [DataContract(Name = "edFi_interventionURI")]
    public partial class EdFiInterventionURI : IEquatable<EdFiInterventionURI>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiInterventionURI" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiInterventionURI() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiInterventionURI" /> class.
        /// </summary>
        /// <param name="uri">The URI (typical a URL) pointing to an education content item. (required).</param>
        public EdFiInterventionURI(string uri = default(string))
        {
            // to ensure "uri" is required (not null)
            if (uri == null)
            {
                throw new ArgumentNullException("uri is a required property for EdFiInterventionURI and cannot be null");
            }
            this.Uri = uri;
        }

        /// <summary>
        /// The URI (typical a URL) pointing to an education content item.
        /// </summary>
        /// <value>The URI (typical a URL) pointing to an education content item.</value>
        [DataMember(Name = "uri", IsRequired = true, EmitDefaultValue = true)]
        public string Uri { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EdFiInterventionURI {\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as EdFiInterventionURI);
        }

        /// <summary>
        /// Returns true if EdFiInterventionURI instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiInterventionURI to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiInterventionURI input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Uri == input.Uri ||
                    (this.Uri != null &&
                    this.Uri.Equals(input.Uri))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Uri != null)
                {
                    hashCode = (hashCode * 59) + this.Uri.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // Uri (string) maxLength
            if (this.Uri != null && this.Uri.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Uri, length must be less than 255.", new [] { "Uri" });
            }

            // Uri (string) minLength
            if (this.Uri != null && this.Uri.Length < 5)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Uri, length must be greater than 5.", new [] { "Uri" });
            }

            yield break;
        }
    }

}
