using System;
using System;
using System.Runtime.Serialization;

namespace ERCOFAS.ApplicationCore.Entities.Security
{
    public class SealingAndAcceptanceTesting : BaseEntity<int>
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Documents { get; set; }

        [DataMember]
        public string Date { get; set; }

        [DataMember]
        public string Time { get; set; }

        [DataMember]
        public string GeneratedBarcode { get; set; }

        [DataMember]
        public string Details { get; set; }

        [DataMember]
        public string Attachments { get; set; }

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
