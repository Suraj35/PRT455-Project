using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication6.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string title { get; set; }
        public string director { get; set; }
        public DateTime DateRelease { get; set; }

    }
}