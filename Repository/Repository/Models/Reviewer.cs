using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Repository.Models
{
    public class Reviewer
    {
        public int ReviewerID { get; set; }
        public string name { get; set; }

        public virtual List<Album> Albums { get; set; }
    }
}