using System.Runtime.Serialization;

namespace ERCOFAS.ApplicationCore.Entities.Security
{
    public class TokenKeys
    {
        [DataMember]
        public string Issuer { get; set; }

        [DataMember]
        public string Audience { get; set; }

        [DataMember]
        public int ExpiresInMinutes { get; set; }
    }
}
