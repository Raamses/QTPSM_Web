namespace QTPSM.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class service_scope : IEntityBase
    {
        public int id { get; set; }

        public int service_id { get; set; }

        public int finance_period_id { get; set; }

        public int scope { get; set; }

        public double coefficient { get; set; }

        public virtual finance_period finance_period { get; set; }

        public virtual service service { get; set; }
    }
}
