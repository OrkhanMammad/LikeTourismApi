using DomainLayer.Common;
using System.Collections.Generic;

namespace DomainLayer.Entities
{
    public class FamousCity : BaseEntity
    {
        public string Name { get; set; }
        public byte[] Image { get; set; }

        public List<HotelList> HotelLists { get; set; }

    }
}
