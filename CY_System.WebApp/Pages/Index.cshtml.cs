using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CY_System.Service.Dto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CY_System.WebApp.Pages
{
    public class IndexModel : PageModel
    {
        public string Title = "用户管理";

        private string testName;

        public string TestName { get => testName; set => testName = value; }

        [BindProperty]
        public CYUsersDto UserDto { get => userDto; set => userDto = value; }

        private CYUsersDto userDto;

        public void OnGet()
        {
            
        }

        public void OnTest()
        {

        }

        public int test() => 3;

        public async Task<IActionResult> OnPost()
        {
            var x = UserDto;
            await Task.Delay(300);
            this.Title += "测试";
            return this.Page();
            //return  "33";
        }
    }
}
