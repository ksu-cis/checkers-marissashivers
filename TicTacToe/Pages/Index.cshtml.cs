using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TicTacToe.Pages
{
    public class IndexModel : PageModel
    {
        public Game Game { get; set; }
        public void OnGet()
        {

        }

        public void OnPost(int cx, int cy, int sx, int sy)
        {
            var cx = Request.Form["cx"];
        }
    }
}
