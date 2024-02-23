using DomainLayer.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Entities
{
    public class Order : BaseEntity
    {
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string FullName { get; set; }
        public int ReservationId { get; set; }
        public Reservation Reservation { get; set; }
        public int HotelListId { get; set; }
        
    }
}
