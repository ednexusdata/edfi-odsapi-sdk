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
    /// TrackedChangesTpdmRubricDimensionKey
    /// </summary>
    [DataContract(Name = "trackedChanges_tpdm_rubricDimensionKey")]
    public partial class TrackedChangesTpdmRubricDimensionKey : IEquatable<TrackedChangesTpdmRubricDimensionKey>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrackedChangesTpdmRubricDimensionKey" /> class.
        /// </summary>
        /// <param name="rubricRating">The rating achieved for the rubric dimension..</param>
        /// <param name="educationOrganizationId">The identifier assigned to an education organization..</param>
        /// <param name="evaluationElementTitle">The name or title of the evaluation element..</param>
        /// <param name="evaluationObjectiveTitle">The name or title of the evaluation Objective..</param>
        /// <param name="evaluationPeriodDescriptor">The period for the evaluation..</param>
        /// <param name="evaluationTitle">The name or title of the evaluation..</param>
        /// <param name="performanceEvaluationTitle">An assigned unique identifier for the performance evaluation..</param>
        /// <param name="performanceEvaluationTypeDescriptor">The type of performance evaluation conducted..</param>
        /// <param name="schoolYear">The identifier for the school year..</param>
        /// <param name="termDescriptor">The term for the session during the school year..</param>
        public TrackedChangesTpdmRubricDimensionKey(int rubricRating = default(int), long educationOrganizationId = default(long), string evaluationElementTitle = default(string), string evaluationObjectiveTitle = default(string), string evaluationPeriodDescriptor = default(string), string evaluationTitle = default(string), string performanceEvaluationTitle = default(string), string performanceEvaluationTypeDescriptor = default(string), int schoolYear = default(int), string termDescriptor = default(string))
        {
            this.RubricRating = rubricRating;
            this.EducationOrganizationId = educationOrganizationId;
            this.EvaluationElementTitle = evaluationElementTitle;
            this.EvaluationObjectiveTitle = evaluationObjectiveTitle;
            this.EvaluationPeriodDescriptor = evaluationPeriodDescriptor;
            this.EvaluationTitle = evaluationTitle;
            this.PerformanceEvaluationTitle = performanceEvaluationTitle;
            this.PerformanceEvaluationTypeDescriptor = performanceEvaluationTypeDescriptor;
            this.SchoolYear = schoolYear;
            this.TermDescriptor = termDescriptor;
        }

        /// <summary>
        /// The rating achieved for the rubric dimension.
        /// </summary>
        /// <value>The rating achieved for the rubric dimension.</value>
        [DataMember(Name = "rubricRating", EmitDefaultValue = false)]
        public int RubricRating { get; set; }

        /// <summary>
        /// The identifier assigned to an education organization.
        /// </summary>
        /// <value>The identifier assigned to an education organization.</value>
        [DataMember(Name = "educationOrganizationId", EmitDefaultValue = false)]
        public long EducationOrganizationId { get; set; }

        /// <summary>
        /// The name or title of the evaluation element.
        /// </summary>
        /// <value>The name or title of the evaluation element.</value>
        [DataMember(Name = "evaluationElementTitle", EmitDefaultValue = false)]
        public string EvaluationElementTitle { get; set; }

        /// <summary>
        /// The name or title of the evaluation Objective.
        /// </summary>
        /// <value>The name or title of the evaluation Objective.</value>
        [DataMember(Name = "evaluationObjectiveTitle", EmitDefaultValue = false)]
        public string EvaluationObjectiveTitle { get; set; }

        /// <summary>
        /// The period for the evaluation.
        /// </summary>
        /// <value>The period for the evaluation.</value>
        [DataMember(Name = "evaluationPeriodDescriptor", EmitDefaultValue = false)]
        public string EvaluationPeriodDescriptor { get; set; }

        /// <summary>
        /// The name or title of the evaluation.
        /// </summary>
        /// <value>The name or title of the evaluation.</value>
        [DataMember(Name = "evaluationTitle", EmitDefaultValue = false)]
        public string EvaluationTitle { get; set; }

        /// <summary>
        /// An assigned unique identifier for the performance evaluation.
        /// </summary>
        /// <value>An assigned unique identifier for the performance evaluation.</value>
        [DataMember(Name = "performanceEvaluationTitle", EmitDefaultValue = false)]
        public string PerformanceEvaluationTitle { get; set; }

        /// <summary>
        /// The type of performance evaluation conducted.
        /// </summary>
        /// <value>The type of performance evaluation conducted.</value>
        [DataMember(Name = "performanceEvaluationTypeDescriptor", EmitDefaultValue = false)]
        public string PerformanceEvaluationTypeDescriptor { get; set; }

        /// <summary>
        /// The identifier for the school year.
        /// </summary>
        /// <value>The identifier for the school year.</value>
        [DataMember(Name = "schoolYear", EmitDefaultValue = false)]
        public int SchoolYear { get; set; }

        /// <summary>
        /// The term for the session during the school year.
        /// </summary>
        /// <value>The term for the session during the school year.</value>
        [DataMember(Name = "termDescriptor", EmitDefaultValue = false)]
        public string TermDescriptor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TrackedChangesTpdmRubricDimensionKey {\n");
            sb.Append("  RubricRating: ").Append(RubricRating).Append("\n");
            sb.Append("  EducationOrganizationId: ").Append(EducationOrganizationId).Append("\n");
            sb.Append("  EvaluationElementTitle: ").Append(EvaluationElementTitle).Append("\n");
            sb.Append("  EvaluationObjectiveTitle: ").Append(EvaluationObjectiveTitle).Append("\n");
            sb.Append("  EvaluationPeriodDescriptor: ").Append(EvaluationPeriodDescriptor).Append("\n");
            sb.Append("  EvaluationTitle: ").Append(EvaluationTitle).Append("\n");
            sb.Append("  PerformanceEvaluationTitle: ").Append(PerformanceEvaluationTitle).Append("\n");
            sb.Append("  PerformanceEvaluationTypeDescriptor: ").Append(PerformanceEvaluationTypeDescriptor).Append("\n");
            sb.Append("  SchoolYear: ").Append(SchoolYear).Append("\n");
            sb.Append("  TermDescriptor: ").Append(TermDescriptor).Append("\n");
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
            return this.Equals(input as TrackedChangesTpdmRubricDimensionKey);
        }

        /// <summary>
        /// Returns true if TrackedChangesTpdmRubricDimensionKey instances are equal
        /// </summary>
        /// <param name="input">Instance of TrackedChangesTpdmRubricDimensionKey to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrackedChangesTpdmRubricDimensionKey input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.RubricRating == input.RubricRating ||
                    this.RubricRating.Equals(input.RubricRating)
                ) && 
                (
                    this.EducationOrganizationId == input.EducationOrganizationId ||
                    this.EducationOrganizationId.Equals(input.EducationOrganizationId)
                ) && 
                (
                    this.EvaluationElementTitle == input.EvaluationElementTitle ||
                    (this.EvaluationElementTitle != null &&
                    this.EvaluationElementTitle.Equals(input.EvaluationElementTitle))
                ) && 
                (
                    this.EvaluationObjectiveTitle == input.EvaluationObjectiveTitle ||
                    (this.EvaluationObjectiveTitle != null &&
                    this.EvaluationObjectiveTitle.Equals(input.EvaluationObjectiveTitle))
                ) && 
                (
                    this.EvaluationPeriodDescriptor == input.EvaluationPeriodDescriptor ||
                    (this.EvaluationPeriodDescriptor != null &&
                    this.EvaluationPeriodDescriptor.Equals(input.EvaluationPeriodDescriptor))
                ) && 
                (
                    this.EvaluationTitle == input.EvaluationTitle ||
                    (this.EvaluationTitle != null &&
                    this.EvaluationTitle.Equals(input.EvaluationTitle))
                ) && 
                (
                    this.PerformanceEvaluationTitle == input.PerformanceEvaluationTitle ||
                    (this.PerformanceEvaluationTitle != null &&
                    this.PerformanceEvaluationTitle.Equals(input.PerformanceEvaluationTitle))
                ) && 
                (
                    this.PerformanceEvaluationTypeDescriptor == input.PerformanceEvaluationTypeDescriptor ||
                    (this.PerformanceEvaluationTypeDescriptor != null &&
                    this.PerformanceEvaluationTypeDescriptor.Equals(input.PerformanceEvaluationTypeDescriptor))
                ) && 
                (
                    this.SchoolYear == input.SchoolYear ||
                    this.SchoolYear.Equals(input.SchoolYear)
                ) && 
                (
                    this.TermDescriptor == input.TermDescriptor ||
                    (this.TermDescriptor != null &&
                    this.TermDescriptor.Equals(input.TermDescriptor))
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
                hashCode = (hashCode * 59) + this.RubricRating.GetHashCode();
                hashCode = (hashCode * 59) + this.EducationOrganizationId.GetHashCode();
                if (this.EvaluationElementTitle != null)
                {
                    hashCode = (hashCode * 59) + this.EvaluationElementTitle.GetHashCode();
                }
                if (this.EvaluationObjectiveTitle != null)
                {
                    hashCode = (hashCode * 59) + this.EvaluationObjectiveTitle.GetHashCode();
                }
                if (this.EvaluationPeriodDescriptor != null)
                {
                    hashCode = (hashCode * 59) + this.EvaluationPeriodDescriptor.GetHashCode();
                }
                if (this.EvaluationTitle != null)
                {
                    hashCode = (hashCode * 59) + this.EvaluationTitle.GetHashCode();
                }
                if (this.PerformanceEvaluationTitle != null)
                {
                    hashCode = (hashCode * 59) + this.PerformanceEvaluationTitle.GetHashCode();
                }
                if (this.PerformanceEvaluationTypeDescriptor != null)
                {
                    hashCode = (hashCode * 59) + this.PerformanceEvaluationTypeDescriptor.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SchoolYear.GetHashCode();
                if (this.TermDescriptor != null)
                {
                    hashCode = (hashCode * 59) + this.TermDescriptor.GetHashCode();
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
            // EvaluationElementTitle (string) maxLength
            if (this.EvaluationElementTitle != null && this.EvaluationElementTitle.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EvaluationElementTitle, length must be less than 255.", new [] { "EvaluationElementTitle" });
            }

            // EvaluationElementTitle (string) minLength
            if (this.EvaluationElementTitle != null && this.EvaluationElementTitle.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EvaluationElementTitle, length must be greater than 1.", new [] { "EvaluationElementTitle" });
            }

            // EvaluationObjectiveTitle (string) maxLength
            if (this.EvaluationObjectiveTitle != null && this.EvaluationObjectiveTitle.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EvaluationObjectiveTitle, length must be less than 50.", new [] { "EvaluationObjectiveTitle" });
            }

            // EvaluationObjectiveTitle (string) minLength
            if (this.EvaluationObjectiveTitle != null && this.EvaluationObjectiveTitle.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EvaluationObjectiveTitle, length must be greater than 1.", new [] { "EvaluationObjectiveTitle" });
            }

            // EvaluationPeriodDescriptor (string) maxLength
            if (this.EvaluationPeriodDescriptor != null && this.EvaluationPeriodDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EvaluationPeriodDescriptor, length must be less than 306.", new [] { "EvaluationPeriodDescriptor" });
            }

            // EvaluationTitle (string) maxLength
            if (this.EvaluationTitle != null && this.EvaluationTitle.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EvaluationTitle, length must be less than 50.", new [] { "EvaluationTitle" });
            }

            // EvaluationTitle (string) minLength
            if (this.EvaluationTitle != null && this.EvaluationTitle.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EvaluationTitle, length must be greater than 1.", new [] { "EvaluationTitle" });
            }

            // PerformanceEvaluationTitle (string) maxLength
            if (this.PerformanceEvaluationTitle != null && this.PerformanceEvaluationTitle.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PerformanceEvaluationTitle, length must be less than 50.", new [] { "PerformanceEvaluationTitle" });
            }

            // PerformanceEvaluationTitle (string) minLength
            if (this.PerformanceEvaluationTitle != null && this.PerformanceEvaluationTitle.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PerformanceEvaluationTitle, length must be greater than 1.", new [] { "PerformanceEvaluationTitle" });
            }

            // PerformanceEvaluationTypeDescriptor (string) maxLength
            if (this.PerformanceEvaluationTypeDescriptor != null && this.PerformanceEvaluationTypeDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PerformanceEvaluationTypeDescriptor, length must be less than 306.", new [] { "PerformanceEvaluationTypeDescriptor" });
            }

            // TermDescriptor (string) maxLength
            if (this.TermDescriptor != null && this.TermDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TermDescriptor, length must be less than 306.", new [] { "TermDescriptor" });
            }

            yield break;
        }
    }

}
