using QTPSM.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QTPSM_Web.Models
{
    public class exceedingViewModel
    {
        public int id { get; set; }

        public int service_id { get; set; }

        public int finance_period_id { get; set; }

        public DateTime requested_date { get; set; }

        public int scope { get; set; }

        public int status_id { get; set; }

        public string exceeding_comments { get; set; }

        public string updated_by { get; set; }

        public DateTime? update_timestamp { get; set; }

        public virtual finance_period finance_period { get; set; }

        public virtual scope_exceeding_status scope_exceeding_status { get; set; }
    }
}