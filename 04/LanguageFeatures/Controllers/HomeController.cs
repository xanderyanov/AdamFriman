using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using LanguageFeatures.Models;



namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            List<string> results = new List<string>();
            foreach (Product p in Product.GetProducts())
            {
                string name = p?.Name ?? "<NoName>";
                string category = p?.Category;
                decimal? price = p?.Price;
                bool? inStock = p?.InStock;

                string relatedName = p?.Related?.Name ?? "<NoRelated>";
                results.Add(string.Format($"Name: {name}, Category: {category}, Price: {price}, Related: {relatedName}, InStock: {inStock}"));
            }
            return View(results);

        }
    }
}

