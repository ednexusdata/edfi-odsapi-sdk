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
    /// EdFiStudentVisa
    /// </summary>
    [DataContract(Name = "edFi_studentVisa")]
    public partial class EdFiStudentVisa : IEquatable<EdFiStudentVisa>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentVisa" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiStudentVisa() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentVisa" /> class.
        /// </summary>
        /// <param name="visaDescriptor">An indicator of a non-US citizen&#39;s Visa type. (required).</param>
        public EdFiStudentVisa(string visaDescriptor = default(string))
        {
            // to ensure "visaDescriptor" is required (not null)
            if (visaDescriptor == null)
            {
                throw new ArgumentNullException("visaDescriptor is a required property for EdFiStudentVisa and cannot be null");
            }
            this.VisaDescriptor = visaDescriptor;
        }

        /// <summary>
        /// An indicator of a non-US citizen&#39;s Visa type.
        /// </summary>
        /// <value>An indicator of a non-US citizen&#39;s Visa type.</value>
        [DataMember(Name = "visaDescriptor", IsRequired = true, EmitDefaultValue = true)]
        public string VisaDescriptor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EdFiStudentVisa {\n");
            sb.Append("  VisaDescriptor: ").Append(VisaDescriptor).Append("\n");
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
            return this.Equals(input as EdFiStudentVisa);
        }

        /// <summary>
        /// Returns true if EdFiStudentVisa instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiStudentVisa to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiStudentVisa input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.VisaDescriptor == input.VisaDescriptor ||
                    (this.VisaDescriptor != null &&
                    this.VisaDescriptor.Equals(input.VisaDescriptor))
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
                if (this.VisaDescriptor != null)
                {
                    hashCode = (hashCode * 59) + this.VisaDescriptor.GetHashCode();
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
            // VisaDescriptor (string) maxLength
            if (this.VisaDescriptor != null && this.VisaDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for VisaDescriptor, length must be less than 306.", new [] { "VisaDescriptor" });
            }

            yield break;
        }
    }

}
