namespace QTPSM.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class workitem_test : IEntityBase
    {
        public int id { get; set; }

        [Required]
        [StringLength(8)]
        public string submitter_wwid { get; set; }

        [StringLength(255)]
        public string submitter_name { get; set; }

        public DateTime submit_date { get; set; }

        public int type_id { get; set; }

        public int status_id { get; set; }

        public int project_id { get; set; }

        public int? engineer_id { get; set; }

        [Required]
        [StringLength(100)]
        public string summary { get; set; }

        public string notes { get; set; }

        public double? total_effort { get; set; }

        public int? priority_id { get; set; }

        public DateTime? closure_date { get; set; }

        [StringLength(255)]
        public string updated_by { get; set; }

        public DateTime? update_timestamp { get; set; }

        [StringLength(1000)]
        public string comment { get; set; }
    }
}
