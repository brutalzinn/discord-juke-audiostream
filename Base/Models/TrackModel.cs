using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.Models
{
    public class TrackModel
    {
        public string Author { get; set; }
        public string Title { get; set; }
        public string Album { get; set; }
        public string Cover { get; set; }
        public int Duration { get; set; }
        public string DurationHuman { get; set; }
        public string Url { get; set; }
        public string Id { get; set; }
        public bool IsVideo { get; set; }
        public bool IsAdvertisement { get; set; }
        public bool InLibrary { get; set; }
    }
}
