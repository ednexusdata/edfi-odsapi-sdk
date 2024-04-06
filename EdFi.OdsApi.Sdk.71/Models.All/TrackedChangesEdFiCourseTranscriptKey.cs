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
    /// TrackedChangesEdFiCourseTranscriptKey
    /// </summary>
    [DataContract(Name = "trackedChanges_edFi_courseTranscriptKey")]
    public partial class TrackedChangesEdFiCourseTranscriptKey : IEquatable<TrackedChangesEdFiCourseTranscriptKey>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrackedChangesEdFiCourseTranscriptKey" /> class.
        /// </summary>
        /// <param name="courseAttemptResultDescriptor">The result from the student&#39;s attempt to take the course..</param>
        /// <param name="courseCode">A unique alphanumeric code assigned to a course..</param>
        /// <param name="courseEducationOrganizationId">The identifier assigned to an education organization..</param>
        /// <param name="educationOrganizationId">The identifier assigned to an education organization..</param>
        /// <param name="schoolYear">The identifier for the school year..</param>
        /// <param name="studentUniqueId">A unique alphanumeric code assigned to a student..</param>
        /// <param name="termDescriptor">The term for the session during the school year..</param>
        public TrackedChangesEdFiCourseTranscriptKey(string courseAttemptResultDescriptor = default(string), string courseCode = default(string), long courseEducationOrganizationId = default(long), long educationOrganizationId = default(long), int schoolYear = default(int), string studentUniqueId = default(string), string termDescriptor = default(string))
        {
            this.CourseAttemptResultDescriptor = courseAttemptResultDescriptor;
            this.CourseCode = courseCode;
            this.CourseEducationOrganizationId = courseEducationOrganizationId;
            this.EducationOrganizationId = educationOrganizationId;
            this.SchoolYear = schoolYear;
            this.StudentUniqueId = studentUniqueId;
            this.TermDescriptor = termDescriptor;
        }

        /// <summary>
        /// The result from the student&#39;s attempt to take the course.
        /// </summary>
        /// <value>The result from the student&#39;s attempt to take the course.</value>
        [DataMember(Name = "courseAttemptResultDescriptor", EmitDefaultValue = false)]
        public string CourseAttemptResultDescriptor { get; set; }

        /// <summary>
        /// A unique alphanumeric code assigned to a course.
        /// </summary>
        /// <value>A unique alphanumeric code assigned to a course.</value>
        [DataMember(Name = "courseCode", EmitDefaultValue = false)]
        public string CourseCode { get; set; }

        /// <summary>
        /// The identifier assigned to an education organization.
        /// </summary>
        /// <value>The identifier assigned to an education organization.</value>
        [DataMember(Name = "courseEducationOrganizationId", EmitDefaultValue = false)]
        public long CourseEducationOrganizationId { get; set; }

        /// <summary>
        /// The identifier assigned to an education organization.
        /// </summary>
        /// <value>The identifier assigned to an education organization.</value>
        [DataMember(Name = "educationOrganizationId", EmitDefaultValue = false)]
        public long EducationOrganizationId { get; set; }

        /// <summary>
        /// The identifier for the school year.
        /// </summary>
        /// <value>The identifier for the school year.</value>
        [DataMember(Name = "schoolYear", EmitDefaultValue = false)]
        public int SchoolYear { get; set; }

        /// <summary>
        /// A unique alphanumeric code assigned to a student.
        /// </summary>
        /// <value>A unique alphanumeric code assigned to a student.</value>
        [DataMember(Name = "studentUniqueId", EmitDefaultValue = false)]
        public string StudentUniqueId { get; set; }

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
            sb.Append("class TrackedChangesEdFiCourseTranscriptKey {\n");
            sb.Append("  CourseAttemptResultDescriptor: ").Append(CourseAttemptResultDescriptor).Append("\n");
            sb.Append("  CourseCode: ").Append(CourseCode).Append("\n");
            sb.Append("  CourseEducationOrganizationId: ").Append(CourseEducationOrganizationId).Append("\n");
            sb.Append("  EducationOrganizationId: ").Append(EducationOrganizationId).Append("\n");
            sb.Append("  SchoolYear: ").Append(SchoolYear).Append("\n");
            sb.Append("  StudentUniqueId: ").Append(StudentUniqueId).Append("\n");
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
            return this.Equals(input as TrackedChangesEdFiCourseTranscriptKey);
        }

        /// <summary>
        /// Returns true if TrackedChangesEdFiCourseTranscriptKey instances are equal
        /// </summary>
        /// <param name="input">Instance of TrackedChangesEdFiCourseTranscriptKey to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrackedChangesEdFiCourseTranscriptKey input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CourseAttemptResultDescriptor == input.CourseAttemptResultDescriptor ||
                    (this.CourseAttemptResultDescriptor != null &&
                    this.CourseAttemptResultDescriptor.Equals(input.CourseAttemptResultDescriptor))
                ) && 
                (
                    this.CourseCode == input.CourseCode ||
                    (this.CourseCode != null &&
                    this.CourseCode.Equals(input.CourseCode))
                ) && 
                (
                    this.CourseEducationOrganizationId == input.CourseEducationOrganizationId ||
                    this.CourseEducationOrganizationId.Equals(input.CourseEducationOrganizationId)
                ) && 
                (
                    this.EducationOrganizationId == input.EducationOrganizationId ||
                    this.EducationOrganizationId.Equals(input.EducationOrganizationId)
                ) && 
                (
                    this.SchoolYear == input.SchoolYear ||
                    this.SchoolYear.Equals(input.SchoolYear)
                ) && 
                (
                    this.StudentUniqueId == input.StudentUniqueId ||
                    (this.StudentUniqueId != null &&
                    this.StudentUniqueId.Equals(input.StudentUniqueId))
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
                if (this.CourseAttemptResultDescriptor != null)
                {
                    hashCode = (hashCode * 59) + this.CourseAttemptResultDescriptor.GetHashCode();
                }
                if (this.CourseCode != null)
                {
                    hashCode = (hashCode * 59) + this.CourseCode.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.CourseEducationOrganizationId.GetHashCode();
                hashCode = (hashCode * 59) + this.EducationOrganizationId.GetHashCode();
                hashCode = (hashCode * 59) + this.SchoolYear.GetHashCode();
                if (this.StudentUniqueId != null)
                {
                    hashCode = (hashCode * 59) + this.StudentUniqueId.GetHashCode();
                }
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
            // CourseAttemptResultDescriptor (string) maxLength
            if (this.CourseAttemptResultDescriptor != null && this.CourseAttemptResultDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CourseAttemptResultDescriptor, length must be less than 306.", new [] { "CourseAttemptResultDescriptor" });
            }

            // CourseCode (string) maxLength
            if (this.CourseCode != null && this.CourseCode.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CourseCode, length must be less than 60.", new [] { "CourseCode" });
            }

            // CourseCode (string) minLength
            if (this.CourseCode != null && this.CourseCode.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CourseCode, length must be greater than 1.", new [] { "CourseCode" });
            }

            // StudentUniqueId (string) maxLength
            if (this.StudentUniqueId != null && this.StudentUniqueId.Length > 32)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for StudentUniqueId, length must be less than 32.", new [] { "StudentUniqueId" });
            }

            // StudentUniqueId (string) minLength
            if (this.StudentUniqueId != null && this.StudentUniqueId.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for StudentUniqueId, length must be greater than 1.", new [] { "StudentUniqueId" });
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
