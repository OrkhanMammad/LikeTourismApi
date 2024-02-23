using DomainLayer.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Entities
{
    public class HouseRoomImages:BaseEntity
    {
        public byte[] Image { get; set; }

        public int HouseRoomId { get; set; }

        public HouseRoom HouseRoom { get; set; }


    }
}
