using System;
using System.Collections.Generic;

namespace ATicket.Module
{
    public partial class Showstarts
    {
        public string Showname { get; set; }
        public string Actor { get; set; }
        public decimal? Price { get; set; }
        public DateTime? Startime { get; set; }
        public string Place { get; set; }
        public string Url { get; set; }
        public string Type { get; set; }
        public string FrontImagePath { get; set; }
        public DateTime? Readtime { get; set; }
    }
}
