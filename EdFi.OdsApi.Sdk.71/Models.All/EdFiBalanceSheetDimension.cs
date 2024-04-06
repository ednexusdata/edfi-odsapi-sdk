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
    /// EdFiBalanceSheetDimension
    /// </summary>
    [DataContract(Name = "edFi_balanceSheetDimension")]
    public partial class EdFiBalanceSheetDimension : IEquatable<EdFiBalanceSheetDimension>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiBalanceSheetDimension" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiBalanceSheetDimension() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiBalanceSheetDimension" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="code">The code representation of the account balance sheet dimension. (required).</param>
        /// <param name="fiscalYear">The fiscal year for which the account balance sheet dimension is valid. (required).</param>
        /// <param name="codeName">A description of the account balance sheet dimension..</param>
        /// <param name="reportingTags">An unordered collection of balanceSheetDimensionReportingTags. Optional tag for accountability reporting..</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        /// <param name="lastModifiedDate">The date and time the resource was last modified..</param>
        public EdFiBalanceSheetDimension(string id = default(string), string code = default(string), int fiscalYear = default(int), string codeName = default(string), List<EdFiBalanceSheetDimensionReportingTag> reportingTags = default(List<EdFiBalanceSheetDimensionReportingTag>), string etag = default(string), DateTime lastModifiedDate = default(DateTime))
        {
            // to ensure "code" is required (not null)
            if (code == null)
            {
                throw new ArgumentNullException("code is a required property for EdFiBalanceSheetDimension and cannot be null");
            }
            this.Code = code;
            this.FiscalYear = fiscalYear;
            this.Id = id;
            this.CodeName = codeName;
            this.ReportingTags = reportingTags;
            this.Etag = etag;
            this.LastModifiedDate = lastModifiedDate;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// The code representation of the account balance sheet dimension.
        /// </summary>
        /// <value>The code representation of the account balance sheet dimension.</value>
        [DataMember(Name = "code", IsRequired = true, EmitDefaultValue = true)]
        public string Code { get; set; }

        /// <summary>
        /// The fiscal year for which the account balance sheet dimension is valid.
        /// </summary>
        /// <value>The fiscal year for which the account balance sheet dimension is valid.</value>
        [DataMember(Name = "fiscalYear", IsRequired = true, EmitDefaultValue = true)]
        public int FiscalYear { get; set; }

        /// <summary>
        /// A description of the account balance sheet dimension.
        /// </summary>
        /// <value>A description of the account balance sheet dimension.</value>
        [DataMember(Name = "codeName", EmitDefaultValue = true)]
        public string CodeName { get; set; }

        /// <summary>
        /// An unordered collection of balanceSheetDimensionReportingTags. Optional tag for accountability reporting.
        /// </summary>
        /// <value>An unordered collection of balanceSheetDimensionReportingTags. Optional tag for accountability reporting.</value>
        [DataMember(Name = "reportingTags", EmitDefaultValue = false)]
        public List<EdFiBalanceSheetDimensionReportingTag> ReportingTags { get; set; }

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
            sb.Append("class EdFiBalanceSheetDimension {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  FiscalYear: ").Append(FiscalYear).Append("\n");
            sb.Append("  CodeName: ").Append(CodeName).Append("\n");
            sb.Append("  ReportingTags: ").Append(ReportingTags).Append("\n");
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
            return this.Equals(input as EdFiBalanceSheetDimension);
        }

        /// <summary>
        /// Returns true if EdFiBalanceSheetDimension instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiBalanceSheetDimension to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiBalanceSheetDimension input)
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
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.FiscalYear == input.FiscalYear ||
                    this.FiscalYear.Equals(input.FiscalYear)
                ) && 
                (
                    this.CodeName == input.CodeName ||
                    (this.CodeName != null &&
                    this.CodeName.Equals(input.CodeName))
                ) && 
                (
                    this.ReportingTags == input.ReportingTags ||
                    this.ReportingTags != null &&
                    input.ReportingTags != null &&
                    this.ReportingTags.SequenceEqual(input.ReportingTags)
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
                if (this.Code != null)
                {
                    hashCode = (hashCode * 59) + this.Code.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.FiscalYear.GetHashCode();
                if (this.CodeName != null)
                {
                    hashCode = (hashCode * 59) + this.CodeName.GetHashCode();
                }
                if (this.ReportingTags != null)
                {
                    hashCode = (hashCode * 59) + this.ReportingTags.GetHashCode();
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

            // CodeName (string) maxLength
            if (this.CodeName != null && this.CodeName.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CodeName, length must be less than 100.", new [] { "CodeName" });
            }

            // CodeName (string) minLength
            if (this.CodeName != null && this.CodeName.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CodeName, length must be greater than 1.", new [] { "CodeName" });
            }

            yield break;
        }
    }

}
