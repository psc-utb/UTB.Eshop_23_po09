﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTB.Eshop.Domain.Entities
{
    public class Product : Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        //public int CategoryId { get; set; }
        public double Price { get; set; }
        public string ImageSrc { get; set; }

        public IFormFile Image { get; set; }
    }
}
