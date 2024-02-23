using DomainLayer.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Entities
{
    public class Villa:BaseEntity
    {
        public byte[] Image { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public float Rating { get; set; }
        public string RatingText { get; set; }
        public string Desc { get; set; }

    }
}
