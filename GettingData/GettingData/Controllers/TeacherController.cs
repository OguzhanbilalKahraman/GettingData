using GettingData.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GettingData.Controllers
{
    public class TeacherController : Controller
    {
        List<Branch> branches = new List<Branch>()
        {
            new Branch(){id=1,branchName="matematik"},
            new Branch(){id=2,branchName="fizik"},
            new Branch(){id=3,branchName="geometri"},
            new Branch(){id=4,branchName="biyoloji"}

        };

       
        public IActionResult AddTeacher()
        {
            ViewBag.Branches = branches;
            Teacher teacher = new Teacher();
            teacher.branchId = 1;
            teacher.firstName = "oGUZHAN";
            teacher.lastName = "kahraman";

            return View(teacher);
        }

        [HttpPost]
        public IActionResult AddTeacher(Teacher teacher)
        {
            ViewBag.Branches = branches;
            return View();
        }

        public IActionResult AddTeacherUsingTupple()
        {
            (List<Branch>, Teacher,Student) tuple = (branches,new Teacher(),new Student());

            return View(tuple);

        }

        [HttpPost]
        public IActionResult AddTeacherUsingTupple([Bind(Prefix ="Item2")] Teacher teacher,[Bind(Prefix ="Item3")] Student student)
        {


            return RedirectToAction("AddTeacherUsingTupple");

        }


    }
}
