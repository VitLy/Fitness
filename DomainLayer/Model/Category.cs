using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DomainLayer.Model
{
    public partial class Category
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(40), Required, Index(IsUnique = true)]
        public String Name { get; set; }
    }
}




