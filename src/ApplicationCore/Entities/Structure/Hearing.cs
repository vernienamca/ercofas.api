using System;
using System.Runtime.Serialization;

namespace ERCOFAS.ApplicationCore.Entities.Structure
{
    public class Hearing : BaseEntity<int>
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public int? HearingType { get; set; }

        [DataMember]
        public DateTime? Schedule { get; set; }

        [DataMember]
        public string MeetingLink { get; set; }

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
