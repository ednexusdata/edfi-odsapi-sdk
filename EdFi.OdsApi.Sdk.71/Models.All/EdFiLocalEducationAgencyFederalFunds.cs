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
    /// EdFiLocalEducationAgencyFederalFunds
    /// </summary>
    [DataContract(Name = "edFi_localEducationAgencyFederalFunds")]
    public partial class EdFiLocalEducationAgencyFederalFunds : IEquatable<EdFiLocalEducationAgencyFederalFunds>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiLocalEducationAgencyFederalFunds" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiLocalEducationAgencyFederalFunds() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiLocalEducationAgencyFederalFunds" /> class.
        /// </summary>
        /// <param name="fiscalYear">The fiscal year for which the federal funds are received. (required).</param>
        /// <param name="innovativeDollarsSpent">The total Title V, Part A funds expended by LEAs..</param>
        /// <param name="innovativeDollarsSpentStrategicPriorities">The total amount of Title V, Part A funds expended by LEAs for the four strategic priorities..</param>
        /// <param name="innovativeProgramsFundsReceived">The total Title V, Part A funds received by LEAs..</param>
        /// <param name="schoolImprovementAllocation">The amount of Section 1003(a) and 1003(g) allocations to LEAs..</param>
        /// <param name="schoolImprovementReservedFundsPercentage">An indication of the percentage of the Title I, Part A allocation that the SEA reserved in accordance with Section 1003(a) of ESEA and 200.100(a) of ED&#39;s regulations governing the reservation of funds for school improvement under Section 1003(a) of ESEA..</param>
        /// <param name="stateAssessmentAdministrationFunding">The percentage of funds used to administer assessments required by Section 1111(b) or to carry out other activities described in Section 6111 and other activities related to ensuring that the state&#39;s schools and LEAs are held accountable for results..</param>
        /// <param name="supplementalEducationalServicesFundsSpent">The dollar amount spent on supplemental educational services during the school year under Title I, Part A, Section 1116 of ESEA as amended..</param>
        /// <param name="supplementalEducationalServicesPerPupilExpenditure">The maximum dollar amount that may be spent per child for expenditures related to supplemental educational services under Title I of the ESEA..</param>
        public EdFiLocalEducationAgencyFederalFunds(int fiscalYear = default(int), double? innovativeDollarsSpent = default(double?), double? innovativeDollarsSpentStrategicPriorities = default(double?), double? innovativeProgramsFundsReceived = default(double?), double? schoolImprovementAllocation = default(double?), double? schoolImprovementReservedFundsPercentage = default(double?), double? stateAssessmentAdministrationFunding = default(double?), double? supplementalEducationalServicesFundsSpent = default(double?), double? supplementalEducationalServicesPerPupilExpenditure = default(double?))
        {
            this.FiscalYear = fiscalYear;
            this.InnovativeDollarsSpent = innovativeDollarsSpent;
            this.InnovativeDollarsSpentStrategicPriorities = innovativeDollarsSpentStrategicPriorities;
            this.InnovativeProgramsFundsReceived = innovativeProgramsFundsReceived;
            this.SchoolImprovementAllocation = schoolImprovementAllocation;
            this.SchoolImprovementReservedFundsPercentage = schoolImprovementReservedFundsPercentage;
            this.StateAssessmentAdministrationFunding = stateAssessmentAdministrationFunding;
            this.SupplementalEducationalServicesFundsSpent = supplementalEducationalServicesFundsSpent;
            this.SupplementalEducationalServicesPerPupilExpenditure = supplementalEducationalServicesPerPupilExpenditure;
        }

        /// <summary>
        /// The fiscal year for which the federal funds are received.
        /// </summary>
        /// <value>The fiscal year for which the federal funds are received.</value>
        [DataMember(Name = "fiscalYear", IsRequired = true, EmitDefaultValue = true)]
        public int FiscalYear { get; set; }

        /// <summary>
        /// The total Title V, Part A funds expended by LEAs.
        /// </summary>
        /// <value>The total Title V, Part A funds expended by LEAs.</value>
        [DataMember(Name = "innovativeDollarsSpent", EmitDefaultValue = true)]
        public double? InnovativeDollarsSpent { get; set; }

        /// <summary>
        /// The total amount of Title V, Part A funds expended by LEAs for the four strategic priorities.
        /// </summary>
        /// <value>The total amount of Title V, Part A funds expended by LEAs for the four strategic priorities.</value>
        [DataMember(Name = "innovativeDollarsSpentStrategicPriorities", EmitDefaultValue = true)]
        public double? InnovativeDollarsSpentStrategicPriorities { get; set; }

        /// <summary>
        /// The total Title V, Part A funds received by LEAs.
        /// </summary>
        /// <value>The total Title V, Part A funds received by LEAs.</value>
        [DataMember(Name = "innovativeProgramsFundsReceived", EmitDefaultValue = true)]
        public double? InnovativeProgramsFundsReceived { get; set; }

        /// <summary>
        /// The amount of Section 1003(a) and 1003(g) allocations to LEAs.
        /// </summary>
        /// <value>The amount of Section 1003(a) and 1003(g) allocations to LEAs.</value>
        [DataMember(Name = "schoolImprovementAllocation", EmitDefaultValue = true)]
        public double? SchoolImprovementAllocation { get; set; }

        /// <summary>
        /// An indication of the percentage of the Title I, Part A allocation that the SEA reserved in accordance with Section 1003(a) of ESEA and 200.100(a) of ED&#39;s regulations governing the reservation of funds for school improvement under Section 1003(a) of ESEA.
        /// </summary>
        /// <value>An indication of the percentage of the Title I, Part A allocation that the SEA reserved in accordance with Section 1003(a) of ESEA and 200.100(a) of ED&#39;s regulations governing the reservation of funds for school improvement under Section 1003(a) of ESEA.</value>
        [DataMember(Name = "schoolImprovementReservedFundsPercentage", EmitDefaultValue = true)]
        public double? SchoolImprovementReservedFundsPercentage { get; set; }

        /// <summary>
        /// The percentage of funds used to administer assessments required by Section 1111(b) or to carry out other activities described in Section 6111 and other activities related to ensuring that the state&#39;s schools and LEAs are held accountable for results.
        /// </summary>
        /// <value>The percentage of funds used to administer assessments required by Section 1111(b) or to carry out other activities described in Section 6111 and other activities related to ensuring that the state&#39;s schools and LEAs are held accountable for results.</value>
        [DataMember(Name = "stateAssessmentAdministrationFunding", EmitDefaultValue = true)]
        public double? StateAssessmentAdministrationFunding { get; set; }

        /// <summary>
        /// The dollar amount spent on supplemental educational services during the school year under Title I, Part A, Section 1116 of ESEA as amended.
        /// </summary>
        /// <value>The dollar amount spent on supplemental educational services during the school year under Title I, Part A, Section 1116 of ESEA as amended.</value>
        [DataMember(Name = "supplementalEducationalServicesFundsSpent", EmitDefaultValue = true)]
        public double? SupplementalEducationalServicesFundsSpent { get; set; }

        /// <summary>
        /// The maximum dollar amount that may be spent per child for expenditures related to supplemental educational services under Title I of the ESEA.
        /// </summary>
        /// <value>The maximum dollar amount that may be spent per child for expenditures related to supplemental educational services under Title I of the ESEA.</value>
        [DataMember(Name = "supplementalEducationalServicesPerPupilExpenditure", EmitDefaultValue = true)]
        public double? SupplementalEducationalServicesPerPupilExpenditure { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EdFiLocalEducationAgencyFederalFunds {\n");
            sb.Append("  FiscalYear: ").Append(FiscalYear).Append("\n");
            sb.Append("  InnovativeDollarsSpent: ").Append(InnovativeDollarsSpent).Append("\n");
            sb.Append("  InnovativeDollarsSpentStrategicPriorities: ").Append(InnovativeDollarsSpentStrategicPriorities).Append("\n");
            sb.Append("  InnovativeProgramsFundsReceived: ").Append(InnovativeProgramsFundsReceived).Append("\n");
            sb.Append("  SchoolImprovementAllocation: ").Append(SchoolImprovementAllocation).Append("\n");
            sb.Append("  SchoolImprovementReservedFundsPercentage: ").Append(SchoolImprovementReservedFundsPercentage).Append("\n");
            sb.Append("  StateAssessmentAdministrationFunding: ").Append(StateAssessmentAdministrationFunding).Append("\n");
            sb.Append("  SupplementalEducationalServicesFundsSpent: ").Append(SupplementalEducationalServicesFundsSpent).Append("\n");
            sb.Append("  SupplementalEducationalServicesPerPupilExpenditure: ").Append(SupplementalEducationalServicesPerPupilExpenditure).Append("\n");
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
            return this.Equals(input as EdFiLocalEducationAgencyFederalFunds);
        }

        /// <summary>
        /// Returns true if EdFiLocalEducationAgencyFederalFunds instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiLocalEducationAgencyFederalFunds to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiLocalEducationAgencyFederalFunds input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.FiscalYear == input.FiscalYear ||
                    this.FiscalYear.Equals(input.FiscalYear)
                ) && 
                (
                    this.InnovativeDollarsSpent == input.InnovativeDollarsSpent ||
                    (this.InnovativeDollarsSpent != null &&
                    this.InnovativeDollarsSpent.Equals(input.InnovativeDollarsSpent))
                ) && 
                (
                    this.InnovativeDollarsSpentStrategicPriorities == input.InnovativeDollarsSpentStrategicPriorities ||
                    (this.InnovativeDollarsSpentStrategicPriorities != null &&
                    this.InnovativeDollarsSpentStrategicPriorities.Equals(input.InnovativeDollarsSpentStrategicPriorities))
                ) && 
                (
                    this.InnovativeProgramsFundsReceived == input.InnovativeProgramsFundsReceived ||
                    (this.InnovativeProgramsFundsReceived != null &&
                    this.InnovativeProgramsFundsReceived.Equals(input.InnovativeProgramsFundsReceived))
                ) && 
                (
                    this.SchoolImprovementAllocation == input.SchoolImprovementAllocation ||
                    (this.SchoolImprovementAllocation != null &&
                    this.SchoolImprovementAllocation.Equals(input.SchoolImprovementAllocation))
                ) && 
                (
                    this.SchoolImprovementReservedFundsPercentage == input.SchoolImprovementReservedFundsPercentage ||
                    (this.SchoolImprovementReservedFundsPercentage != null &&
                    this.SchoolImprovementReservedFundsPercentage.Equals(input.SchoolImprovementReservedFundsPercentage))
                ) && 
                (
                    this.StateAssessmentAdministrationFunding == input.StateAssessmentAdministrationFunding ||
                    (this.StateAssessmentAdministrationFunding != null &&
                    this.StateAssessmentAdministrationFunding.Equals(input.StateAssessmentAdministrationFunding))
                ) && 
                (
                    this.SupplementalEducationalServicesFundsSpent == input.SupplementalEducationalServicesFundsSpent ||
                    (this.SupplementalEducationalServicesFundsSpent != null &&
                    this.SupplementalEducationalServicesFundsSpent.Equals(input.SupplementalEducationalServicesFundsSpent))
                ) && 
                (
                    this.SupplementalEducationalServicesPerPupilExpenditure == input.SupplementalEducationalServicesPerPupilExpenditure ||
                    (this.SupplementalEducationalServicesPerPupilExpenditure != null &&
                    this.SupplementalEducationalServicesPerPupilExpenditure.Equals(input.SupplementalEducationalServicesPerPupilExpenditure))
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
                hashCode = (hashCode * 59) + this.FiscalYear.GetHashCode();
                if (this.InnovativeDollarsSpent != null)
                {
                    hashCode = (hashCode * 59) + this.InnovativeDollarsSpent.GetHashCode();
                }
                if (this.InnovativeDollarsSpentStrategicPriorities != null)
                {
                    hashCode = (hashCode * 59) + this.InnovativeDollarsSpentStrategicPriorities.GetHashCode();
                }
                if (this.InnovativeProgramsFundsReceived != null)
                {
                    hashCode = (hashCode * 59) + this.InnovativeProgramsFundsReceived.GetHashCode();
                }
                if (this.SchoolImprovementAllocation != null)
                {
                    hashCode = (hashCode * 59) + this.SchoolImprovementAllocation.GetHashCode();
                }
                if (this.SchoolImprovementReservedFundsPercentage != null)
                {
                    hashCode = (hashCode * 59) + this.SchoolImprovementReservedFundsPercentage.GetHashCode();
                }
                if (this.StateAssessmentAdministrationFunding != null)
                {
                    hashCode = (hashCode * 59) + this.StateAssessmentAdministrationFunding.GetHashCode();
                }
                if (this.SupplementalEducationalServicesFundsSpent != null)
                {
                    hashCode = (hashCode * 59) + this.SupplementalEducationalServicesFundsSpent.GetHashCode();
                }
                if (this.SupplementalEducationalServicesPerPupilExpenditure != null)
                {
                    hashCode = (hashCode * 59) + this.SupplementalEducationalServicesPerPupilExpenditure.GetHashCode();
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
