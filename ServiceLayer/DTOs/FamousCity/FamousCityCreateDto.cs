using FluentValidation;

namespace ServiceLayer.DTOs.FamousCity
{
    public class FamousCityCreateDto
    {

        public string Name { get; set; }

        public byte[] Image { get; set; }
    }

    public class FamousCityCreateValidator : AbstractValidator<FamousCityCreateDto>
    {
        public FamousCityCreateValidator()
        {
            RuleFor(m => m.Name).NotEmpty().WithMessage("Pleace add name").MinimumLength(4);
            RuleFor(m => m.Image).NotEmpty().WithMessage("Pleace add image");
        }
    }

}
