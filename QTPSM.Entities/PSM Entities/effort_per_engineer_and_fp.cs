namespace QTPSM.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class effort_per_engineer_and_fp : IEntityBase
    {
        [Key]
        [Column("engineer_id", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(254)]
        public string engineer_full_name { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string finance_period_name { get; set; }

        [Key]
        [Column(Order = 3)]
        public double effort { get; set; }

        [Key]
        [Column(Order = 4)]
        public double BillableEffort { get; set; }

        [Key]
        [Column(Order = 5)]
        public double NonBillableEffort { get; set; }

        public double? BillablePercentage { get; set; }

        [Key]
        [Column(Order = 6)]
        public double DailyTotalEffort { get; set; }

        [Key]
        [Column(Order = 7)]
        public double DailyBillableEffort { get; set; }

        [Key]
        [Column(Order = 8)]
        public double DailyNonBillableEffort { get; set; }
    }
}
