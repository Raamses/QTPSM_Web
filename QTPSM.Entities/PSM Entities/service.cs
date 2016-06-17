namespace QTPSM.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("service")]
    public partial class service : IEntityBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public service()
        {
            projects = new HashSet<project>();
            scope_exceeding = new HashSet<scope_exceeding>();
            service_scope = new HashSet<service_scope>();
            service_owner = new HashSet<service_owner>();
            service_scope_default = new HashSet<service_scope_default>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(255)]
        public string name { get; set; }

        public bool billable { get; set; }

        public int billing_type_id { get; set; }

        [StringLength(255)]
        public string po_number { get; set; }

        [Column(TypeName = "money")]
        public decimal? po_remaining_amount { get; set; }

        public bool active { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public double? current_scope { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public double? current_effort { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public double? exceeding { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<project> projects { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<scope_exceeding> scope_exceeding { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<service_scope> service_scope { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<service_owner> service_owner { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<service_scope_default> service_scope_default { get; set; }

        public virtual service_billing_type service_billing_type { get; set; }
    }
}
