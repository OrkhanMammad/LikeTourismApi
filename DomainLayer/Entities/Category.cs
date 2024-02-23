using DomainLayer.Common;

namespace DomainLayer.Entities
{
    public class Category : BaseEntity
    {
        public byte[] Image { get; set; }
        public string Name { get; set; }
    }
}
