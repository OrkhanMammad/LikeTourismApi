using FluentValidation;

namespace ServiceLayer.DTOs.HotelList
{
    public class HotelListCreateDto
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


    }
    public class HotelListCreateValidator : AbstractValidator<HotelListCreateDto>
    {
        public HotelListCreateValidator()
        {
            RuleFor(m => m.Name);
            RuleFor(m => m.Image);
            RuleFor(m => m.Distance);
            RuleFor(m => m.Desc);
            RuleFor(m => m.Rating);
            RuleFor(m => m.RatingTitle);
            RuleFor(m => m.Star);


            RuleFor(m => m.Prise);

        }
    }
}
