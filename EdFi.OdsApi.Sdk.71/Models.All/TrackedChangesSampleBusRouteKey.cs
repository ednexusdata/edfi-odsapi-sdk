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
    /// TrackedChangesSampleBusRouteKey
    /// </summary>
    [DataContract(Name = "trackedChanges_sample_busRouteKey")]
    public partial class TrackedChangesSampleBusRouteKey : IEquatable<TrackedChangesSampleBusRouteKey>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrackedChangesSampleBusRouteKey" /> class.
        /// </summary>
        /// <param name="busId">The unique identifier for the bus assigned to the bus route..</param>
        /// <param name="busRouteNumber">A unique identifier for the bus route..</param>
        public TrackedChangesSampleBusRouteKey(string busId = default(string), int busRouteNumber = default(int))
        {
            this.BusId = busId;
            this.BusRouteNumber = busRouteNumber;
        }

        /// <summary>
        /// The unique identifier for the bus assigned to the bus route.
        /// </summary>
        /// <value>The unique identifier for the bus assigned to the bus route.</value>
        [DataMember(Name = "busId", EmitDefaultValue = false)]
        public string BusId { get; set; }

        /// <summary>
        /// A unique identifier for the bus route.
        /// </summary>
        /// <value>A unique identifier for the bus route.</value>
        [DataMember(Name = "busRouteNumber", EmitDefaultValue = false)]
        public int BusRouteNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TrackedChangesSampleBusRouteKey {\n");
            sb.Append("  BusId: ").Append(BusId).Append("\n");
            sb.Append("  BusRouteNumber: ").Append(BusRouteNumber).Append("\n");
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
            return this.Equals(input as TrackedChangesSampleBusRouteKey);
        }

        /// <summary>
        /// Returns true if TrackedChangesSampleBusRouteKey instances are equal
        /// </summary>
        /// <param name="input">Instance of TrackedChangesSampleBusRouteKey to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrackedChangesSampleBusRouteKey input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BusId == input.BusId ||
                    (this.BusId != null &&
                    this.BusId.Equals(input.BusId))
                ) && 
                (
                    this.BusRouteNumber == input.BusRouteNumber ||
                    this.BusRouteNumber.Equals(input.BusRouteNumber)
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
                if (this.BusId != null)
                {
                    hashCode = (hashCode * 59) + this.BusId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.BusRouteNumber.GetHashCode();
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
            // BusId (string) maxLength
            if (this.BusId != null && this.BusId.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for BusId, length must be less than 60.", new [] { "BusId" });
            }

            // BusId (string) minLength
            if (this.BusId != null && this.BusId.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for BusId, length must be greater than 1.", new [] { "BusId" });
            }

            yield break;
        }
    }

}
