using GettingData.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GettingData.Controllers
{
    public class StudentController : Controller
    {
        List<Student> students = new List<Student>() { 
        
            new Student()
            {
                firstName="Oguzhan",lastName="Kahraman"
            },
            new Student()
            {
                firstName="Furkan", lastName="furkan"
            },
            new Student()
            {
                firstName="animeSever", lastName="Alp"
            },
            new Student()
            {
                firstName="aaaaaaa", lastName="bbbbbb"
            }
        
        
        };
        public IActionResult GetStudentList()
        {
            return View(students);
        }
        [HttpPost]
        public IActionResult AddStudent(Student student)
        {
            students.Add(student);
            return View("GetStudentList",students);

        }
    }
}
