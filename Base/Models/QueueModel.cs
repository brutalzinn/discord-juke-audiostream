using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.Models
{
    public class List
    {
        public string Cover { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Duration { get; set; }
    }

    public class QueueModel
    {
        public bool Automix { get; set; }
        public int CurrentIndex { get; set; }
        public List<List> List { get; set; }
    }
}
