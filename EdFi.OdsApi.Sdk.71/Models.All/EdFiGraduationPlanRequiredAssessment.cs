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
    /// EdFiGraduationPlanRequiredAssessment
    /// </summary>
    [DataContract(Name = "edFi_graduationPlanRequiredAssessment")]
    public partial class EdFiGraduationPlanRequiredAssessment : IEquatable<EdFiGraduationPlanRequiredAssessment>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiGraduationPlanRequiredAssessment" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiGraduationPlanRequiredAssessment() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiGraduationPlanRequiredAssessment" /> class.
        /// </summary>
        /// <param name="assessmentReference">assessmentReference (required).</param>
        /// <param name="scores">An unordered collection of graduationPlanRequiredAssessmentScores. Score required to be met or exceeded..</param>
        /// <param name="performanceLevel">performanceLevel.</param>
        public EdFiGraduationPlanRequiredAssessment(EdFiAssessmentReference assessmentReference = default(EdFiAssessmentReference), List<EdFiGraduationPlanRequiredAssessmentScore> scores = default(List<EdFiGraduationPlanRequiredAssessmentScore>), EdFiGraduationPlanRequiredAssessmentPerformanceLevel performanceLevel = default(EdFiGraduationPlanRequiredAssessmentPerformanceLevel))
        {
            // to ensure "assessmentReference" is required (not null)
            if (assessmentReference == null)
            {
                throw new ArgumentNullException("assessmentReference is a required property for EdFiGraduationPlanRequiredAssessment and cannot be null");
            }
            this.AssessmentReference = assessmentReference;
            this.Scores = scores;
            this.PerformanceLevel = performanceLevel;
        }

        /// <summary>
        /// Gets or Sets AssessmentReference
        /// </summary>
        [DataMember(Name = "assessmentReference", IsRequired = true, EmitDefaultValue = true)]
        public EdFiAssessmentReference AssessmentReference { get; set; }

        /// <summary>
        /// An unordered collection of graduationPlanRequiredAssessmentScores. Score required to be met or exceeded.
        /// </summary>
        /// <value>An unordered collection of graduationPlanRequiredAssessmentScores. Score required to be met or exceeded.</value>
        [DataMember(Name = "scores", EmitDefaultValue = false)]
        public List<EdFiGraduationPlanRequiredAssessmentScore> Scores { get; set; }

        /// <summary>
        /// Gets or Sets PerformanceLevel
        /// </summary>
        [DataMember(Name = "performanceLevel", EmitDefaultValue = false)]
        public EdFiGraduationPlanRequiredAssessmentPerformanceLevel PerformanceLevel { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EdFiGraduationPlanRequiredAssessment {\n");
            sb.Append("  AssessmentReference: ").Append(AssessmentReference).Append("\n");
            sb.Append("  Scores: ").Append(Scores).Append("\n");
            sb.Append("  PerformanceLevel: ").Append(PerformanceLevel).Append("\n");
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
            return this.Equals(input as EdFiGraduationPlanRequiredAssessment);
        }

        /// <summary>
        /// Returns true if EdFiGraduationPlanRequiredAssessment instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiGraduationPlanRequiredAssessment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiGraduationPlanRequiredAssessment input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AssessmentReference == input.AssessmentReference ||
                    (this.AssessmentReference != null &&
                    this.AssessmentReference.Equals(input.AssessmentReference))
                ) && 
                (
                    this.Scores == input.Scores ||
                    this.Scores != null &&
                    input.Scores != null &&
                    this.Scores.SequenceEqual(input.Scores)
                ) && 
                (
                    this.PerformanceLevel == input.PerformanceLevel ||
                    (this.PerformanceLevel != null &&
                    this.PerformanceLevel.Equals(input.PerformanceLevel))
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
                if (this.AssessmentReference != null)
                {
                    hashCode = (hashCode * 59) + this.AssessmentReference.GetHashCode();
                }
                if (this.Scores != null)
                {
                    hashCode = (hashCode * 59) + this.Scores.GetHashCode();
                }
                if (this.PerformanceLevel != null)
                {
                    hashCode = (hashCode * 59) + this.PerformanceLevel.GetHashCode();
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
