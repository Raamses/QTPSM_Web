namespace QTPSM.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class project_engineer : IEntityBase
    {
        public int id { get; set; }

        public int project_id { get; set; }

        public int engineer_id { get; set; }

        public int relation_type_id { get; set; }

        public virtual engineer engineer { get; set; }

        public virtual project project { get; set; }

        public virtual project_engineer_relation_type project_engineer_relation_type { get; set; }
    }
}
