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
    /// TrackedChangesEdFiCompetencyObjectiveKey
    /// </summary>
    [DataContract(Name = "trackedChanges_edFi_competencyObjectiveKey")]
    public partial class TrackedChangesEdFiCompetencyObjectiveKey : IEquatable<TrackedChangesEdFiCompetencyObjectiveKey>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrackedChangesEdFiCompetencyObjectiveKey" /> class.
        /// </summary>
        /// <param name="objectiveGradeLevelDescriptor">The grade level for which the competency objective is targeted..</param>
        /// <param name="objective">The designated title of the competency objective..</param>
        /// <param name="educationOrganizationId">The identifier assigned to an education organization..</param>
        public TrackedChangesEdFiCompetencyObjectiveKey(string objectiveGradeLevelDescriptor = default(string), string objective = default(string), long educationOrganizationId = default(long))
        {
            this.ObjectiveGradeLevelDescriptor = objectiveGradeLevelDescriptor;
            this.Objective = objective;
            this.EducationOrganizationId = educationOrganizationId;
        }

        /// <summary>
        /// The grade level for which the competency objective is targeted.
        /// </summary>
        /// <value>The grade level for which the competency objective is targeted.</value>
        [DataMember(Name = "objectiveGradeLevelDescriptor", EmitDefaultValue = false)]
        public string ObjectiveGradeLevelDescriptor { get; set; }

        /// <summary>
        /// The designated title of the competency objective.
        /// </summary>
        /// <value>The designated title of the competency objective.</value>
        [DataMember(Name = "objective", EmitDefaultValue = false)]
        public string Objective { get; set; }

        /// <summary>
        /// The identifier assigned to an education organization.
        /// </summary>
        /// <value>The identifier assigned to an education organization.</value>
        [DataMember(Name = "educationOrganizationId", EmitDefaultValue = false)]
        public long EducationOrganizationId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TrackedChangesEdFiCompetencyObjectiveKey {\n");
            sb.Append("  ObjectiveGradeLevelDescriptor: ").Append(ObjectiveGradeLevelDescriptor).Append("\n");
            sb.Append("  Objective: ").Append(Objective).Append("\n");
            sb.Append("  EducationOrganizationId: ").Append(EducationOrganizationId).Append("\n");
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
            return this.Equals(input as TrackedChangesEdFiCompetencyObjectiveKey);
        }

        /// <summary>
        /// Returns true if TrackedChangesEdFiCompetencyObjectiveKey instances are equal
        /// </summary>
        /// <param name="input">Instance of TrackedChangesEdFiCompetencyObjectiveKey to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrackedChangesEdFiCompetencyObjectiveKey input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ObjectiveGradeLevelDescriptor == input.ObjectiveGradeLevelDescriptor ||
                    (this.ObjectiveGradeLevelDescriptor != null &&
                    this.ObjectiveGradeLevelDescriptor.Equals(input.ObjectiveGradeLevelDescriptor))
                ) && 
                (
                    this.Objective == input.Objective ||
                    (this.Objective != null &&
                    this.Objective.Equals(input.Objective))
                ) && 
                (
                    this.EducationOrganizationId == input.EducationOrganizationId ||
                    this.EducationOrganizationId.Equals(input.EducationOrganizationId)
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
                if (this.ObjectiveGradeLevelDescriptor != null)
                {
                    hashCode = (hashCode * 59) + this.ObjectiveGradeLevelDescriptor.GetHashCode();
                }
                if (this.Objective != null)
                {
                    hashCode = (hashCode * 59) + this.Objective.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.EducationOrganizationId.GetHashCode();
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
            // ObjectiveGradeLevelDescriptor (string) maxLength
            if (this.ObjectiveGradeLevelDescriptor != null && this.ObjectiveGradeLevelDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ObjectiveGradeLevelDescriptor, length must be less than 306.", new [] { "ObjectiveGradeLevelDescriptor" });
            }

            // Objective (string) maxLength
            if (this.Objective != null && this.Objective.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Objective, length must be less than 60.", new [] { "Objective" });
            }

            // Objective (string) minLength
            if (this.Objective != null && this.Objective.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Objective, length must be greater than 1.", new [] { "Objective" });
            }

            yield break;
        }
    }

}
