using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.DTOs.HotelDescription
{
    public class HotelDescriptionEditDto
    {
        public int Id { get; set; }
        public string LongDesc { get; set; }
        public string Breakfast { get; set; }
        public string BreakfastType { get; set; }
        public string Parking { get; set; }
        public string Animal { get; set; }
        public string CheckIn { get; set; }
    }
}
