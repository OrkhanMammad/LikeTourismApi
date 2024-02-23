using DomainLayer.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Entities
{
    public class HouseRoom:BaseEntity
    {
        public byte[] Image { get; set; }
        public string RoomType { get; set; }
        public int RoomPrise { get; set; }
        public int Remained { get; set; }
        public int HouseId { get; set; }
        public House House { get; set; }

        public List<HouseRoomImages> HouseRoomImages { get; set; }




    }
}
