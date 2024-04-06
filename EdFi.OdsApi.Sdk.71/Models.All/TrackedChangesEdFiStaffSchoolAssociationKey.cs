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
    /// TrackedChangesEdFiStaffSchoolAssociationKey
    /// </summary>
    [DataContract(Name = "trackedChanges_edFi_staffSchoolAssociationKey")]
    public partial class TrackedChangesEdFiStaffSchoolAssociationKey : IEquatable<TrackedChangesEdFiStaffSchoolAssociationKey>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrackedChangesEdFiStaffSchoolAssociationKey" /> class.
        /// </summary>
        /// <param name="programAssignmentDescriptor">The name of the program for which the individual is assigned..</param>
        /// <param name="schoolId">The identifier assigned to a school..</param>
        /// <param name="staffUniqueId">A unique alphanumeric code assigned to a staff..</param>
        public TrackedChangesEdFiStaffSchoolAssociationKey(string programAssignmentDescriptor = default(string), long schoolId = default(long), string staffUniqueId = default(string))
        {
            this.ProgramAssignmentDescriptor = programAssignmentDescriptor;
            this.SchoolId = schoolId;
            this.StaffUniqueId = staffUniqueId;
        }

        /// <summary>
        /// The name of the program for which the individual is assigned.
        /// </summary>
        /// <value>The name of the program for which the individual is assigned.</value>
        [DataMember(Name = "programAssignmentDescriptor", EmitDefaultValue = false)]
        public string ProgramAssignmentDescriptor { get; set; }

        /// <summary>
        /// The identifier assigned to a school.
        /// </summary>
        /// <value>The identifier assigned to a school.</value>
        [DataMember(Name = "schoolId", EmitDefaultValue = false)]
        public long SchoolId { get; set; }

        /// <summary>
        /// A unique alphanumeric code assigned to a staff.
        /// </summary>
        /// <value>A unique alphanumeric code assigned to a staff.</value>
        [DataMember(Name = "staffUniqueId", EmitDefaultValue = false)]
        public string StaffUniqueId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TrackedChangesEdFiStaffSchoolAssociationKey {\n");
            sb.Append("  ProgramAssignmentDescriptor: ").Append(ProgramAssignmentDescriptor).Append("\n");
            sb.Append("  SchoolId: ").Append(SchoolId).Append("\n");
            sb.Append("  StaffUniqueId: ").Append(StaffUniqueId).Append("\n");
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
            return this.Equals(input as TrackedChangesEdFiStaffSchoolAssociationKey);
        }

        /// <summary>
        /// Returns true if TrackedChangesEdFiStaffSchoolAssociationKey instances are equal
        /// </summary>
        /// <param name="input">Instance of TrackedChangesEdFiStaffSchoolAssociationKey to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrackedChangesEdFiStaffSchoolAssociationKey input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ProgramAssignmentDescriptor == input.ProgramAssignmentDescriptor ||
                    (this.ProgramAssignmentDescriptor != null &&
                    this.ProgramAssignmentDescriptor.Equals(input.ProgramAssignmentDescriptor))
                ) && 
                (
                    this.SchoolId == input.SchoolId ||
                    this.SchoolId.Equals(input.SchoolId)
                ) && 
                (
                    this.StaffUniqueId == input.StaffUniqueId ||
                    (this.StaffUniqueId != null &&
                    this.StaffUniqueId.Equals(input.StaffUniqueId))
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
                if (this.ProgramAssignmentDescriptor != null)
                {
                    hashCode = (hashCode * 59) + this.ProgramAssignmentDescriptor.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SchoolId.GetHashCode();
                if (this.StaffUniqueId != null)
                {
                    hashCode = (hashCode * 59) + this.StaffUniqueId.GetHashCode();
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
            // ProgramAssignmentDescriptor (string) maxLength
            if (this.ProgramAssignmentDescriptor != null && this.ProgramAssignmentDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ProgramAssignmentDescriptor, length must be less than 306.", new [] { "ProgramAssignmentDescriptor" });
            }

            // StaffUniqueId (string) maxLength
            if (this.StaffUniqueId != null && this.StaffUniqueId.Length > 32)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for StaffUniqueId, length must be less than 32.", new [] { "StaffUniqueId" });
            }

            // StaffUniqueId (string) minLength
            if (this.StaffUniqueId != null && this.StaffUniqueId.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for StaffUniqueId, length must be greater than 1.", new [] { "StaffUniqueId" });
            }

            yield break;
        }
    }

}