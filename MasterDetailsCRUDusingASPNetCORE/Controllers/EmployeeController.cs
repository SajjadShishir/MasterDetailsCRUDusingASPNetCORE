using MasterDetailsCRUDusingASPNetCORE.Models;
using Microsoft.AspNetCore.Mvc;

namespace MasterDetailsCRUDusingASPNetCORE.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ProjectDbContext _db;
        private readonly IWebHostEnvironment webHost;

        public EmployeeController(ProjectDbContext db, IWebHostEnvironment webHost)
        {
            _db = db;
            this.webHost = webHost;
        }

        public async Task <IActionResult> Index()
        {
            return View();
        }
        public IActionResult Aggregate() 
        {

        
        
        }
    }
}
