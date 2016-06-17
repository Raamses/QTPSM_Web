namespace QTPSM.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("employee")]
    public partial class employee : IEntityBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public employee()
        {
            engineers = new HashSet<engineer>();
            service_owner = new HashSet<service_owner>();
        }

        public int id { get; set; }

        public int wwid { get; set; }

        [StringLength(50)]
        public string lowered_domain { get; set; }

        [StringLength(50)]
        public string lowered_user_name { get; set; }

        [StringLength(254)]
        public string full_name { get; set; }

        [StringLength(254)]
        public string email_address { get; set; }

        public byte[] photo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<engineer> engineers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<service_owner> service_owner { get; set; }
    }
}
