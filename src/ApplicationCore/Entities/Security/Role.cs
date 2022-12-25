using System;
using System;
using System.Runtime.Serialization;

namespace ERCOFAS.ApplicationCore.Entities.Security
{
    public class Role : BaseEntity<int>
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string RoleName { get; set; }

        [DataMember]
        public string Description { get; set; }

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
