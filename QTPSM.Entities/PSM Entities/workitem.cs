namespace QTPSM.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("workitem")]
    public partial class workitem : IEntityBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public workitem()
        {
            workitem_attachment = new HashSet<workitem_attachment>();
            workitem_log = new HashSet<workitem_log>();
        }

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

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public double? total_effort { get; set; }

        public int? priority_id { get; set; }

        public DateTime? closure_date { get; set; }

        [StringLength(255)]
        public string updated_by { get; set; }

        public DateTime? update_timestamp { get; set; }

        [StringLength(1000)]
        public string comment { get; set; }

        [StringLength(250)]
        public string fp_name { get; set; }

        public virtual engineer engineer { get; set; }

        public virtual project project { get; set; }

        public virtual work_item_type work_item_type { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<workitem_attachment> workitem_attachment { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<workitem_log> workitem_log { get; set; }

        public virtual workitem_priority workitem_priority { get; set; }

        public virtual workitem_status workitem_status { get; set; }
    }
}
