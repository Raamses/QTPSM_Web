namespace QTPSM.Entities.CDIS_Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CampusPublicExt")]
    public partial class CampusPublicExt : IEntityBase
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(4)]
        public string CampusCode { get; set; }

        [StringLength(30)]
        public string CampusDescr { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(2)]
        public string SiteCode { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(1)]
        public string CampusStatusCode { get; set; }

        public int id { get; set; }
    }
}
