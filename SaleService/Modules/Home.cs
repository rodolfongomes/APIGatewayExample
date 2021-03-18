using Nancy;

namespace SaleService.Modules
{
    public class Home : NancyModule
    {
        public Home()
        {
            Get("/", _ => "Sale API Working");
        }
    }
}