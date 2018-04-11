using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CY_System.WebApp.Pages
{
    public class TestModel : PageModel
    {
        public String Shao = "测试";
        public void OnGet()
        {
            ViewData["Shao"] = Shao;

            int x = 10;
            x = x + 1;
            Console.WriteLine(x);
        }
    }
}