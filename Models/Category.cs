using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebAppMVC.Models
{
    public class Category

    {
        public int Id { get; set; }
        [Required] public string CategoryName { get; set; }
        public List<Product> Products { get; set; }
    }
}

