using Microsoft.AspNetCore.Mvc;
using Nancy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductService.Modules
{
    public class Product : NancyModule
    {
        public Product()
        {
            Get("/product/", _ =>
            {
                return "Get all products";
            });
        }
    }
}