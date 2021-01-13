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
    public class IndexModel : PageModel
    {
        private readonly NotesWebApp.Data.NotesWebAppContext _context;

        public IndexModel(NotesWebApp.Data.NotesWebAppContext context)
        {
            _context = context;
        }

        public IList<Note> Note { get;set; }

        public async Task OnGetAsync()
        {
            Note = await _context.Note.ToListAsync();
        }
    }
}
