using System;
using System.Runtime.Serialization;

namespace ERCOFAS.ApplicationCore.Entities.Security
{
    public class User : BaseEntity<int>
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string UserName { get; set; }

        [DataMember]
        public string Password { get; set; }

        [DataMember]
        public string EmailAddress { get; set; }

        [DataMember]
        public string PhoneNumber { get; set; }

        [DataMember]
        public string Address { get; set; }

        [DataMember]
        public int UserStatus { get; set; }

        [DataMember]
        public string AvatarUrl { get; set; }

        [DataMember]
        public int SignOnAttempts { get; set; }

        [DataMember]
        public bool LoggedIn { get; set; }

        [DataMember]
        public DateTime ExpirationDate { get; set; }

        [DataMember]
        public string PasswordToken { get; set; }

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
