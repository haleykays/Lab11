using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Lab11.Models; 
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace Lab11.Pages
{
    public class IndexModel : PageModel
    {
    private readonly Lab11.Models.ProfessorDbContext _context; 

    public IndexModel(Lab11.Models.ProfessorDbContext context)
    {
        _context = context; 
    }

        public IList<Professor> Professor { get;set; }
        public void OnGet()
        {

        }
    }
}

