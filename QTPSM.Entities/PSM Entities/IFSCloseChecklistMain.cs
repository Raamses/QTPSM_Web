namespace QTPSM.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("IFSCloseChecklistMain")]
    public partial class IFSCloseChecklistMain :IEntityBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IFSCloseChecklistMain()
        {
            IFSCloseChecklistChilds = new HashSet<IFSCloseChecklistChild>();
        }

        [Column("ID")]
        public int id { get; set; }

        [Required]
        [StringLength(250)]
        public string StepName { get; set; }

        [Required]
        [StringLength(50)]
        public string StepNumber { get; set; }

        public bool Active { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IFSCloseChecklistChild> IFSCloseChecklistChilds { get; set; }
    }
}
