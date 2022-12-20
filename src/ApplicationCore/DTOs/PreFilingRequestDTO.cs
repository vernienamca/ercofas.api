using System;
using System.Text.Json.Serialization;

namespace ERCOFAS.ApplicationCore.DTOs
{
    public class PreFilingRequestDTO
    {
        /// <summary>
        /// Gets or sets the pre-filing request identifier.
        /// </summary>
        /// <value>
        /// The pre-filing request identifier.
        /// </value>
        public long Id { get; set; }
        /// <summary>
        /// Gets or sets the pre-filing request subject.
        /// </summary>
        /// <value>
        /// The pre-filing request subject.
        /// </value>
        public string RequestSubject { get; set; }
        /// <summary>
        /// Gets or sets the user identifier.
        /// </summary>
        /// <value>
        /// The user identifier.
        /// </value>
        public long UserId { get; set; }
        /// <summary>
        /// Gets or sets the case type identifier.
        /// </summary>
        /// <value>
        /// The case type identifier.
        /// </value>
        public byte CaseTypeId { get; set; }
        /// <summary>
        /// Gets or sets the case nature identifier.
        /// </summary>
        /// <value>
        /// The case nature identifier.
        /// </value>
        public byte CaseNatureId { get; set; }
        /// <summary>
        /// Gets or sets the pre-filing status identifier.
        /// </summary>
        /// <value>
        /// The pre-filing status identifier.
        /// </value>
        [JsonIgnore]
        public byte PreFilingStatusId { get; set; }
        /// <summary>
        /// Gets or sets the remarks.
        /// </summary>
        /// <value>
        /// The remarks.
        /// </value>
        public string Remarks { get; set; }
        /// <summary>
        /// Gets or sets the date filed.
        /// </summary>
        /// <value>
        /// The date filed.
        /// </value>
        [JsonIgnore]
        public DateTime DateFiled { get; set; }
        /// <summary>
        /// Gets or sets the date updated.
        /// </summary>
        /// <value>
        /// The date updated.
        /// </value>
        [JsonIgnore]
        public DateTime? DateUpdated { get; set; }
    }
}
