using ServiceLayer.DTOs.HotelList;

namespace ServiceLayer.DTOs.HotelDescription
{
    public class HotelDescriptionDto
    {
        public int Id { get; set; }

        public string LongDesc { get; set; }
        public string Breakfast { get; set; }
        public string BreakfastType { get; set; }
        public string Parking { get; set; }
        public string Animal { get; set; }
        public string CheckIn { get; set; }

        public int HotelListId { get; set; }
        public HotelListDto HotelListDto { get; set; }
    }
}
