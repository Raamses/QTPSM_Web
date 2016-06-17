namespace QTPSM.Entities.CDIS_Entities
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CDISContext : DbContext
    {
        public CDISContext()
            : base("name=CDIS")
        {
        }

        public virtual DbSet<CampusPublicExt> CampusPublicExts { get; set; }
        public virtual DbSet<WorkerPublic> WorkerPublics { get; set; }
        public virtual DbSet<WorkerPublicExtended> WorkerPublicExtendeds { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CampusPublicExt>()
                .Property(e => e.CampusCode)
                .IsUnicode(false);

            modelBuilder.Entity<CampusPublicExt>()
                .Property(e => e.CampusDescr)
                .IsUnicode(false);

            modelBuilder.Entity<CampusPublicExt>()
                .Property(e => e.SiteCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CampusPublicExt>()
                .Property(e => e.CampusStatusCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublic>()
                .Property(e => e.Agency)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublic>()
                .Property(e => e.BadgeType)
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublic>()
                .Property(e => e.BusTitle)
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublic>()
                .Property(e => e.CampusCode)
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublic>()
                .Property(e => e.ccMailName)
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublic>()
                .Property(e => e.ccMailPO)
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublic>()
                .Property(e => e.CellNum)
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublic>()
                .Property(e => e.DataSourceName)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublic>()
                .Property(e => e.Degree)
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublic>()
                .Property(e => e.Department)
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublic>()
                .Property(e => e.DeptCode)
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublic>()
                .Property(e => e.DeptFuncCode)
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublic>()
                .Property(e => e.DirectLaborCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublic>()
                .Property(e => e.DomainAddress)
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublic>()
                .Property(e => e.EmpNo)
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublic>()
                .Property(e => e.EmpTypeCode)
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublic>()
                .Property(e => e.EntityCode)
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublic>()
                .Property(e => e.FaxNum)
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublic>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublic>()
                .Property(e => e.FLSA)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublic>()
                .Property(e => e.FullPartTimeInd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublic>()
                .Property(e => e.GENIEmpClassCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublic>()
                .Property(e => e.GENIEmpStatus)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublic>()
                .Property(e => e.HomeCompanyCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublic>()
                .Property(e => e.HomePageURL)
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublic>()
                .Property(e => e.HrdName)
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublic>()
                .Property(e => e.HrdWWID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublic>()
                .Property(e => e.In_ExpatTypeCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublic>()
                .Property(e => e.MandACompany)
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublic>()
                .Property(e => e.Initials)
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublic>()
                .Property(e => e.InpatHomeBldgCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublic>()
                .Property(e => e.JobfamilyCode)
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublic>()
                .Property(e => e.JobfamilyDescr)
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublic>()
                .Property(e => e.JobTypeCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublic>()
                .Property(e => e.LaborCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublic>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublic>()
                .Property(e => e.Location)
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublic>()
                .Property(e => e.LocCountryCode)
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublic>()
                .Property(e => e.LocCountryName)
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublic>()
                .Property(e => e.LongID)
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublic>()
                .Property(e => e.MailStop)
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublic>()
                .Property(e => e.MAJOR_CD)
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublic>()
                .Property(e => e.MAJOR_DESCR)
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublic>()
                .Property(e => e.MGR_LVL_JOB)
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublic>()
                .Property(e => e.MgrName)
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublic>()
                .Property(e => e.MgrWWID)
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublic>()
                .Property(e => e.MiddleInitial)
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublic>()
                .Property(e => e.MsgNum)
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublic>()
                .Property(e => e.NickName)
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublic>()
                .Property(e => e.OfficeLoc)
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublic>()
                .Property(e => e.OrgUnitCode)
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublic>()
                .Property(e => e.OrgUnitDescr)
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublic>()
                .Property(e => e.OrigHomeCountryCode)
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublic>()
                .Property(e => e.OrigHomeCountryName)
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublic>()
                .Property(e => e.PagerNum)
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublic>()
                .Property(e => e.PhoneNum)
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublic>()
                .Property(e => e.RegionCode)
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublic>()
                .Property(e => e.RegTempFlag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublic>()
                .Property(e => e.SchedTypeCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublic>()
                .Property(e => e.ShiftCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublic>()
                .Property(e => e.ShortID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublic>()
                .Property(e => e.StatCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublic>()
                .Property(e => e.TransferFlag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublic>()
                .Property(e => e.upperIDSID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublic>()
                .Property(e => e.BldgCode)
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublic>()
                .Property(e => e.SiteCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublic>()
                .Property(e => e.WWID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublic>()
                .Property(e => e.WorkerCompCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublic>()
                .Property(e => e.WorldTypeCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublic>()
                .Property(e => e.FTE_COUNT)
                .HasPrecision(4, 1);

            modelBuilder.Entity<WorkerPublic>()
                .Property(e => e.HEADCOUNT_TYPE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublic>()
                .Property(e => e.GL_SUPER_GROUP_CODE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublic>()
                .Property(e => e.GL_SUPER_GROUP_DESCR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublic>()
                .Property(e => e.GL_COMPANY_CODE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublic>()
                .Property(e => e.GL_GROUP_CODE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublic>()
                .Property(e => e.GL_GROUP_DESCR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublic>()
                .Property(e => e.GL_DIVISION_CODE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublic>()
                .Property(e => e.GL_DIVISION_DESCR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublic>()
                .Property(e => e.GL_PROFIT_CENTER_CODE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublic>()
                .Property(e => e.GL_PROFIT_CENTER_DESCR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublic>()
                .Property(e => e.GL_COST_CENTER_CODE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublic>()
                .Property(e => e.GL_COST_CENTER_DESCR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublic>()
                .Property(e => e.GL_FUNCTIONAL_AREA)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublic>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublic>()
                .Property(e => e.ExportCountryCode)
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublic>()
                .Property(e => e.ExportCountryGroup)
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublicExtended>()
                .Property(e => e.Agency)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublicExtended>()
                .Property(e => e.BadgeType)
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublicExtended>()
                .Property(e => e.BusTitle)
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublicExtended>()
                .Property(e => e.CampusCode)
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublicExtended>()
                .Property(e => e.ccMailName)
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublicExtended>()
                .Property(e => e.ccMailPO)
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublicExtended>()
                .Property(e => e.CellNum)
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublicExtended>()
                .Property(e => e.DataSourceName)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublicExtended>()
                .Property(e => e.Degree)
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublicExtended>()
                .Property(e => e.Department)
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublicExtended>()
                .Property(e => e.DeptCode)
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublicExtended>()
                .Property(e => e.DeptFuncCode)
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublicExtended>()
                .Property(e => e.DirectLaborCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublicExtended>()
                .Property(e => e.DomainAddress)
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublicExtended>()
                .Property(e => e.EmpNo)
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublicExtended>()
                .Property(e => e.EmpTypeCode)
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublicExtended>()
                .Property(e => e.EntityCode)
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublicExtended>()
                .Property(e => e.FaxNum)
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublicExtended>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublicExtended>()
                .Property(e => e.FLSA)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublicExtended>()
                .Property(e => e.FullPartTimeInd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublicExtended>()
                .Property(e => e.GENIEmpClassCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublicExtended>()
                .Property(e => e.GENIEmpStatus)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublicExtended>()
                .Property(e => e.HomeCompanyCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublicExtended>()
                .Property(e => e.HomePageURL)
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublicExtended>()
                .Property(e => e.HrdName)
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublicExtended>()
                .Property(e => e.HrdWWID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublicExtended>()
                .Property(e => e.In_ExpatTypeCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublicExtended>()
                .Property(e => e.MandACompany)
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublicExtended>()
                .Property(e => e.Initials)
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublicExtended>()
                .Property(e => e.InpatHomeBldgCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublicExtended>()
                .Property(e => e.JobfamilyCode)
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublicExtended>()
                .Property(e => e.JobfamilyDescr)
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublicExtended>()
                .Property(e => e.JobTypeCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublicExtended>()
                .Property(e => e.LaborCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublicExtended>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublicExtended>()
                .Property(e => e.Location)
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublicExtended>()
                .Property(e => e.LocCountryCode)
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublicExtended>()
                .Property(e => e.LocCountryName)
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublicExtended>()
                .Property(e => e.LongID)
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublicExtended>()
                .Property(e => e.MailStop)
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublicExtended>()
                .Property(e => e.MAJOR_CD)
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublicExtended>()
                .Property(e => e.MAJOR_DESCR)
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublicExtended>()
                .Property(e => e.MGR_LVL_JOB)
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublicExtended>()
                .Property(e => e.MgrName)
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublicExtended>()
                .Property(e => e.MgrWWID)
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublicExtended>()
                .Property(e => e.MiddleInitial)
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublicExtended>()
                .Property(e => e.MsgNum)
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublicExtended>()
                .Property(e => e.NickName)
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublicExtended>()
                .Property(e => e.OfficeLoc)
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublicExtended>()
                .Property(e => e.OrgUnitCode)
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublicExtended>()
                .Property(e => e.OrgUnitDescr)
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublicExtended>()
                .Property(e => e.OrigHomeCountryCode)
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublicExtended>()
                .Property(e => e.OrigHomeCountryName)
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublicExtended>()
                .Property(e => e.PagerNum)
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublicExtended>()
                .Property(e => e.PhoneNum)
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublicExtended>()
                .Property(e => e.RegionCode)
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublicExtended>()
                .Property(e => e.RegTempFlag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublicExtended>()
                .Property(e => e.SchedTypeCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublicExtended>()
                .Property(e => e.ShiftCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublicExtended>()
                .Property(e => e.ShortID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublicExtended>()
                .Property(e => e.StatCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublicExtended>()
                .Property(e => e.TransferFlag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublicExtended>()
                .Property(e => e.upperIDSID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublicExtended>()
                .Property(e => e.BldgCode)
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublicExtended>()
                .Property(e => e.SiteCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublicExtended>()
                .Property(e => e.WWID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublicExtended>()
                .Property(e => e.WorkerCompCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublicExtended>()
                .Property(e => e.WorldTypeCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublicExtended>()
                .Property(e => e.FTE_COUNT)
                .HasPrecision(4, 1);

            modelBuilder.Entity<WorkerPublicExtended>()
                .Property(e => e.HEADCOUNT_TYPE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublicExtended>()
                .Property(e => e.GL_SUPER_GROUP_CODE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublicExtended>()
                .Property(e => e.GL_SUPER_GROUP_DESCR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublicExtended>()
                .Property(e => e.GL_COMPANY_CODE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublicExtended>()
                .Property(e => e.GL_GROUP_CODE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublicExtended>()
                .Property(e => e.GL_GROUP_DESCR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublicExtended>()
                .Property(e => e.GL_DIVISION_CODE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublicExtended>()
                .Property(e => e.GL_DIVISION_DESCR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublicExtended>()
                .Property(e => e.GL_PROFIT_CENTER_CODE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublicExtended>()
                .Property(e => e.GL_PROFIT_CENTER_DESCR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublicExtended>()
                .Property(e => e.GL_COST_CENTER_CODE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublicExtended>()
                .Property(e => e.GL_COST_CENTER_DESCR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublicExtended>()
                .Property(e => e.GL_FUNCTIONAL_AREA)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublicExtended>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublicExtended>()
                .Property(e => e.ExportCountryCode)
                .IsUnicode(false);

            modelBuilder.Entity<WorkerPublicExtended>()
                .Property(e => e.ExportCountryGroup)
                .IsUnicode(false);
        }
    }
}
