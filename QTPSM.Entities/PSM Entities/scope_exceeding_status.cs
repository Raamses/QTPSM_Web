namespace QTPSM.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class scope_exceeding_status : IEntityBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public scope_exceeding_status()
        {
            scope_exceeding = new HashSet<scope_exceeding>();
        }

        public int id { get; set; }

        public int status_order { get; set; }

        [StringLength(50)]
        public string status_name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<scope_exceeding> scope_exceeding { get; set; }
    }
}
