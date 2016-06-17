namespace QTPSM.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class workitem_log : IEntityBase
    {
        public int id { get; set; }

        public int workitem_id { get; set; }

        public DateTime submit_date { get; set; }

        [StringLength(100)]
        public string summary { get; set; }

        public string notes { get; set; }

        public int engineer_id { get; set; }

        public double? effort { get; set; }

        [StringLength(255)]
        public string updated_by { get; set; }

        public DateTime? update_timestamp { get; set; }

        public virtual engineer engineer { get; set; }

        public virtual workitem workitem { get; set; }
    }
}
