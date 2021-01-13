using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NotesWebApp.Models;

namespace NotesWebApp.Data
{
    public class NotesWebAppContext : DbContext
    {
        public NotesWebAppContext (DbContextOptions<NotesWebAppContext> options)
            : base(options)
        {
        }

        public DbSet<NotesWebApp.Models.Note> Note { get; set; }
    }
}
