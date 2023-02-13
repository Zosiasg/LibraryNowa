using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace zaliczenie_.net.Models
{
    public class Library
    {
        public int idBook { get; set; }
        public string Tittle { get; set; }
        public string Author { get; set; }
        public string Section { get; set; }
        public Status Status { get; set; }
    }
    public enum Status
    {
        Available,
        Unavaiable
    }
    
}
