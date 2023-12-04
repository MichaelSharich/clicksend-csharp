/* 
 * ClickSend v3 API
 *
 *  This is an official SDK for [ClickSend](https://clicksend.com)  Below you will find a current list of the available methods for clicksend.  *NOTE: You will need to create a free account to use the API. You can register [here](https://dashboard.clicksend.com/#/signup/step1/)..* 
 *
 * OpenAPI spec version: 3.1
 * Contact: support@clicksend.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using JsonSubTypes;
using System.ComponentModel.DataAnnotations;
using ClickSendDateConverter = IO.ClickSend.Client.ClickSendDateConverter;
namespace IO.ClickSend.ClickSend.Model
{
    /// <summary>
    /// All dates before specified timestamp.
    /// </summary>
    [DataContract]
    [JsonConverter(typeof(JsonSubtypes), "ClassType")]
        public partial class DateBefore :  IEquatable<DateBefore>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DateBefore" /> class.
        /// </summary>
        /// <param name="dateBefore">An optional timestamp - mark all as read before this timestamp. If not given, all messages will be marked as read..</param>
        public DateBefore(decimal? dateBefore = default(decimal?))
        {
            this._DateBefore = dateBefore;
        }
        
        /// <summary>
        /// An optional timestamp - mark all as read before this timestamp. If not given, all messages will be marked as read.
        /// </summary>
        /// <value>An optional timestamp - mark all as read before this timestamp. If not given, all messages will be marked as read.</value>
        [DataMember(Name="date_before", EmitDefaultValue=false)]
        public decimal? _DateBefore { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DateBefore {\n");
            sb.Append("  _DateBefore: ").Append(_DateBefore).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as DateBefore);
        }

        /// <summary>
        /// Returns true if DateBefore instances are equal
        /// </summary>
        /// <param name="input">Instance of DateBefore to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DateBefore input)
        {
            if (input == null)
                return false;

            return 
                (
                    this._DateBefore == input._DateBefore ||
                    (this._DateBefore != null &&
                    this._DateBefore.Equals(input._DateBefore))
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
                if (this._DateBefore != null)
                    hashCode = hashCode * 59 + this._DateBefore.GetHashCode();
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
            return this.BaseValidate(validationContext);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        protected IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> BaseValidate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
