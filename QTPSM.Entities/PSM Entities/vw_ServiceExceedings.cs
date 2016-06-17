namespace QTPSM.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vw_ServiceExceedings
    {
        public long? RowID { get; set; }

        [StringLength(255)]
        public string ServiceName { get; set; }

        [StringLength(255)]
        public string BillingType { get; set; }

        public int? SR_Number { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Scope { get; set; }

        public double? Effort { get; set; }

        public int? WorkItemsAmount { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(3)]
        public string ExceedingRequestedExists { get; set; }

        [StringLength(257)]
        public string ExceedingApprovalRatio { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(3)]
        public string IsActive { get; set; }
    }
}
