namespace QTPSM.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vw_Customers
    {
        [StringLength(65)]
        public string LongID { get; set; }

        [StringLength(8)]
        public string upperIDSID { get; set; }

        [Key]
        [StringLength(8)]
        public string WWID { get; set; }
    }
}
