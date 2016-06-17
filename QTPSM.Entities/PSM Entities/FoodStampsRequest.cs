namespace QTPSM.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FoodStampsRequest")]
    public partial class FoodStampsRequest : IEntityBase
    {
        [Column("ID")]
        public int id { get; set; }

        public int engineerID { get; set; }

        [Column(TypeName = "date")]
        public DateTime timeStamp { get; set; }

        public int quantity { get; set; }

        public bool isApproved { get; set; }

        public bool isReceived { get; set; }

        public virtual engineer engineer { get; set; }
    }
}
