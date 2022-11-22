using System;
using System.Runtime.Serialization;

namespace ERCOFAS.ApplicationCore.Entities.Structure
{
    public class Settings : BaseEntity<int>
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string CompanyName { get; set; }

        [DataMember]
        public string EmailAddress { get; set; }

        [DataMember]
        public string PhoneNumber { get; set; }

        [DataMember]
        public string MobileNumber { get; set; }

        [DataMember]
        public string Address { get; set; }

        [DataMember]
        public string AboutUs { get; set; }

        [DataMember]
        public string Website { get; set; }

        [DataMember]
        public string ERNumberPrefix { get; set; }

        [DataMember]
        public string SMTPFromEmail { get; set; }

        [DataMember]
        public string SMTPFromName { get; set; }

        [DataMember]
        public string SMTPUsername { get; set; }

        [DataMember]
        public string SMTPPassword { get; set; }

        [DataMember]
        public string SMTPServerName { get; set; }

        [DataMember]
        public int SMTPPort { get; set; }

        [DataMember]
        public bool? EnableSSL { get; set; }

        [DataMember]
        public string OTPAPIKey { get; set; }

        [DataMember]
        public string OTPClientID { get; set; }

        [DataMember]
        public string OTPUsername { get; set; }

        [DataMember]
        public string OTPPassword { get; set; }

        [DataMember]
        public int MinPasswordLength { get; set; }

        [DataMember]
        public int MinSpecialCharacters { get; set; }

        [DataMember]
        public int MaxSignOnAttempts { get; set; }

        [DataMember]
        public int EnforcePasswordHistory { get; set; }

        [DataMember]
        public int? ActivationLinkExpiresIn { get; set; }

        [DataMember]
        public string BaseUrl { get; set; }

        [DataMember]
        public int CreatedBy { get; set; }

        [DataMember]
        public DateTime DateCreated { get; set; }

        [DataMember]
        public int? UpdatedBy { get; set; }

        [DataMember]
        public DateTime? DateUpdated { get; set; }
    }
}
