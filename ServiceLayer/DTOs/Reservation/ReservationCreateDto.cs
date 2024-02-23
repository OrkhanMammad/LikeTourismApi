using FluentValidation;

namespace ServiceLayer.DTOs.Reservation
{
    public class ReservationCreateDto
    {
        public string RoomType { get; set; }
        public int RoomPrise { get; set; }

        public byte[] Image { get; set; }
        public int Remained { get; set; }
        public int HotelListId { get; set; }



    }
    public class ReservationCreateValidator : AbstractValidator<ReservationCreateDto>
    {
        public ReservationCreateValidator()
        {
            RuleFor(m => m.RoomType).NotEmpty().WithMessage("Pleace add Title").MinimumLength(4);
            RuleFor(m => m.RoomPrise).NotEmpty().WithMessage("Pleace add prise");
            RuleFor(m => m.Remained).NotEmpty().WithMessage("Pleace add breakfast");

        }
    }
}
