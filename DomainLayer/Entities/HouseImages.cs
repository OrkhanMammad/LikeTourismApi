using DomainLayer.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Entities
{
    public class HouseImages:BaseEntity
    {

        public byte[] Image { get; set; }

        public int HouseId { get; set; }
        public House House { get; set; }


    }
}
