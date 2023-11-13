using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        [Range(0, double.MaxValue)]
        public double Price { get; set; }

        [Required]
        public string? ImageSrc { get; set; }

        [NotMapped]
        public IFormFile Image { get; set; }
    }
}
