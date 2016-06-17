namespace QTPSM.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class IFSCloseChecklistAttachment : IEntityBase
    {
        [Column("ID")]
        public int id { get; set; }

        public byte[] attachmentData { get; set; }

        [StringLength(500)]
        public string comments { get; set; }

        [StringLength(250)]
        public string attachmentName { get; set; }

        public Guid? GUID { get; set; }

        public DateTime timestamp { get; set; }
    }
}
