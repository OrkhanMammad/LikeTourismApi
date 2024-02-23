using FluentValidation;

namespace ServiceLayer.DTOs.House
{
    public class HouseCreateDto
    {
        public byte[] Image { get; set; }
        public string Name { get; set; }
        public int Prise { get; set; }
        public float Rating { get; set; }
        public string RatingCommit { get; set; }
        public int FamousCityId { get; set; }
    }

    public class HouseCreateValidator : AbstractValidator<HouseCreateDto>
    {
        public HouseCreateValidator()
        {
            RuleFor(m => m.Name).NotEmpty().WithMessage("Pleace add name").MinimumLength(4);
            RuleFor(m => m.Prise).NotEmpty().WithMessage("Pleace add prise");
            RuleFor(m => m.Rating).NotEmpty().WithMessage("Pleace add rating");
            RuleFor(m => m.RatingCommit).NotEmpty().WithMessage("Pleace add ratingcommit");
            RuleFor(m => m.Prise).NotEmpty().WithMessage("Pleace add prise");
            RuleFor(m => m.Image).NotEmpty().WithMessage("Pleace add image");
        }
    }
}
