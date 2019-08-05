using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities
{
    public class Product
    {
        [ForeignKey("Category")]
        public virtual int CategoryId { set; get; }

        public Category Category { set; get; }

        [Key]
        public int ProductId { set; get; }

        [Required]
        public double Price { set; get; }

        [Required]
        public string Name { set; get; }

        [MaxLength(500), MinLength(0)]
        public string Description { set; get; }
        public string Cal { set; get; }
    }
}
