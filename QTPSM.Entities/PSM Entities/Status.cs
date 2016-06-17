namespace QTPSM.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Status : IEntityBase
    {
        [Column("StatusID")]
        public int id { get; set; }

        [Required]
        public string Status_Name { get; set; }
    }
}
