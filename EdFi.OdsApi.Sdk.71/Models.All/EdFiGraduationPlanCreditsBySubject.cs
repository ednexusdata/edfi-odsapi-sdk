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
    /// EdFiGraduationPlanCreditsBySubject
    /// </summary>
    [DataContract(Name = "edFi_graduationPlanCreditsBySubject")]
    public partial class EdFiGraduationPlanCreditsBySubject : IEquatable<EdFiGraduationPlanCreditsBySubject>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiGraduationPlanCreditsBySubject" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiGraduationPlanCreditsBySubject() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiGraduationPlanCreditsBySubject" /> class.
        /// </summary>
        /// <param name="academicSubjectDescriptor">The intended major subject area of the graduation requirement. (required).</param>
        /// <param name="creditTypeDescriptor">The type of credits or units of value awarded for the completion of a course..</param>
        /// <param name="creditConversion">Conversion factor that when multiplied by the number of credits is equivalent to Carnegie units..</param>
        /// <param name="credits">The value of credits or units of value awarded for the completion of a course. (required).</param>
        public EdFiGraduationPlanCreditsBySubject(string academicSubjectDescriptor = default(string), string creditTypeDescriptor = default(string), double? creditConversion = default(double?), double credits = default(double))
        {
            // to ensure "academicSubjectDescriptor" is required (not null)
            if (academicSubjectDescriptor == null)
            {
                throw new ArgumentNullException("academicSubjectDescriptor is a required property for EdFiGraduationPlanCreditsBySubject and cannot be null");
            }
            this.AcademicSubjectDescriptor = academicSubjectDescriptor;
            this.Credits = credits;
            this.CreditTypeDescriptor = creditTypeDescriptor;
            this.CreditConversion = creditConversion;
        }

        /// <summary>
        /// The intended major subject area of the graduation requirement.
        /// </summary>
        /// <value>The intended major subject area of the graduation requirement.</value>
        [DataMember(Name = "academicSubjectDescriptor", IsRequired = true, EmitDefaultValue = true)]
        public string AcademicSubjectDescriptor { get; set; }

        /// <summary>
        /// The type of credits or units of value awarded for the completion of a course.
        /// </summary>
        /// <value>The type of credits or units of value awarded for the completion of a course.</value>
        [DataMember(Name = "creditTypeDescriptor", EmitDefaultValue = true)]
        public string CreditTypeDescriptor { get; set; }

        /// <summary>
        /// Conversion factor that when multiplied by the number of credits is equivalent to Carnegie units.
        /// </summary>
        /// <value>Conversion factor that when multiplied by the number of credits is equivalent to Carnegie units.</value>
        [DataMember(Name = "creditConversion", EmitDefaultValue = true)]
        public double? CreditConversion { get; set; }

        /// <summary>
        /// The value of credits or units of value awarded for the completion of a course.
        /// </summary>
        /// <value>The value of credits or units of value awarded for the completion of a course.</value>
        [DataMember(Name = "credits", IsRequired = true, EmitDefaultValue = true)]
        public double Credits { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EdFiGraduationPlanCreditsBySubject {\n");
            sb.Append("  AcademicSubjectDescriptor: ").Append(AcademicSubjectDescriptor).Append("\n");
            sb.Append("  CreditTypeDescriptor: ").Append(CreditTypeDescriptor).Append("\n");
            sb.Append("  CreditConversion: ").Append(CreditConversion).Append("\n");
            sb.Append("  Credits: ").Append(Credits).Append("\n");
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
            return this.Equals(input as EdFiGraduationPlanCreditsBySubject);
        }

        /// <summary>
        /// Returns true if EdFiGraduationPlanCreditsBySubject instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiGraduationPlanCreditsBySubject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiGraduationPlanCreditsBySubject input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AcademicSubjectDescriptor == input.AcademicSubjectDescriptor ||
                    (this.AcademicSubjectDescriptor != null &&
                    this.AcademicSubjectDescriptor.Equals(input.AcademicSubjectDescriptor))
                ) && 
                (
                    this.CreditTypeDescriptor == input.CreditTypeDescriptor ||
                    (this.CreditTypeDescriptor != null &&
                    this.CreditTypeDescriptor.Equals(input.CreditTypeDescriptor))
                ) && 
                (
                    this.CreditConversion == input.CreditConversion ||
                    (this.CreditConversion != null &&
                    this.CreditConversion.Equals(input.CreditConversion))
                ) && 
                (
                    this.Credits == input.Credits ||
                    this.Credits.Equals(input.Credits)
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
                if (this.AcademicSubjectDescriptor != null)
                {
                    hashCode = (hashCode * 59) + this.AcademicSubjectDescriptor.GetHashCode();
                }
                if (this.CreditTypeDescriptor != null)
                {
                    hashCode = (hashCode * 59) + this.CreditTypeDescriptor.GetHashCode();
                }
                if (this.CreditConversion != null)
                {
                    hashCode = (hashCode * 59) + this.CreditConversion.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Credits.GetHashCode();
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
            // AcademicSubjectDescriptor (string) maxLength
            if (this.AcademicSubjectDescriptor != null && this.AcademicSubjectDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AcademicSubjectDescriptor, length must be less than 306.", new [] { "AcademicSubjectDescriptor" });
            }

            // CreditTypeDescriptor (string) maxLength
            if (this.CreditTypeDescriptor != null && this.CreditTypeDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CreditTypeDescriptor, length must be less than 306.", new [] { "CreditTypeDescriptor" });
            }

            // Credits (double) minimum
            if (this.Credits < (double)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Credits, must be a value greater than or equal to 0.", new [] { "Credits" });
            }

            yield break;
        }
    }

}
