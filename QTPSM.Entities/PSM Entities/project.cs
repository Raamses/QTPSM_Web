namespace QTPSM.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("project")]
    public partial class project : IEntityBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public project()
        {
            project_engineer = new HashSet<project_engineer>();
            workitems = new HashSet<workitem>();
        }

        public int id { get; set; }

        public int service_id { get; set; }

        [StringLength(254)]
        public string name { get; set; }

        public bool active { get; set; }

        public double? maintenance { get; set; }

        public double? retainer { get; set; }

        public bool retainer_father_or_child { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<project_engineer> project_engineer { get; set; }

        public virtual service service { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<workitem> workitems { get; set; }
    }
}
