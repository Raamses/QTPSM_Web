namespace QTPSM.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class scope_exceeding : IEntityBase
    {
        public int id { get; set; }

        public int service_id { get; set; }

        public int finance_period_id { get; set; }

        public DateTime requested_date { get; set; }

        public int scope { get; set; }

        public int status_id { get; set; }

        public string exceeding_comments { get; set; }

        [StringLength(50)]
        public string updated_by { get; set; }

        public DateTime? update_timestamp { get; set; }

        public virtual finance_period finance_period { get; set; }

        public virtual service service { get; set; }

        public virtual scope_exceeding_status scope_exceeding_status { get; set; }
    }
}
