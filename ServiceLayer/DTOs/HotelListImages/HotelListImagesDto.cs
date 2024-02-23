using ServiceLayer.DTOs.HotelList;

namespace ServiceLayer.DTOs.HotelListImages
{
    public class HotelListImagesDto
    {
        public int Id { get; set; }
        public byte[] Image { get; set; }
        public int HotelListId { get; set; }
        public HotelListDto HotelListDto { get; set; }

    }
}
