﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTB.Eshop.Domain.Implementation.Validations;

namespace UTB.Eshop.Domain.Entities
{
    public class Product : Entity
    {
        [Required]
        [StringLength(70)]
        public string? Name { get; set; }

        public string? Description { get; set; }
        //public int CategoryId { get; set; }

        [Required]
        public double Price { get; set; }

        public string? ImageSrc { get; set; }

        [NotMapped]
        [FileContent("image")]
        public IFormFile Image { get; set; }
    }
}
