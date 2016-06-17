namespace QTPSM.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("IFSCloseChecklistChild")]
    public partial class IFSCloseChecklistChild :IEntityBase
    {
        [Column("ID")]
        public int id { get; set; }

        public int ParentID { get; set; }

        [Required]
        [StringLength(250)]
        public string StepName { get; set; }

        [Required]
        [StringLength(50)]
        public string StepNumber { get; set; }

        public bool Result { get; set; }

        [Column(TypeName = "date")]
        public DateTime Timestamp { get; set; }

        public int EngineerID { get; set; }

        public Guid GUID { get; set; }

        public virtual engineer engineer { get; set; }

        public virtual IFSCloseChecklistMain IFSCloseChecklistMain { get; set; }
    }
}
