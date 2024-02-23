using DomainLayer.Common;

namespace DomainLayer.Entities
{
    public class RoomImages : BaseEntity
    {
        public byte[] Image { get; set; }

        public int ReservationId { get; set; }

        public Reservation Reservation { get; set; }

    }
}
