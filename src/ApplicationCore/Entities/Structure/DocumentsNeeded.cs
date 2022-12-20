using System;
using System.Runtime.Serialization;

namespace ERCOFAS.ApplicationCore.Entities.Structure
{
    public class DocumentsNeeded : BaseEntity<long>
    {
        [DataMember]
        public long Id { get; set; }

        [DataMember]
        public int RequirementsId { get; set; }

        [DataMember]
        public string Purpose { get; set; }

        [DataMember]
        public bool IsRequired { get; set; }

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
