using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NotesWebApp.Data;
using NotesWebApp.Models;

namespace NotesWebApp.Pages.Notes
{
    public class DetailsModel : PageModel
    {
        private readonly NotesWebApp.Data.NotesWebAppContext _context;

        public DetailsModel(NotesWebApp.Data.NotesWebAppContext context)
        {
            _context = context;
        }

        public Note Note { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Note = await _context.Note.FirstOrDefaultAsync(m => m.ID == id);

            if (Note == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
