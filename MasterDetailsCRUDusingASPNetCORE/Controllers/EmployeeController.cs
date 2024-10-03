using MasterDetailsCRUDusingASPNetCORE.Models;
using MasterDetailsCRUDusingASPNetCORE.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MasterDetailsCRUDusingASPNetCORE.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ProjectDbContext _db;
        private readonly IWebHostEnvironment _webHost;

        public EmployeeController(ProjectDbContext db, IWebHostEnvironment webHost)
        {
            _db = db;
            this._webHost = webHost;
        }

        public async Task <IActionResult> Index()
        {
            var employee= await _db.Employees.Include(e=>e.Experiences).ToListAsync();
            return View(employee);
        }

        public IActionResult Create() 
        {
            var model = new EmployeeViewModel { Experiences = new List<ExperienceViewModel>() };
            return View(model);
        
        }
        [HttpPost]    
        public async Task<IActionResult> Create(EmployeeViewModel employee)
        {
            string uniqueFilename = null;
            if (employee.ImageFile != null)
            {
                string uploadFolder = Path.Combine(_webHost.WebRootPath, "images");
                uniqueFilename = Guid.NewGuid().ToString() + "_" + employee.ImageFile.FileName;
                string filePath = Path.Combine(uploadFolder, uniqueFilename);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    await employee.ImageFile.CopyToAsync(fileStream);
                }
            }
            var emp = new Employee
            {
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                Email = employee.Email,
                Mobile = employee.Mobile,
                IsActive = employee.IsActive,
                JoinDate =employee.JoinDate,             
                ImageUrl = employee.ImageUrl,
                Salary = employee.Salary,
                Experiences = employee.Experiences.Select(e => new Experience
                {
                    JobTitle = e.JobTitle,
                    InstitutionName=e.InstitutionName,  
                    Duration = e.Duration,

                }).ToList()
            };       
            _db.Employees.Add(emp);
            await _db.SaveChangesAsync();

            return RedirectToAction("Index");


        }


    
    }
}
