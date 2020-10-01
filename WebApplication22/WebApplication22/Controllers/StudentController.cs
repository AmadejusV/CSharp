using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication22.Models
{
    public class StudentController : Controller
    {
        public IActionResult MyStudents()
        {


            IList<Student> studentList = new List<Student>()
            {
                new Student(){StudentID=1, StudentName="John", Age=18, StandardID=1},
                new Student(){StudentID=1, StudentName="John", Age=18, StandardID=1},
                new Student(){StudentID=1, StudentName="John", Age=18, StandardID=1},
                new Student(){StudentID=1, StudentName="John", Age=18, StandardID=1},
                new Student(){StudentID=1, StudentName="John", Age=18, StandardID=1}

            };
            return View(studentList);
        }
    }
}
