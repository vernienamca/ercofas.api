using System;
using System.Runtime.Serialization;

namespace ERCOFAS.ApplicationCore.Entities.Structure
{
    public class PreFilingRequest : BaseEntity<long>
    {
        [DataMember]
        public long Id { get; set; }

        [DataMember]
        public string RequestSubject { get; set; }

        [DataMember]
        public long UserId { get; set; }

        [DataMember]
        public byte CaseTypeId { get; set; }

        [DataMember]
        public byte CaseNatureId { get; set; }

        [DataMember]
        public byte PreFilingStatusId { get; set; }

        [DataMember]
        public string Remarks { get; set; }

        [DataMember]
        public DateTime DateFiled { get; set; }

        [DataMember]
        public DateTime? DateUpdated { get; set; }
    }
}
