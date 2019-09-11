using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hello.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace HelloDDD.Web.Controllers
{
    public class StudentController : Controller
    {
        //还是构造函数注入
        private readonly IStudentAppService _studentAppService;

        public StudentController(IStudentAppService studentAppService)
        {
            _studentAppService = studentAppService;
        }

        public IActionResult Index()
        {
            var rs = _studentAppService.GetAll();
            return View(rs);
        }
    }
}