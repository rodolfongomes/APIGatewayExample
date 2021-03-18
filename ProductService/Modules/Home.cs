using Nancy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductService.Modules
{
    public class Home : NancyModule
    {
        public Home()
        {
            Get("/", _ => "Product API Working");
        }
    }
}