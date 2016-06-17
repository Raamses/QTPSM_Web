namespace QTPSM.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class workitem_attachment :IEntityBase
    {
        public int id { get; set; }

        public int workitem_id { get; set; }

        [Required]
        [StringLength(255)]
        public string filename { get; set; }

        [Required]
        public byte[] data { get; set; }

        public virtual workitem workitem { get; set; }
    }
}
