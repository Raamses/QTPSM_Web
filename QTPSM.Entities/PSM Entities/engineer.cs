namespace QTPSM.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("engineer")]
    public partial class engineer : IEntityBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public engineer()
        {
            CibusQueues = new HashSet<CibusQueue>();
            FoodStampsRequests = new HashSet<FoodStampsRequest>();
            IFSCloseChecklistChilds = new HashSet<IFSCloseChecklistChild>();
            PowerMatTickets = new HashSet<PowerMatTicket>();
            project_engineer = new HashSet<project_engineer>();
            workitems = new HashSet<workitem>();
            workitem_log = new HashSet<workitem_log>();
        }

        public int id { get; set; }

        public int employee_id { get; set; }

        public bool active { get; set; }

        public int? internal_team_id { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [StringLength(255)]
        public string full_name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CibusQueue> CibusQueues { get; set; }

        public virtual employee employee { get; set; }

        public virtual internal_teams_name internal_teams_name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FoodStampsRequest> FoodStampsRequests { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IFSCloseChecklistChild> IFSCloseChecklistChilds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PowerMatTicket> PowerMatTickets { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<project_engineer> project_engineer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<workitem> workitems { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<workitem_log> workitem_log { get; set; }
    }
}
