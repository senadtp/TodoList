using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace todolist.Models
{
    public class Todo
    {
        public int id { get; set; }
        public string gorevAd { get; set; }
        public bool gorevIsDone { get; set; }

    }
}