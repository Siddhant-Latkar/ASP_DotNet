using System.ComponentModel.DataAnnotations;

namespace Exp8CRUD.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public int Price { get; set; }
    }
}