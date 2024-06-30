using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;
using WebAppMVC.Models;
using WebAppMVC.Models.Data;

namespace WebAppMVC.Controllers
{
    public class ProductController : Controller
    {
        public AppMVCDBContext _context { get; }
        public ProductController(AppMVCDBContext context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task< IActionResult> Index()
        {
            return View(await _context.Products.ToListAsync());
        }
        [HttpPost]
        public  IActionResult Create(ProductDTO productDTO)
        {
            try
            {
              var p=new Product { CategoryId= productDTO.CategoryId,Name=productDTO.Name,Price=productDTO.Price };
                _context.Products.Add(p);
                 _context.SaveChangesAsync();  
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return View(productDTO);     
        }
    }
}
