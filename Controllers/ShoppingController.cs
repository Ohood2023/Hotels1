using Hotels.Data;
using Hotels.Models;
using Microsoft.AspNetCore.Mvc;

namespace Hotels.Controllers
{
    public class ShoppingController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ShoppingController(ApplicationDbContext context)
        {
            _context = context;

        }
        public IActionResult Index()
        {
            var hotel = _context.hotel.ToList();
            return View(hotel);
        }
        public IActionResult Invoice(int id) 
        {
            Decimal Tax = 15 / 100;
            var rooms = _context.rooms.SingleOrDefault(p => p.Id == id);
            var Invoice = new Invoice()
            {
                IdRooms = rooms.Id,
                IdHotel = rooms.IdHotels,
                IdRoomsDetails = rooms.Id,
                Price = rooms.Price,
                Total = rooms.Price * 1,
                Discount = 0,
                Tax = (15 / 100),
                Net = Tax * rooms.Price * 1,
                DateForm = DateTime.Now.Date,
                DateInvoice = DateTime.Now.Date,
                DateTo= DateTime.Now.Date,
                UserId=1


            };

            _context.invoices.Add(Invoice);
            _context.SaveChanges();
            ViewBag.Invoice = Invoice;
            return View();
        }
        public IActionResult Rooms(int id)
        {
            var rooms = _context.rooms.Where(p=>p.IdHotels==id).ToList();
            return View(rooms);
        }
    }
}
