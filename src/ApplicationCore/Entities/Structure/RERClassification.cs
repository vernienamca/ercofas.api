using System;
using System.Runtime.Serialization;

namespace ERCOFAS.ApplicationCore.Entities.Structure
{
    public class RERClassification: BaseEntity<byte>
    {
        [DataMember]
        public byte Id { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public byte? UserTypeId { get; set; }

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
