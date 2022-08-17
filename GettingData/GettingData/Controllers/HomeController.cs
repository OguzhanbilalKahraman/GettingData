using GettingData.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GettingData.Controllers
{
    public class HomeController : Controller
    {
        public string Index(Product product)
        {

            return "Program Calisiyor...";
        }
        public string UseQueryString(string name, string surname)
        {


            return "Program calis...";
        }
    }
}
