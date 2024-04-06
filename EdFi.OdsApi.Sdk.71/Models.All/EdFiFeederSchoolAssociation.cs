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
    /// EdFiFeederSchoolAssociation
    /// </summary>
    [DataContract(Name = "edFi_feederSchoolAssociation")]
    public partial class EdFiFeederSchoolAssociation : IEquatable<EdFiFeederSchoolAssociation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiFeederSchoolAssociation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiFeederSchoolAssociation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiFeederSchoolAssociation" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="beginDate">The month, day, and year of the first day of the feeder school association. (required).</param>
        /// <param name="feederSchoolReference">feederSchoolReference (required).</param>
        /// <param name="schoolReference">schoolReference (required).</param>
        /// <param name="endDate">The month, day, and year of the last day of the feeder school association..</param>
        /// <param name="feederRelationshipDescription">Describes the relationship from the feeder school to the receiving school, for example by program emphasis, such as special education, language immersion, science, or performing art..</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        /// <param name="lastModifiedDate">The date and time the resource was last modified..</param>
        public EdFiFeederSchoolAssociation(string id = default(string), DateTime beginDate = default(DateTime), EdFiSchoolReference feederSchoolReference = default(EdFiSchoolReference), EdFiSchoolReference schoolReference = default(EdFiSchoolReference), DateTime? endDate = default(DateTime?), string feederRelationshipDescription = default(string), string etag = default(string), DateTime lastModifiedDate = default(DateTime))
        {
            this.BeginDate = beginDate;
            // to ensure "feederSchoolReference" is required (not null)
            if (feederSchoolReference == null)
            {
                throw new ArgumentNullException("feederSchoolReference is a required property for EdFiFeederSchoolAssociation and cannot be null");
            }
            this.FeederSchoolReference = feederSchoolReference;
            // to ensure "schoolReference" is required (not null)
            if (schoolReference == null)
            {
                throw new ArgumentNullException("schoolReference is a required property for EdFiFeederSchoolAssociation and cannot be null");
            }
            this.SchoolReference = schoolReference;
            this.Id = id;
            this.EndDate = endDate;
            this.FeederRelationshipDescription = feederRelationshipDescription;
            this.Etag = etag;
            this.LastModifiedDate = lastModifiedDate;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// The month, day, and year of the first day of the feeder school association.
        /// </summary>
        /// <value>The month, day, and year of the first day of the feeder school association.</value>
        [DataMember(Name = "beginDate", IsRequired = true, EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime BeginDate { get; set; }

        /// <summary>
        /// Gets or Sets FeederSchoolReference
        /// </summary>
        [DataMember(Name = "feederSchoolReference", IsRequired = true, EmitDefaultValue = true)]
        public EdFiSchoolReference FeederSchoolReference { get; set; }

        /// <summary>
        /// Gets or Sets SchoolReference
        /// </summary>
        [DataMember(Name = "schoolReference", IsRequired = true, EmitDefaultValue = true)]
        public EdFiSchoolReference SchoolReference { get; set; }

        /// <summary>
        /// The month, day, and year of the last day of the feeder school association.
        /// </summary>
        /// <value>The month, day, and year of the last day of the feeder school association.</value>
        [DataMember(Name = "endDate", EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Describes the relationship from the feeder school to the receiving school, for example by program emphasis, such as special education, language immersion, science, or performing art.
        /// </summary>
        /// <value>Describes the relationship from the feeder school to the receiving school, for example by program emphasis, such as special education, language immersion, science, or performing art.</value>
        [DataMember(Name = "feederRelationshipDescription", EmitDefaultValue = true)]
        public string FeederRelationshipDescription { get; set; }

        /// <summary>
        /// A unique system-generated value that identifies the version of the resource.
        /// </summary>
        /// <value>A unique system-generated value that identifies the version of the resource.</value>
        [DataMember(Name = "_etag", EmitDefaultValue = false)]
        public string Etag { get; set; }

        /// <summary>
        /// The date and time the resource was last modified.
        /// </summary>
        /// <value>The date and time the resource was last modified.</value>
        [DataMember(Name = "_lastModifiedDate", EmitDefaultValue = false)]
        public DateTime LastModifiedDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EdFiFeederSchoolAssociation {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  BeginDate: ").Append(BeginDate).Append("\n");
            sb.Append("  FeederSchoolReference: ").Append(FeederSchoolReference).Append("\n");
            sb.Append("  SchoolReference: ").Append(SchoolReference).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  FeederRelationshipDescription: ").Append(FeederRelationshipDescription).Append("\n");
            sb.Append("  Etag: ").Append(Etag).Append("\n");
            sb.Append("  LastModifiedDate: ").Append(LastModifiedDate).Append("\n");
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
            return this.Equals(input as EdFiFeederSchoolAssociation);
        }

        /// <summary>
        /// Returns true if EdFiFeederSchoolAssociation instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiFeederSchoolAssociation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiFeederSchoolAssociation input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.BeginDate == input.BeginDate ||
                    (this.BeginDate != null &&
                    this.BeginDate.Equals(input.BeginDate))
                ) && 
                (
                    this.FeederSchoolReference == input.FeederSchoolReference ||
                    (this.FeederSchoolReference != null &&
                    this.FeederSchoolReference.Equals(input.FeederSchoolReference))
                ) && 
                (
                    this.SchoolReference == input.SchoolReference ||
                    (this.SchoolReference != null &&
                    this.SchoolReference.Equals(input.SchoolReference))
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.FeederRelationshipDescription == input.FeederRelationshipDescription ||
                    (this.FeederRelationshipDescription != null &&
                    this.FeederRelationshipDescription.Equals(input.FeederRelationshipDescription))
                ) && 
                (
                    this.Etag == input.Etag ||
                    (this.Etag != null &&
                    this.Etag.Equals(input.Etag))
                ) && 
                (
                    this.LastModifiedDate == input.LastModifiedDate ||
                    (this.LastModifiedDate != null &&
                    this.LastModifiedDate.Equals(input.LastModifiedDate))
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.BeginDate != null)
                {
                    hashCode = (hashCode * 59) + this.BeginDate.GetHashCode();
                }
                if (this.FeederSchoolReference != null)
                {
                    hashCode = (hashCode * 59) + this.FeederSchoolReference.GetHashCode();
                }
                if (this.SchoolReference != null)
                {
                    hashCode = (hashCode * 59) + this.SchoolReference.GetHashCode();
                }
                if (this.EndDate != null)
                {
                    hashCode = (hashCode * 59) + this.EndDate.GetHashCode();
                }
                if (this.FeederRelationshipDescription != null)
                {
                    hashCode = (hashCode * 59) + this.FeederRelationshipDescription.GetHashCode();
                }
                if (this.Etag != null)
                {
                    hashCode = (hashCode * 59) + this.Etag.GetHashCode();
                }
                if (this.LastModifiedDate != null)
                {
                    hashCode = (hashCode * 59) + this.LastModifiedDate.GetHashCode();
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
            // FeederRelationshipDescription (string) maxLength
            if (this.FeederRelationshipDescription != null && this.FeederRelationshipDescription.Length > 1024)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FeederRelationshipDescription, length must be less than 1024.", new [] { "FeederRelationshipDescription" });
            }

            // FeederRelationshipDescription (string) minLength
            if (this.FeederRelationshipDescription != null && this.FeederRelationshipDescription.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FeederRelationshipDescription, length must be greater than 1.", new [] { "FeederRelationshipDescription" });
            }

            yield break;
        }
    }

}
