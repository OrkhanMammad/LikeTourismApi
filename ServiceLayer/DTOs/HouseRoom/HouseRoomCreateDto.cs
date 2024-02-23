using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.DTOs.HouseRoom
{
    public class HouseRoomCreateDto
    {

        public string RoomType { get; set; }
        public int RoomPrise { get; set; }

        public byte[] Image { get; set; }
        public int Remained { get; set; }
        public int HouseId { get; set; }

    }

    public class HouseRoomCreateValidator : AbstractValidator<HouseRoomCreateDto>
    {
        public HouseRoomCreateValidator()
        {
            RuleFor(m => m.RoomType).NotEmpty().WithMessage("Pleace add Title").MinimumLength(4);
            RuleFor(m => m.RoomPrise).NotEmpty().WithMessage("Pleace add prise");
            RuleFor(m => m.Remained).NotEmpty().WithMessage("Pleace add breakfast");

        }
    }
}
