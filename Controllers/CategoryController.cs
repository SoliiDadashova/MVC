using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.TagHelpers.Cache;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppMVC.Models;
using WebAppMVC.Models.Data;

namespace WebAppMVC.Controllers
{
    public class CategoryController : Controller
    {
        public AppMVCDBContext _context { get; }
        public CategoryController(AppMVCDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View(await _context.Categories.ToListAsync());
        }
        [HttpPost]
        public IActionResult Create(CategoryDTO category)
        {
            try
            {
                var c = new Category { CategoryName= category.CategoryName };
                _context.Categories.Add(c);
                _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return RedirectToAction("Index");
        }
    }
}


