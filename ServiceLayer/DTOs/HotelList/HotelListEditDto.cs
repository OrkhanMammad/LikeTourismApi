namespace ServiceLayer.DTOs.HotelList
{
    public class HotelListEditDto
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
    }
}
