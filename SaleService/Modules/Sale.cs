using Microsoft.AspNetCore.Mvc;
using Nancy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaleService.Modules
{
    public class Sale : NancyModule
    {
        public Sale()
        {
            Get("/sale/", _ =>
            {
                return "Get all sale";
            });
        }
    }
}