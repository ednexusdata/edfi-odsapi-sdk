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
    /// EdFiDisciplineIncidentWeapon
    /// </summary>
    [DataContract(Name = "edFi_disciplineIncidentWeapon")]
    public partial class EdFiDisciplineIncidentWeapon : IEquatable<EdFiDisciplineIncidentWeapon>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiDisciplineIncidentWeapon" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiDisciplineIncidentWeapon() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiDisciplineIncidentWeapon" /> class.
        /// </summary>
        /// <param name="weaponDescriptor">Identifies the type of weapon used during an incident. The Federal Gun-Free Schools Act requires states to report the number of students expelled for bringing firearms to school by type of firearm. (required).</param>
        public EdFiDisciplineIncidentWeapon(string weaponDescriptor = default(string))
        {
            // to ensure "weaponDescriptor" is required (not null)
            if (weaponDescriptor == null)
            {
                throw new ArgumentNullException("weaponDescriptor is a required property for EdFiDisciplineIncidentWeapon and cannot be null");
            }
            this.WeaponDescriptor = weaponDescriptor;
        }

        /// <summary>
        /// Identifies the type of weapon used during an incident. The Federal Gun-Free Schools Act requires states to report the number of students expelled for bringing firearms to school by type of firearm.
        /// </summary>
        /// <value>Identifies the type of weapon used during an incident. The Federal Gun-Free Schools Act requires states to report the number of students expelled for bringing firearms to school by type of firearm.</value>
        [DataMember(Name = "weaponDescriptor", IsRequired = true, EmitDefaultValue = true)]
        public string WeaponDescriptor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EdFiDisciplineIncidentWeapon {\n");
            sb.Append("  WeaponDescriptor: ").Append(WeaponDescriptor).Append("\n");
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
            return this.Equals(input as EdFiDisciplineIncidentWeapon);
        }

        /// <summary>
        /// Returns true if EdFiDisciplineIncidentWeapon instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiDisciplineIncidentWeapon to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiDisciplineIncidentWeapon input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.WeaponDescriptor == input.WeaponDescriptor ||
                    (this.WeaponDescriptor != null &&
                    this.WeaponDescriptor.Equals(input.WeaponDescriptor))
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
                if (this.WeaponDescriptor != null)
                {
                    hashCode = (hashCode * 59) + this.WeaponDescriptor.GetHashCode();
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
            // WeaponDescriptor (string) maxLength
            if (this.WeaponDescriptor != null && this.WeaponDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for WeaponDescriptor, length must be less than 306.", new [] { "WeaponDescriptor" });
            }

            yield break;
        }
    }

}
