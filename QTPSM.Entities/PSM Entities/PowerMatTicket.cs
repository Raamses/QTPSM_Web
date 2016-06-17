namespace QTPSM.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PowerMatTicket : IEntityBase
    {
        [Column("ID")]
        public int id { get; set; }

        public DateTime DateOpened { get; set; }

        [Required]
        [StringLength(20)]
        public string CustomerNumber { get; set; }

        [Required]
        [StringLength(250)]
        public string CustomerName { get; set; }

        [Required]
        [StringLength(250)]
        public string StoreID { get; set; }

        [Required]
        [StringLength(250)]
        public string StoreName { get; set; }

        [Required]
        [StringLength(50)]
        public string ChargingSpotID { get; set; }

        [Required]
        [StringLength(50)]
        public string TicketStatus { get; set; }

        [Required]
        [StringLength(50)]
        public string CallType { get; set; }

        [Required]
        public string ProblemDescription { get; set; }

        [Required]
        public string ProblemDetails { get; set; }

        public int CallTakerID { get; set; }

        [Required]
        [StringLength(250)]
        public string ContasctPerson { get; set; }

        [Required]
        [StringLength(250)]
        public string ContactPersonPhone { get; set; }

        [Required]
        [StringLength(50)]
        public string SurfacelocationID { get; set; }

        [Required]
        [StringLength(50)]
        public string CSLocationID { get; set; }

        public bool MovingTable { get; set; }

        public double effort { get; set; }

        public virtual engineer engineer { get; set; }
    }
}
