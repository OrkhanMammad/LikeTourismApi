using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.DTOs.Reservation
{
    public class ReservationEditDto
    {


        public int Id { get; set; }
        public byte[] Image { get; set; }

        public string RoomType { get; set; }
        public int RoomPrise { get; set; }
        public int Remained { get; set; }
    }
}
