using EFDbFirst;
using EFDbFirst.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WebApp.Controllers
{
  public class ProductController : Controller
  {
        AppDbContext _db;
        public ProductController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
          var products = _db.Products.ToList();
          return View(products);
        }

        public IActionResult Create()
        {
          ViewBag.Categories = _db.Categories.ToList();
          return View();
        }
        [HttpPost]
        public IActionResult Create(Product product)
        {
              try 
              {
                  _db.Products.Add(product);
                  _db.SaveChanges();
                  return RedirectToAction("Index");

              }
              catch(Exception ex)
              { 
                  //throw ex;
              }

              ViewBag.Categories = _db.Categories.ToList();
               return View();
        }

    public IActionResult Edit(int id)
    {
      ViewBag.Categories = _db.Categories.ToList();
      var product = _db.Products.Find(id);
      return View(product);
    }
    [HttpPost]
    public IActionResult Edit(Product product)
    {
      try
      {
        // two ways there is the all object so you can edit any column
        //_db.Products.Update(product);

        // when u need only few columns to edit with ef
        _db.Products.Where(p=>p.ProductId == product.ProductId).ExecuteUpdate(p=>
        p.SetProperty(e => e.Price, product.Price).SetProperty(e => e.Name, product.Name));


        // only update one field 
        var p = _db.Products.Find(product.ProductId);
        p.Price = product.Price;
        _db.SaveChanges();
        return RedirectToAction("Index");

      }
      catch (Exception ex)
      {
        //throw ex;
      }

      ViewBag.Categories = _db.Categories.ToList();
      return View();
    }

    public IActionResult Delete(int id)
    {
      // two ways to do that
      //var product = _db.Products.Find(id);
      //if(product != null) 
      //{ 
      //  _db.Products.Remove(product);
      //  _db.SaveChanges();
      //}

      // This is another way cause we have ef
      _db.Products.Where(p=>p.ProductId==id).ExecuteDelete();
      return RedirectToAction("Index");
    }
  }
}
