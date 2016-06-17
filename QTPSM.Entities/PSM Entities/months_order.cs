namespace QTPSM.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class months_order : IEntityBase
    {
        public int id { get; set; }

        [Required]
        [StringLength(255)]
        public string month_name { get; set; }

        public byte order_value { get; set; }
    }
}
