using System;

namespace ERCOFAS.ApplicationCore.DTOs
{
    public class PreFilingRequestListDTO
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
        /// Gets or sets the full name.
        /// </summary>
        /// <value>
        /// The full name.
        /// </value>
        public string FullName { get; set; }
        /// <summary>
        /// Gets or sets the case type.
        /// </summary>
        /// <value>
        /// The case type.
        /// </value>
        public string CaseType { get; set; }
        /// <summary>
        /// Gets or sets the case nature.
        /// </summary>
        /// <value>
        /// The case nature.
        /// </value>
        public string CaseNature { get; set; }
        /// <summary>
        /// Gets or sets the pre-filing status.
        /// </summary>
        /// <value>
        /// The pre-filing status.
        /// </value>
        public string PreFilingStatus { get; set; }
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
        public DateTime DateFiled { get; set; }
    }
}
