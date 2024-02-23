using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.DTOs.House
{
    public class HouseEditDto
    {
        public int Id { get; set; }

        public byte[] Image { get; set; }
        public string Name { get; set; }
        public int Prise { get; set; }
        public float Rating { get; set; }
        public string RatingCommit { get; set; }

    }
}
