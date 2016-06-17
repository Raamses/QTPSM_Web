namespace QTPSM.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RolePermission
    {
        [Key]
        [Column(Order = 0)]
        public string RoleName { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(322)]
        public string PermissionId { get; set; }
    }
}
