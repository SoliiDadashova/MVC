using System.ComponentModel.DataAnnotations;

namespace WebAppMVC.Models
{
    public class ProductDTO
    {
        [Required] public string Name { get; set; }
        [Required] public int Price { get; set; }
        [Required] public int CategoryId { get; set; }
    }
}
