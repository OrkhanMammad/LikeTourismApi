using ServiceLayer.DTOs.House;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.DTOs.HouseImages
{
    public class HouseImagesDto
    {

        public int Id { get; set; }
        public byte[] Image { get; set; }
        public int HouseId { get; set; }
        public HouseListDto HouseListDto { get; set; }


    }
}
