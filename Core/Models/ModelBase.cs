using System.Runtime.Serialization;

namespace Core.Models
{
    public class ModelBase
    {
        [DataMember]
        public int Id { get; set; }
    }
}