using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//Acess Model Data into Controller
using MVC_Demo.Models;

namespace MVC_Demo.Controllers
{
    //Intension of this Controller is Enable Communication between Model and View
    public class ProductsController : Controller
    {
        //Created Object of ProdutsData
        ProductsData db = new ProductsData();

        //Action Method to Crate View of Products List
        public ViewResult List()
        {
            //Passing List to the View
            return View(db.ProductList.ToList());
        }


        //Action Method to Crate View of Product Details
        public ViewResult Details(int id)
        {
            //Seaching id in products.id using LINQ
            Product product = db.ProductList.Single(x => x.ProductId == id); 
            //Passing Product to the view
            return View(product);
        }
    }
}