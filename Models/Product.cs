using System.ComponentModel.DataAnnotations;

namespace WebAppMVC.Models
{
    public class Product 
    {
        public int Id { get; set; }
        [Required]  public string Name { get; set; }
        [Required] public int Price { get; set; }
        [Required] public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
