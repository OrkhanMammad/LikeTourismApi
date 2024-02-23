using FluentValidation;

namespace ServiceLayer.DTOs.Slider
{
    public class SliderCreateDto
    {
        public byte[] Image { get; set; }
        public string Title { get; set; }
        public string Desc { get; set; }
    }

    public class SliderCreateValidator : AbstractValidator<SliderCreateDto>
    {
        public SliderCreateValidator()
        {
            RuleFor(m => m.Title).NotEmpty().WithMessage("Pleace add Title").MinimumLength(4);
            RuleFor(m => m.Desc).NotEmpty().WithMessage("Pleace add description").MinimumLength(4);

            RuleFor(m => m.Image).NotEmpty().WithMessage("Pleace add image");
        }
    }
}
