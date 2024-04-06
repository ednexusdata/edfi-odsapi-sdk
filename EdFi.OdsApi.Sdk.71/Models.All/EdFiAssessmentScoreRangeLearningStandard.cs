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
    /// EdFiAssessmentScoreRangeLearningStandard
    /// </summary>
    [DataContract(Name = "edFi_assessmentScoreRangeLearningStandard")]
    public partial class EdFiAssessmentScoreRangeLearningStandard : IEquatable<EdFiAssessmentScoreRangeLearningStandard>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiAssessmentScoreRangeLearningStandard" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiAssessmentScoreRangeLearningStandard() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiAssessmentScoreRangeLearningStandard" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="learningStandards">An unordered collection of assessmentScoreRangeLearningStandardLearningStandards. Learning standard associated with the score range. (required).</param>
        /// <param name="scoreRangeId">A unique number or alphanumeric code assigned to the score range associated with one or more learning standards. (required).</param>
        /// <param name="assessmentReference">assessmentReference (required).</param>
        /// <param name="objectiveAssessmentReference">objectiveAssessmentReference.</param>
        /// <param name="assessmentReportingMethodDescriptor">The assessment reporting method defined (e.g., scale score, RIT scale score) associated with the referenced learning standard(s)..</param>
        /// <param name="maximumScore">The maximum score in the score range. (required).</param>
        /// <param name="minimumScore">The minimum score in the score range. (required).</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        /// <param name="lastModifiedDate">The date and time the resource was last modified..</param>
        public EdFiAssessmentScoreRangeLearningStandard(string id = default(string), List<EdFiAssessmentScoreRangeLearningStandardLearningStandard> learningStandards = default(List<EdFiAssessmentScoreRangeLearningStandardLearningStandard>), string scoreRangeId = default(string), EdFiAssessmentReference assessmentReference = default(EdFiAssessmentReference), EdFiObjectiveAssessmentReference objectiveAssessmentReference = default(EdFiObjectiveAssessmentReference), string assessmentReportingMethodDescriptor = default(string), string maximumScore = default(string), string minimumScore = default(string), string etag = default(string), DateTime lastModifiedDate = default(DateTime))
        {
            // to ensure "learningStandards" is required (not null)
            if (learningStandards == null)
            {
                throw new ArgumentNullException("learningStandards is a required property for EdFiAssessmentScoreRangeLearningStandard and cannot be null");
            }
            this.LearningStandards = learningStandards;
            // to ensure "scoreRangeId" is required (not null)
            if (scoreRangeId == null)
            {
                throw new ArgumentNullException("scoreRangeId is a required property for EdFiAssessmentScoreRangeLearningStandard and cannot be null");
            }
            this.ScoreRangeId = scoreRangeId;
            // to ensure "assessmentReference" is required (not null)
            if (assessmentReference == null)
            {
                throw new ArgumentNullException("assessmentReference is a required property for EdFiAssessmentScoreRangeLearningStandard and cannot be null");
            }
            this.AssessmentReference = assessmentReference;
            // to ensure "maximumScore" is required (not null)
            if (maximumScore == null)
            {
                throw new ArgumentNullException("maximumScore is a required property for EdFiAssessmentScoreRangeLearningStandard and cannot be null");
            }
            this.MaximumScore = maximumScore;
            // to ensure "minimumScore" is required (not null)
            if (minimumScore == null)
            {
                throw new ArgumentNullException("minimumScore is a required property for EdFiAssessmentScoreRangeLearningStandard and cannot be null");
            }
            this.MinimumScore = minimumScore;
            this.Id = id;
            this.ObjectiveAssessmentReference = objectiveAssessmentReference;
            this.AssessmentReportingMethodDescriptor = assessmentReportingMethodDescriptor;
            this.Etag = etag;
            this.LastModifiedDate = lastModifiedDate;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// An unordered collection of assessmentScoreRangeLearningStandardLearningStandards. Learning standard associated with the score range.
        /// </summary>
        /// <value>An unordered collection of assessmentScoreRangeLearningStandardLearningStandards. Learning standard associated with the score range.</value>
        [DataMember(Name = "learningStandards", IsRequired = true, EmitDefaultValue = true)]
        public List<EdFiAssessmentScoreRangeLearningStandardLearningStandard> LearningStandards { get; set; }

        /// <summary>
        /// A unique number or alphanumeric code assigned to the score range associated with one or more learning standards.
        /// </summary>
        /// <value>A unique number or alphanumeric code assigned to the score range associated with one or more learning standards.</value>
        [DataMember(Name = "scoreRangeId", IsRequired = true, EmitDefaultValue = true)]
        public string ScoreRangeId { get; set; }

        /// <summary>
        /// Gets or Sets AssessmentReference
        /// </summary>
        [DataMember(Name = "assessmentReference", IsRequired = true, EmitDefaultValue = true)]
        public EdFiAssessmentReference AssessmentReference { get; set; }

        /// <summary>
        /// Gets or Sets ObjectiveAssessmentReference
        /// </summary>
        [DataMember(Name = "objectiveAssessmentReference", EmitDefaultValue = false)]
        public EdFiObjectiveAssessmentReference ObjectiveAssessmentReference { get; set; }

        /// <summary>
        /// The assessment reporting method defined (e.g., scale score, RIT scale score) associated with the referenced learning standard(s).
        /// </summary>
        /// <value>The assessment reporting method defined (e.g., scale score, RIT scale score) associated with the referenced learning standard(s).</value>
        [DataMember(Name = "assessmentReportingMethodDescriptor", EmitDefaultValue = true)]
        public string AssessmentReportingMethodDescriptor { get; set; }

        /// <summary>
        /// The maximum score in the score range.
        /// </summary>
        /// <value>The maximum score in the score range.</value>
        [DataMember(Name = "maximumScore", IsRequired = true, EmitDefaultValue = true)]
        public string MaximumScore { get; set; }

        /// <summary>
        /// The minimum score in the score range.
        /// </summary>
        /// <value>The minimum score in the score range.</value>
        [DataMember(Name = "minimumScore", IsRequired = true, EmitDefaultValue = true)]
        public string MinimumScore { get; set; }

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
            sb.Append("class EdFiAssessmentScoreRangeLearningStandard {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LearningStandards: ").Append(LearningStandards).Append("\n");
            sb.Append("  ScoreRangeId: ").Append(ScoreRangeId).Append("\n");
            sb.Append("  AssessmentReference: ").Append(AssessmentReference).Append("\n");
            sb.Append("  ObjectiveAssessmentReference: ").Append(ObjectiveAssessmentReference).Append("\n");
            sb.Append("  AssessmentReportingMethodDescriptor: ").Append(AssessmentReportingMethodDescriptor).Append("\n");
            sb.Append("  MaximumScore: ").Append(MaximumScore).Append("\n");
            sb.Append("  MinimumScore: ").Append(MinimumScore).Append("\n");
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
            return this.Equals(input as EdFiAssessmentScoreRangeLearningStandard);
        }

        /// <summary>
        /// Returns true if EdFiAssessmentScoreRangeLearningStandard instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiAssessmentScoreRangeLearningStandard to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiAssessmentScoreRangeLearningStandard input)
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
                    this.LearningStandards == input.LearningStandards ||
                    this.LearningStandards != null &&
                    input.LearningStandards != null &&
                    this.LearningStandards.SequenceEqual(input.LearningStandards)
                ) && 
                (
                    this.ScoreRangeId == input.ScoreRangeId ||
                    (this.ScoreRangeId != null &&
                    this.ScoreRangeId.Equals(input.ScoreRangeId))
                ) && 
                (
                    this.AssessmentReference == input.AssessmentReference ||
                    (this.AssessmentReference != null &&
                    this.AssessmentReference.Equals(input.AssessmentReference))
                ) && 
                (
                    this.ObjectiveAssessmentReference == input.ObjectiveAssessmentReference ||
                    (this.ObjectiveAssessmentReference != null &&
                    this.ObjectiveAssessmentReference.Equals(input.ObjectiveAssessmentReference))
                ) && 
                (
                    this.AssessmentReportingMethodDescriptor == input.AssessmentReportingMethodDescriptor ||
                    (this.AssessmentReportingMethodDescriptor != null &&
                    this.AssessmentReportingMethodDescriptor.Equals(input.AssessmentReportingMethodDescriptor))
                ) && 
                (
                    this.MaximumScore == input.MaximumScore ||
                    (this.MaximumScore != null &&
                    this.MaximumScore.Equals(input.MaximumScore))
                ) && 
                (
                    this.MinimumScore == input.MinimumScore ||
                    (this.MinimumScore != null &&
                    this.MinimumScore.Equals(input.MinimumScore))
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
                if (this.LearningStandards != null)
                {
                    hashCode = (hashCode * 59) + this.LearningStandards.GetHashCode();
                }
                if (this.ScoreRangeId != null)
                {
                    hashCode = (hashCode * 59) + this.ScoreRangeId.GetHashCode();
                }
                if (this.AssessmentReference != null)
                {
                    hashCode = (hashCode * 59) + this.AssessmentReference.GetHashCode();
                }
                if (this.ObjectiveAssessmentReference != null)
                {
                    hashCode = (hashCode * 59) + this.ObjectiveAssessmentReference.GetHashCode();
                }
                if (this.AssessmentReportingMethodDescriptor != null)
                {
                    hashCode = (hashCode * 59) + this.AssessmentReportingMethodDescriptor.GetHashCode();
                }
                if (this.MaximumScore != null)
                {
                    hashCode = (hashCode * 59) + this.MaximumScore.GetHashCode();
                }
                if (this.MinimumScore != null)
                {
                    hashCode = (hashCode * 59) + this.MinimumScore.GetHashCode();
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
            // ScoreRangeId (string) maxLength
            if (this.ScoreRangeId != null && this.ScoreRangeId.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ScoreRangeId, length must be less than 60.", new [] { "ScoreRangeId" });
            }

            // ScoreRangeId (string) minLength
            if (this.ScoreRangeId != null && this.ScoreRangeId.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ScoreRangeId, length must be greater than 1.", new [] { "ScoreRangeId" });
            }

            // AssessmentReportingMethodDescriptor (string) maxLength
            if (this.AssessmentReportingMethodDescriptor != null && this.AssessmentReportingMethodDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AssessmentReportingMethodDescriptor, length must be less than 306.", new [] { "AssessmentReportingMethodDescriptor" });
            }

            // MaximumScore (string) maxLength
            if (this.MaximumScore != null && this.MaximumScore.Length > 35)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MaximumScore, length must be less than 35.", new [] { "MaximumScore" });
            }

            // MaximumScore (string) minLength
            if (this.MaximumScore != null && this.MaximumScore.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MaximumScore, length must be greater than 1.", new [] { "MaximumScore" });
            }

            // MinimumScore (string) maxLength
            if (this.MinimumScore != null && this.MinimumScore.Length > 35)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MinimumScore, length must be less than 35.", new [] { "MinimumScore" });
            }

            // MinimumScore (string) minLength
            if (this.MinimumScore != null && this.MinimumScore.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MinimumScore, length must be greater than 1.", new [] { "MinimumScore" });
            }

            yield break;
        }
    }

}