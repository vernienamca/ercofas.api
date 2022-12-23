using System;
using System.Text.Json.Serialization;

namespace ERCOFAS.ApplicationCore.DTOs
{
    public class HearingDTO
    {
        /// <summary>
        /// Gets or sets the hearing request identifier.
        /// </summary>
        /// <value>
        /// The hearing request identifier.
        /// </value>
        public int Id { get; set; }
        /// <summary>
        /// Gets or sets the hearing request description.
        /// </summary>
        /// <value>
        /// The hearing request subject.
        /// </value>
        public string Description { get; set; }
        /// <summary>
        /// Gets or sets the user identifier.
        /// </summary>
        /// <value>
        /// The user identifier.
        /// </value>
        public int? HearingType { get; set; }
        /// <summary>
        /// Gets or sets the hearing schedule.
        /// </summary>
        /// <value>
        /// The hearing schedule.
        /// </value>
        public DateTime? Schedule { get; set; }
        /// <summary>
        /// Gets or sets the hearing meeting link.
        /// </summary>
        /// <value>
        /// The hearing meeting link.
        /// </value>
        public string MeetingLink { get; set; }       
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
