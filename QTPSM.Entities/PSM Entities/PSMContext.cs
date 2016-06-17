namespace QTPSM.Entities
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class PSMContext : DbContext
    {
        public PSMContext()
            : base("name=PSM")
        {
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
        }

        public virtual DbSet<CibusQueue> CibusQueues { get; set; }
        public virtual DbSet<employee> employees { get; set; }
        public virtual DbSet<engineer> engineers { get; set; }
        public virtual DbSet<finance_period> finance_period { get; set; }
        public virtual DbSet<FoodStampsRequest> FoodStampsRequests { get; set; }
        public virtual DbSet<IFSCloseChecklistAttachment> IFSCloseChecklistAttachments { get; set; }
        public virtual DbSet<IFSCloseChecklistChild> IFSCloseChecklistChilds { get; set; }
        public virtual DbSet<IFSCloseChecklistMain> IFSCloseChecklistMains { get; set; }
        public virtual DbSet<internal_teams_name> internal_teams_name { get; set; }
        public virtual DbSet<months_order> months_order { get; set; }
        public virtual DbSet<PowerMatTicket> PowerMatTickets { get; set; }
        public virtual DbSet<project> projects { get; set; }
        public virtual DbSet<project_engineer> project_engineer { get; set; }
        public virtual DbSet<project_engineer_relation_type> project_engineer_relation_type { get; set; }
        public virtual DbSet<RolePermission> RolePermissions { get; set; }
        public virtual DbSet<scope_exceeding> scope_exceeding { get; set; }
        public virtual DbSet<scope_exceeding_status> scope_exceeding_status { get; set; }
        public virtual DbSet<Server> Servers { get; set; }
        public virtual DbSet<service> services { get; set; }
        public virtual DbSet<service_billing_type> service_billing_type { get; set; }
        public virtual DbSet<service_owner> service_owner { get; set; }
        public virtual DbSet<service_scope> service_scope { get; set; }
        public virtual DbSet<service_scope_default> service_scope_default { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<work_item_type> work_item_type { get; set; }
        public virtual DbSet<workitem> workitems { get; set; }
        public virtual DbSet<workitem_attachment> workitem_attachment { get; set; }
        public virtual DbSet<workitem_log> workitem_log { get; set; }
        public virtual DbSet<workitem_priority> workitem_priority { get; set; }
        public virtual DbSet<workitem_status> workitem_status { get; set; }
        public virtual DbSet<workitem_test> workitem_test { get; set; }
        public virtual DbSet<effort_per_engineer_and_fp> effort_per_engineer_and_fp { get; set; }
        public virtual DbSet<vw_CustomerReports> vw_CustomerReports { get; set; }
        public virtual DbSet<vw_Customers> vw_Customers { get; set; }
        public virtual DbSet<vw_Exceedings> vw_Exceedings { get; set; }
        public virtual DbSet<vw_ProjectOwnership> vw_ProjectOwnership { get; set; }
        public virtual DbSet<vw_ServiceExceedings> vw_ServiceExceedings { get; set; }
        public virtual DbSet<vw_TicketsByEmployee> vw_TicketsByEmployee { get; set; }
        public virtual DbSet<Error> Error { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<employee>()
                .HasMany(e => e.engineers)
                .WithRequired(e => e.employee)
                .HasForeignKey(e => e.employee_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<employee>()
                .HasMany(e => e.service_owner)
                .WithRequired(e => e.employee)
                .HasForeignKey(e => e.owner_employee_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<engineer>()
                .HasMany(e => e.CibusQueues)
                .WithRequired(e => e.engineer)
                .HasForeignKey(e => e.engineer_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<engineer>()
                .HasMany(e => e.FoodStampsRequests)
                .WithRequired(e => e.engineer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<engineer>()
                .HasMany(e => e.IFSCloseChecklistChilds)
                .WithRequired(e => e.engineer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<engineer>()
                .HasMany(e => e.PowerMatTickets)
                .WithRequired(e => e.engineer)
                .HasForeignKey(e => e.CallTakerID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<engineer>()
                .HasMany(e => e.project_engineer)
                .WithRequired(e => e.engineer)
                .HasForeignKey(e => e.engineer_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<engineer>()
                .HasMany(e => e.workitems)
                .WithOptional(e => e.engineer)
                .HasForeignKey(e => e.engineer_id);

            modelBuilder.Entity<engineer>()
                .HasMany(e => e.workitem_log)
                .WithRequired(e => e.engineer)
                .HasForeignKey(e => e.engineer_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<finance_period>()
                .HasMany(e => e.service_scope)
                .WithRequired(e => e.finance_period)
                .HasForeignKey(e => e.finance_period_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<finance_period>()
                .HasMany(e => e.scope_exceeding)
                .WithRequired(e => e.finance_period)
                .HasForeignKey(e => e.finance_period_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IFSCloseChecklistMain>()
                .HasMany(e => e.IFSCloseChecklistChilds)
                .WithRequired(e => e.IFSCloseChecklistMain)
                .HasForeignKey(e => e.ParentID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<internal_teams_name>()
                .HasMany(e => e.engineers)
                .WithOptional(e => e.internal_teams_name)
                .HasForeignKey(e => e.internal_team_id);

            modelBuilder.Entity<project>()
                .HasMany(e => e.project_engineer)
                .WithRequired(e => e.project)
                .HasForeignKey(e => e.project_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<project>()
                .HasMany(e => e.workitems)
                .WithRequired(e => e.project)
                .HasForeignKey(e => e.project_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<project_engineer_relation_type>()
                .HasMany(e => e.project_engineer)
                .WithRequired(e => e.project_engineer_relation_type)
                .HasForeignKey(e => e.relation_type_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<scope_exceeding_status>()
                .HasMany(e => e.scope_exceeding)
                .WithRequired(e => e.scope_exceeding_status)
                .HasForeignKey(e => e.status_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<service>()
                .Property(e => e.po_remaining_amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<service>()
                .HasMany(e => e.projects)
                .WithRequired(e => e.service)
                .HasForeignKey(e => e.service_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<service>()
                .HasMany(e => e.scope_exceeding)
                .WithRequired(e => e.service)
                .HasForeignKey(e => e.service_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<service>()
                .HasMany(e => e.service_scope)
                .WithRequired(e => e.service)
                .HasForeignKey(e => e.service_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<service>()
                .HasMany(e => e.service_owner)
                .WithRequired(e => e.service)
                .HasForeignKey(e => e.service_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<service>()
                .HasMany(e => e.service_scope_default)
                .WithRequired(e => e.service)
                .HasForeignKey(e => e.service_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<service_billing_type>()
                .HasMany(e => e.services)
                .WithRequired(e => e.service_billing_type)
                .HasForeignKey(e => e.billing_type_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<work_item_type>()
                .HasMany(e => e.workitems)
                .WithRequired(e => e.work_item_type)
                .HasForeignKey(e => e.type_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<workitem>()
                .HasMany(e => e.workitem_attachment)
                .WithRequired(e => e.workitem)
                .HasForeignKey(e => e.workitem_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<workitem>()
                .HasMany(e => e.workitem_log)
                .WithRequired(e => e.workitem)
                .HasForeignKey(e => e.workitem_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<workitem_priority>()
                .HasMany(e => e.workitems)
                .WithOptional(e => e.workitem_priority)
                .HasForeignKey(e => e.priority_id);

            modelBuilder.Entity<workitem_status>()
                .HasMany(e => e.workitems)
                .WithRequired(e => e.workitem_status)
                .HasForeignKey(e => e.status_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<vw_Customers>()
                .Property(e => e.LongID)
                .IsUnicode(false);

            modelBuilder.Entity<vw_Customers>()
                .Property(e => e.upperIDSID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<vw_Customers>()
                .Property(e => e.WWID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<vw_ServiceExceedings>()
                .Property(e => e.ExceedingRequestedExists)
                .IsUnicode(false);

            modelBuilder.Entity<vw_ServiceExceedings>()
                .Property(e => e.IsActive)
                .IsUnicode(false);
        }
    }
}
