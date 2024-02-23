using ServiceLayer.DTOs.HotelList;
using System.Collections.Generic;

namespace ServiceLayer.DTOs.FamousCity
{
    public class FamousCityDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte[] Image { get; set; }

        public List<HotelListDto> HotelLists { get; set; }
    }
}
