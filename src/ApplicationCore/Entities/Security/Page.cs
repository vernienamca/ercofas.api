using System;
using System.Runtime.Serialization;

namespace ERCOFAS.ApplicationCore.Entities.Structure
{
    public class Page : BaseEntity<int>
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string PageName { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public string UrlPath { get; set; }

        [DataMember]
        public int? ParentMenu { get; set; }

        [DataMember]
        public string Icon { get; set; }

        [DataMember]
        public int Order { get; set; }

        [DataMember]
        public bool? IsParent { get; set; }

        [DataMember]
        public bool IsVisible { get; set; }

        [DataMember]
        public bool? AccessibleByAll { get; set; }

        [DataMember]
        public bool IsActive { get; set; }

        [DataMember]
        public DateTime DateCreated { get; set; }
    }
}
