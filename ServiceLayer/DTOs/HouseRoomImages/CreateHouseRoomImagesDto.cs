using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.DTOs.HouseRoomImages
{
    public class CreateHouseRoomImagesDto
    {
        public byte[] Image { get; set; }
        public int HouseRoomId { get; set; }

    }

    public class HouseRoomImagesCreateValidator : AbstractValidator<CreateHouseRoomImagesDto>
    {
        public HouseRoomImagesCreateValidator()
        {


            RuleFor(m => m.Image).NotEmpty().WithMessage("Pleace add image");
        }
    }
}
