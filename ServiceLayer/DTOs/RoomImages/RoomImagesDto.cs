using ServiceLayer.DTOs.Reservation;

namespace ServiceLayer.DTOs.RoomImages
{
    public class RoomImagesDto
    {

        public int Id { get; set; }
        public byte[] Image { get; set; }

        public int ReservationId { get; set; }


        public ReservationDto ReservationDto { get; set; }



    }
}
