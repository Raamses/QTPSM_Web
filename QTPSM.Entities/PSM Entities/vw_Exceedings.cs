namespace QTPSM.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vw_Exceedings
    {
        [Key]
        [Column(Order = 0)]
        public int RowID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ServiceID { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(255)]
        public string ServiceName { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(25)]
        public string BillingType { get; set; }

        [StringLength(25)]
        public string SRNumber { get; set; }

        public int? Scope { get; set; }

        public double? Effort { get; set; }

        public int? WorkItemsAmount { get; set; }

        public int? finance_period_id { get; set; }

        [StringLength(50)]
        public string Finance_Period_Name { get; set; }
    }
}
