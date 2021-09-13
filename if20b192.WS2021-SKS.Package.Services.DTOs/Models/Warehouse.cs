/*
 * Parcel Logistics Service
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 1.20.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace if20b192.WS2021_SKS.Package.Services.DTOs.Models
{ 
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class Warehouse
    { 
        /// <summary>
        /// Gets or Sets Level
        /// </summary>
        [Required]

        [DataMember(Name="level")]
        public int? Level { get; set; }

        /// <summary>
        /// Next hops after this warehouse (warehouses or trucks).
        /// </summary>
        /// <value>Next hops after this warehouse (warehouses or trucks).</value>
        [Required]

        [DataMember(Name="nextHops")]
        public List<WarehouseNextHops> NextHops { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Warehouse {\n");
            sb.Append("  Level: ").Append(Level).Append("\n");
            sb.Append("  NextHops: ").Append(NextHops).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public  new string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((Warehouse)obj);
        }

        /// <summary>
        /// Returns true if Warehouse instances are equal
        /// </summary>
        /// <param name="other">Instance of Warehouse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Warehouse other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Level == other.Level ||
                    Level != null &&
                    Level.Equals(other.Level)
                ) && 
                (
                    NextHops == other.NextHops ||
                    NextHops != null &&
                    NextHops.SequenceEqual(other.NextHops)
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
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (Level != null)
                    hashCode = hashCode * 59 + Level.GetHashCode();
                    if (NextHops != null)
                    hashCode = hashCode * 59 + NextHops.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Warehouse left, Warehouse right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Warehouse left, Warehouse right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}