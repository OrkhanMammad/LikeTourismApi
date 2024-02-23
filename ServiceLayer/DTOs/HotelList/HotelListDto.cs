using ServiceLayer.DTOs.FamousCity;
using ServiceLayer.DTOs.HotelDescription;
using ServiceLayer.DTOs.HotelListImages;
using System.Collections.Generic;

namespace ServiceLayer.DTOs.HotelList
{
    public class HotelListDto
    {
        public int Id { get; set; }
        public byte[] Image { get; set; }
        public string Name { get; set; }
        public string Distance { get; set; }
        public string Desc { get; set; }
        public int Rating { get; set; }
        public string RatingTitle { get; set; }

        public int Star { get; set; }

        public int Prise { get; set; }

        public List<HotelListImagesDto> HotelListImages { get; set; }
        public List<HotelDescriptionDto> HotelDescriptions { get; set; }

        public int FamousCityId { get; set; }
        public FamousCityDto FamousCityDto { get; set; }

    }
}
