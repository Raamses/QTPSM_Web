using QTPSM.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QTPSM_Web.Models
{
    public class servicesViewModel
    {
        public int id { get; set; }

        public string name { get; set; }

        public bool billable { get; set; }

        public service_billing_type service_billing_type { get; set; }

        public string po_number { get; set; }

        public decimal? po_remaining_amount { get; set; }

        public bool active { get; set; }

        public double? current_scope { get; set; }

        public double? current_effort { get; set; }

        public double? exceeding { get; set; }

        public ICollection<scope_exceeding> scope_exceedings { get; set; }

    }
}