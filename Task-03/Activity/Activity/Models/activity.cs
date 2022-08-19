using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Activity.Models
{
    public class activity
    {
        public Guid Id { get; set; }
        public string title { get; set; }
        public DateTime date { get; set; }
        public string description { get; set; }
        public string catagory { get; set; }
        public string city { get; set; }
        public string venue { get; set; }

    }
}
