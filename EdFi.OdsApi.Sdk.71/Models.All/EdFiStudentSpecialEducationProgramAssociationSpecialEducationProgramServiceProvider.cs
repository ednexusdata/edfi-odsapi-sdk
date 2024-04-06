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
    /// EdFiStudentSpecialEducationProgramAssociationSpecialEducationProgramServiceProvider
    /// </summary>
    [DataContract(Name = "edFi_studentSpecialEducationProgramAssociationSpecialEducationProgramServiceProvider")]
    public partial class EdFiStudentSpecialEducationProgramAssociationSpecialEducationProgramServiceProvider : IEquatable<EdFiStudentSpecialEducationProgramAssociationSpecialEducationProgramServiceProvider>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentSpecialEducationProgramAssociationSpecialEducationProgramServiceProvider" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiStudentSpecialEducationProgramAssociationSpecialEducationProgramServiceProvider() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentSpecialEducationProgramAssociationSpecialEducationProgramServiceProvider" /> class.
        /// </summary>
        /// <param name="primaryProvider">Primary ServiceProvider..</param>
        /// <param name="staffReference">staffReference (required).</param>
        public EdFiStudentSpecialEducationProgramAssociationSpecialEducationProgramServiceProvider(bool? primaryProvider = default(bool?), EdFiStaffReference staffReference = default(EdFiStaffReference))
        {
            // to ensure "staffReference" is required (not null)
            if (staffReference == null)
            {
                throw new ArgumentNullException("staffReference is a required property for EdFiStudentSpecialEducationProgramAssociationSpecialEducationProgramServiceProvider and cannot be null");
            }
            this.StaffReference = staffReference;
            this.PrimaryProvider = primaryProvider;
        }

        /// <summary>
        /// Primary ServiceProvider.
        /// </summary>
        /// <value>Primary ServiceProvider.</value>
        [DataMember(Name = "primaryProvider", EmitDefaultValue = true)]
        public bool? PrimaryProvider { get; set; }

        /// <summary>
        /// Gets or Sets StaffReference
        /// </summary>
        [DataMember(Name = "staffReference", IsRequired = true, EmitDefaultValue = true)]
        public EdFiStaffReference StaffReference { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EdFiStudentSpecialEducationProgramAssociationSpecialEducationProgramServiceProvider {\n");
            sb.Append("  PrimaryProvider: ").Append(PrimaryProvider).Append("\n");
            sb.Append("  StaffReference: ").Append(StaffReference).Append("\n");
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
            return this.Equals(input as EdFiStudentSpecialEducationProgramAssociationSpecialEducationProgramServiceProvider);
        }

        /// <summary>
        /// Returns true if EdFiStudentSpecialEducationProgramAssociationSpecialEducationProgramServiceProvider instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiStudentSpecialEducationProgramAssociationSpecialEducationProgramServiceProvider to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiStudentSpecialEducationProgramAssociationSpecialEducationProgramServiceProvider input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.PrimaryProvider == input.PrimaryProvider ||
                    (this.PrimaryProvider != null &&
                    this.PrimaryProvider.Equals(input.PrimaryProvider))
                ) && 
                (
                    this.StaffReference == input.StaffReference ||
                    (this.StaffReference != null &&
                    this.StaffReference.Equals(input.StaffReference))
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
                if (this.PrimaryProvider != null)
                {
                    hashCode = (hashCode * 59) + this.PrimaryProvider.GetHashCode();
                }
                if (this.StaffReference != null)
                {
                    hashCode = (hashCode * 59) + this.StaffReference.GetHashCode();
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
            yield break;
        }
    }

}
