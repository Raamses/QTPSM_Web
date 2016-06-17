namespace QTPSM.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CibusQueue")]
    public partial class CibusQueue : IEntityBase
    {
        public int id { get; set; }

        public int engineer_id { get; set; }

        [Column(TypeName = "date")]
        public DateTime timestamp { get; set; }

        public bool active { get; set; }

        public virtual engineer engineer { get; set; }
    }
}
