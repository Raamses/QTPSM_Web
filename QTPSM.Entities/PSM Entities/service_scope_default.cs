namespace QTPSM.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class service_scope_default :IEntityBase
    {
        public int id { get; set; }

        public int service_id { get; set; }

        public int scope { get; set; }

        public virtual service service { get; set; }
    }
}
