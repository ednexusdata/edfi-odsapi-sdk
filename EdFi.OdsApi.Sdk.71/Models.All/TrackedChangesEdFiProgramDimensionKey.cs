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
    /// TrackedChangesEdFiProgramDimensionKey
    /// </summary>
    [DataContract(Name = "trackedChanges_edFi_programDimensionKey")]
    public partial class TrackedChangesEdFiProgramDimensionKey : IEquatable<TrackedChangesEdFiProgramDimensionKey>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrackedChangesEdFiProgramDimensionKey" /> class.
        /// </summary>
        /// <param name="code">The code representation of the account program dimension..</param>
        /// <param name="fiscalYear">The fiscal year for which the account program dimension is valid..</param>
        public TrackedChangesEdFiProgramDimensionKey(string code = default(string), int fiscalYear = default(int))
        {
            this.Code = code;
            this.FiscalYear = fiscalYear;
        }

        /// <summary>
        /// The code representation of the account program dimension.
        /// </summary>
        /// <value>The code representation of the account program dimension.</value>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public string Code { get; set; }

        /// <summary>
        /// The fiscal year for which the account program dimension is valid.
        /// </summary>
        /// <value>The fiscal year for which the account program dimension is valid.</value>
        [DataMember(Name = "fiscalYear", EmitDefaultValue = false)]
        public int FiscalYear { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TrackedChangesEdFiProgramDimensionKey {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  FiscalYear: ").Append(FiscalYear).Append("\n");
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
            return this.Equals(input as TrackedChangesEdFiProgramDimensionKey);
        }

        /// <summary>
        /// Returns true if TrackedChangesEdFiProgramDimensionKey instances are equal
        /// </summary>
        /// <param name="input">Instance of TrackedChangesEdFiProgramDimensionKey to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrackedChangesEdFiProgramDimensionKey input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.FiscalYear == input.FiscalYear ||
                    this.FiscalYear.Equals(input.FiscalYear)
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
                if (this.Code != null)
                {
                    hashCode = (hashCode * 59) + this.Code.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.FiscalYear.GetHashCode();
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
            // Code (string) maxLength
            if (this.Code != null && this.Code.Length > 16)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Code, length must be less than 16.", new [] { "Code" });
            }

            // Code (string) minLength
            if (this.Code != null && this.Code.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Code, length must be greater than 1.", new [] { "Code" });
            }

            // FiscalYear (int) maximum
            if (this.FiscalYear > (int)2040)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FiscalYear, must be a value less than or equal to 2040.", new [] { "FiscalYear" });
            }

            // FiscalYear (int) minimum
            if (this.FiscalYear < (int)2020)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FiscalYear, must be a value greater than or equal to 2020.", new [] { "FiscalYear" });
            }

            yield break;
        }
    }

}
