using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotesWebApp.Models
{
    public class Note
    {
        public int ID { get; set; }
        public string ShortDescription { get; set; }
        public string FullDescription { get; set; }
        public DateTime Date { get; set; }

    }
}
