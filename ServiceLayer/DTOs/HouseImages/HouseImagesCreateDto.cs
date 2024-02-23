using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.DTOs.HouseImages
{
    public class HouseImagesCreateDto
    {
        public byte[] Image { get; set; }
        public int HouseId { get; set; }

    }

    public class HouseImagesCreateValidator : AbstractValidator<HouseImagesCreateDto>
    {
        public HouseImagesCreateValidator()
        {


            RuleFor(m => m.Image).NotEmpty().WithMessage("Pleace add image");
        }
    }
}
