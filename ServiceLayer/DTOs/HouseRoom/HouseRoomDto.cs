using ServiceLayer.DTOs.House;
using ServiceLayer.DTOs.HouseRoomImages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.DTOs.HouseRoom
{
    public class HouseRoomDto
    {
        public int Id { get; set; }
        public byte[] Image { get; set; }

        public string RoomType { get; set; }
        public int RoomPrise { get; set; }
        public int Remained { get; set; }
        public List<HouseRoomImagesDto> HouseRoomImages { get; set; }




        public int HouseId { get; set; }
        public HouseListDto HouseListDto { get; set; }


    }
}
