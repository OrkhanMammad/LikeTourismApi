using ServiceLayer.DTOs.HouseRoom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.DTOs.HouseRoomImages
{
    public class HouseRoomImagesDto
    {

        public int Id { get; set; }
        public byte[] Image { get; set; }

        public int HouseRoomId { get; set; }



        public HouseRoomDto HouseRoomDto { get; set; }


    }
}
