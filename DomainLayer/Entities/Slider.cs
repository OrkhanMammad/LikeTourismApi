﻿using DomainLayer.Common;

namespace DomainLayer.Entities
{
    public class Slider : BaseEntity
    {
        public byte[] Image { get; set; }
        public string Title { get; set; }
        public string Desc { get; set; }

    }
}
