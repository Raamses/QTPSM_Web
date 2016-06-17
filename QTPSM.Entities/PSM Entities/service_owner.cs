namespace QTPSM.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class service_owner : IEntityBase
    {
        public int id { get; set; }

        public int service_id { get; set; }

        public int owner_employee_id { get; set; }

        public virtual employee employee { get; set; }

        public virtual service service { get; set; }
    }
}
