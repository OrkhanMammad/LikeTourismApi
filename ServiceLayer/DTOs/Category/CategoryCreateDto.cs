using FluentValidation;

namespace ServiceLayer.DTOs.Category
{
    public class CategoryCreateDto
    {
        public byte[] Image { get; set; }
        public string Name { get; set; }
    }
    public class CategoryCreateValidator : AbstractValidator<CategoryCreateDto>
    {
        public CategoryCreateValidator()
        {
            RuleFor(m => m.Image).NotEmpty().WithMessage("Pleace add image");
            RuleFor(m => m.Name).NotEmpty().WithMessage("Pleace add description");
        }
    }
}
