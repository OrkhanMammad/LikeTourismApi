using DomainLayer.Common;

namespace DomainLayer.Entities
{
    public class HotelListImages : BaseEntity
    {
        public byte[] Image { get; set; }
        public int HotelListId { get; set; }
        public HotelList HotelList { get; set; }


    }
}
