using System;
using System.Runtime.Serialization;

namespace ERCOFAS.ApplicationCore.Entities.Security
{
    public class User : BaseEntity<long>
    {
        [DataMember]
        public long Id { get; set; }

        [DataMember]
        public long RegistrationId { get; set; }

        [DataMember]
        public long UserStatusId { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string EmailAddress { get; set; }

        [DataMember]
        public string Password { get; set; }

        [DataMember]
        public string AvatarUrl { get; set; }

        [DataMember]
        public int SignOnAttempts { get; set; }

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
