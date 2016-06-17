using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QTPSM_Web.Models
{
    public class finance_periodViewModel 
    {
        public int id { get; set; }

        public string period_name { get; set; }

        public DateTime period_start { get; set; }

        public DateTime period_end { get; set; }

        public bool is_current_period { get; set; }
    }
}