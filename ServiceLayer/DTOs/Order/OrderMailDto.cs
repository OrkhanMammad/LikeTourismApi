using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.DTOs.Order
{
    public class OrderMailDto
    {
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string ReservationName { get; set; }
        public string FullName { get; set; }
        public int ReservationId { get; set; }
        public int HotelListId { get; set; }
    }
}
