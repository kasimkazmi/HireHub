using Microsoft.AspNetCore.Mvc;
using HireHub.Models;
using System.Diagnostics;

namespace HireHub.Controllers
{
    public class ShadesController : Controller
    {


        private readonly ILogger<ShadesController> _logger;

        public ShadesController(ILogger<ShadesController> logger)
        {
            _logger = logger;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult Index()
        {

            List<Shade> items = new List<Shade>
{
    new Shade(1, "Red Shades", "Ray-Ban", "These are red shades. They are very cool and stylish.", 50, 99.99m),
    new Shade(2, "Blue Shades", "Oakley", "These are blue shades. They are very cool and stylish.", 25, 149.99m),
    new Shade(3, "Green Shades", "Gucci", "These are green shades. They are very cool and stylish.", 10, 299.99m),
    new Shade(4, "Black Shades", "Prada", "These are black shades. They are sleek and sophisticated.", 30, 199.99m),
    new Shade(5, "Brown Shades", "Armani", "These are brown shades. They are warm and stylish.", 20, 179.99m),
    new Shade(6, "White Shades", "Dolce & Gabbana", "These are white shades. They are clean and modern.", 15, 249.99m),
    new Shade(7, "Pink Shades", "Versace", "These are pink shades. They are feminine and fun.", 25, 159.99m),
    new Shade(8, "Yellow Shades", "Miu Miu", "These are yellow shades. They are bright and cheerful.", 30, 129.99m),
    new Shade(9, "Orange Shades", "Fendi", "These are orange shades. They are bold and energetic.", 40, 119.99m),
    new Shade(10, "Purple Shades", "Burberry", "These are purple shades. They are regal and mysterious.", 15, 229.99m),
    new Shade(11, "Gray Shades", "Chanel", "These are gray shades. They are neutral and versatile.", 35, 189.99m),
    new Shade(12, "Silver Shades", "Hermes", "These are silver shades. They are sleek and modern.", 20, 299.99m),
    new Shade(13, "Gold Shades", "Louis Vuitton", "These are gold shades. They are luxurious and glamorous.", 10, 499.99m),
    new Shade(14, "Transparent Shades", "Dior", "These are transparent shades. They are unique and stylish.", 40, 149.99m),
    new Shade(15, "Mirrored Shades", "Saint Laurent", "These are mirrored shades. They are trendy and cool.", 25, 199.99m),
    new Shade(16, "Polarized Shades", "Tom Ford", "These are polarized shades. They are functional and protective.", 30, 249.99m),
    new Shade(17, "Round Shades", "Persol", "These are round shades. They are retro and chic.", 20, 179.99m),
    new Shade(18, "Square Shades", "Marc Jacobs", "These are square shades. They are modern and edgy.", 35, 159.99m),
    new Shade(19, "Cat-Eye Shades", "Alexander McQueen", "These are cat-eye shades. They are glamorous and sophisticated.", 15, 299.99m),
    new Shade(20, "Aviator Shades", "Moschino", "These are aviator shades. They are classic and timeless.", 50, 129.99m)
};
            return View(items);
        }
    }
}