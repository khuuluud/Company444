using Company444.BLL.Interfaces;
using Company444.BLL.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Company444.PL.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartmentRepository _DepartmentsRepo;

        public DepartmentController(IDepartmentRepository departmentsRepo)
        {
            _DepartmentsRepo = departmentsRepo;
        }

        public IActionResult Index()
        {
            var departments = _DepartmentsRepo.GetAll();
            return View();
        }
    }
}
