namespace QTPSM.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vw_TicketsByEmployee
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int wwid { get; set; }

        [StringLength(254)]
        public string full_name { get; set; }

        [StringLength(255)]
        public string submitter_name { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime submit_date { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(255)]
        public string type_name { get; set; }

        [StringLength(255)]
        public string status_title { get; set; }

        [StringLength(254)]
        public string name { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(100)]
        public string summary { get; set; }
    }
}
