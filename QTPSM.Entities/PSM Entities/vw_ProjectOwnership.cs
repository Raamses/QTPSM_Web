namespace QTPSM.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vw_ProjectOwnership
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProjectID { get; set; }

        [StringLength(254)]
        public string ProjectName { get; set; }

        [Key]
        [Column(Order = 1)]
        public bool Active { get; set; }

        public int? EngineerID { get; set; }

        public int? EmplyeeID { get; set; }

        [StringLength(254)]
        public string EngineerName { get; set; }

        public int? RelationTypeID { get; set; }

        [StringLength(255)]
        public string RelationTypeName { get; set; }
    }
}
