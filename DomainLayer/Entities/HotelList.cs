using DomainLayer.Common;
using System.Collections.Generic;

namespace DomainLayer.Entities
{
    public class HotelList : BaseEntity
    {
        public byte[] Image { get; set; }
        public string Name { get; set; }
        public string Distance { get; set; }
        public string Desc { get; set; }
        public int Rating { get; set; }
        public string RatingTitle { get; set; }
        public int Star { get; set; }
        public int Prise { get; set; }
        public int FamousCityId { get; set; }
        public FamousCity FamousCity { get; set; }
        public List<Reservation> Reservations { get; set; }
        public List<HotelListImages> HotelListImages { get; set; }
        public List<HotelDescription> HotelDescriptions { get; set; }


    }
}
