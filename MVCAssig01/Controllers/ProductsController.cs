using Microsoft.AspNetCore.Mvc;
using MVCAssig01.Models;

namespace MVCAssig01.Controllers
{
    public class ProductsController:Controller
    {

        //BaseURL/Products/GetProductById
        //[HttpGet]
        //public Product GetProductById(int id)
        //{
        //    return new Product
        //    {
        //        Id = 1,
        //        Name = "Ihpone 15 Pro Max",
        //        Price = 30
        //    };
        //}

        [HttpGet]
       public JsonResult GetProductById(int id)
        {
            return new JsonResult(new Product()
            {
                Id = 1,
                Name = "Ihpone 15 Pro Max",
                Price = 30
            });
        }


        [HttpGet]
        public ViewResult Index()
        {
            return new ViewResult();

        }

        public RedirectResult RedirectToURL(int id) 
        { 
            if(id==1)
               return new RedirectResult("https://www.google.com");
            else if(id==2)
                return new RedirectResult("https://www.facebook.com");
            else
                return new RedirectResult("https://www.youtube.com");
        }

        public FileContentResult DownloadFile()
        {
            var bytes = System.IO.File.ReadAllBytes("wwwroot/images/1.jpg");
            return new FileContentResult(bytes, "application/txt");

        }

        
        public RedirectToActionResult RedirectAction()
        {
            return new RedirectToActionResult("RedirectToURL", "Products", new {id=2});
        }
    }
}
