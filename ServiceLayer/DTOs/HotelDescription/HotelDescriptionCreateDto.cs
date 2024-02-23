using FluentValidation;

namespace ServiceLayer.DTOs.HotelDescription
{
    public class HotelDescriptionCreateDto
    {
        public string LongDesc { get; set; }
        public string Breakfast { get; set; }
        public string BreakfastType { get; set; }
        public string Parking { get; set; }
        public string Animal { get; set; }
        public string CheckIn { get; set; }
        public int HotelListId { get; set; }

    }

    public class HotelDescriptionCreateValidator : AbstractValidator<HotelDescriptionCreateDto>
    {
        public HotelDescriptionCreateValidator()
        {


            RuleFor(m => m.LongDesc).NotEmpty().WithMessage("Pleace add image");
            RuleFor(m => m.Breakfast).NotEmpty().WithMessage("Pleace add image");
            RuleFor(m => m.BreakfastType).NotEmpty().WithMessage("Pleace add image");
            RuleFor(m => m.Parking).NotEmpty().WithMessage("Pleace add image");
            RuleFor(m => m.Animal).NotEmpty().WithMessage("Pleace add image");
            RuleFor(m => m.CheckIn).NotEmpty().WithMessage("Pleace add image");

        }
    }
}
