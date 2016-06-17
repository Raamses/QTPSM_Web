namespace QTPSM.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Server : IEntityBase
    {
        [Column("ID")]
        public int id { get; set; }

        [Required]
        [StringLength(255)]
        public string ServerName { get; set; }

        [StringLength(500)]
        public string Purpose { get; set; }

        [Required]
        [StringLength(50)]
        public string Environment { get; set; }

        [Required]
        [StringLength(50)]
        public string Status { get; set; }

        public bool? Activate { get; set; }

        [StringLength(50)]
        public string IpAddress { get; set; }

        [StringLength(250)]
        public string OperatingSystem { get; set; }

        [StringLength(250)]
        public string SQLVersion { get; set; }

        [StringLength(250)]
        public string IISVersion { get; set; }

        [StringLength(50)]
        public string MachineType { get; set; }

        [StringLength(250)]
        public string DataCenter { get; set; }
    }
}
