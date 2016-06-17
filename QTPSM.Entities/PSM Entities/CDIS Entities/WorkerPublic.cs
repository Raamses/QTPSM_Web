namespace QTPSM.Entities.CDIS_Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WorkerPublic")]
    public partial class WorkerPublic : IEntityBase
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(30)]
        public string Agency { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(2)]
        public string BadgeType { get; set; }

        [StringLength(30)]
        public string BusTitle { get; set; }

        [StringLength(4)]
        public string CampusCode { get; set; }

        [StringLength(80)]
        public string ccMailName { get; set; }

        [StringLength(40)]
        public string ccMailPO { get; set; }

        [StringLength(25)]
        public string CellNum { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(6)]
        public string DataSourceName { get; set; }

        [StringLength(7)]
        public string Degree { get; set; }

        [StringLength(10)]
        public string Department { get; set; }

        public DateTime? DeptChgDate { get; set; }

        [StringLength(4)]
        public string DeptCode { get; set; }

        [StringLength(1)]
        public string DeptFuncCode { get; set; }

        [StringLength(1)]
        public string DirectLaborCode { get; set; }

        [StringLength(80)]
        public string DomainAddress { get; set; }

        [StringLength(9)]
        public string EmpNo { get; set; }

        [StringLength(3)]
        public string EmpTypeCode { get; set; }

        [StringLength(3)]
        public string EntityCode { get; set; }

        [StringLength(25)]
        public string FaxNum { get; set; }

        [StringLength(30)]
        public string FirstName { get; set; }

        [StringLength(1)]
        public string FLSA { get; set; }

        [StringLength(1)]
        public string FullPartTimeInd { get; set; }

        [StringLength(1)]
        public string GENIEmpClassCode { get; set; }

        [StringLength(1)]
        public string GENIEmpStatus { get; set; }

        [StringLength(3)]
        public string HomeCompanyCode { get; set; }

        [StringLength(250)]
        public string HomePageURL { get; set; }

        [StringLength(50)]
        public string HrdName { get; set; }

        [StringLength(8)]
        public string HrdWWID { get; set; }

        [StringLength(2)]
        public string In_ExpatTypeCode { get; set; }

        [StringLength(3)]
        public string MandACompany { get; set; }

        [StringLength(2)]
        public string Initials { get; set; }

        [StringLength(6)]
        public string InpatHomeBldgCode { get; set; }

        [StringLength(6)]
        public string JobfamilyCode { get; set; }

        [StringLength(30)]
        public string JobfamilyDescr { get; set; }

        [StringLength(1)]
        public string JobTypeCode { get; set; }

        [StringLength(1)]
        public string LaborCode { get; set; }

        public int? LastChgCode { get; set; }

        public DateTime? LastHireDate { get; set; }

        [StringLength(30)]
        public string LastName { get; set; }

        public DateTime? LastUpdateDate { get; set; }

        public int? LengthOfService { get; set; }

        [StringLength(34)]
        public string Location { get; set; }

        [StringLength(3)]
        public string LocCountryCode { get; set; }

        [StringLength(35)]
        public string LocCountryName { get; set; }

        [StringLength(65)]
        public string LongID { get; set; }

        [StringLength(50)]
        public string MailStop { get; set; }

        [StringLength(10)]
        public string MAJOR_CD { get; set; }

        [StringLength(30)]
        public string MAJOR_DESCR { get; set; }

        [StringLength(2)]
        public string MGR_LVL_JOB { get; set; }

        [StringLength(50)]
        public string MgrName { get; set; }

        [StringLength(8)]
        public string MgrWWID { get; set; }

        [StringLength(2)]
        public string MiddleInitial { get; set; }

        [StringLength(25)]
        public string MsgNum { get; set; }

        [StringLength(12)]
        public string NickName { get; set; }

        [StringLength(25)]
        public string OfficeLoc { get; set; }

        [StringLength(10)]
        public string OrgUnitCode { get; set; }

        public DateTime? OrgUnitDate { get; set; }

        [StringLength(30)]
        public string OrgUnitDescr { get; set; }

        [StringLength(3)]
        public string OrigHomeCountryCode { get; set; }

        [StringLength(35)]
        public string OrigHomeCountryName { get; set; }

        public DateTime? OriginalHireDate { get; set; }

        [StringLength(25)]
        public string PagerNum { get; set; }

        [StringLength(25)]
        public string PhoneNum { get; set; }

        [StringLength(4)]
        public string RegionCode { get; set; }

        [StringLength(1)]
        public string RegTempFlag { get; set; }

        public DateTime? SabbaticalBeginDt { get; set; }

        public DateTime? SabbaticalEndDt { get; set; }

        [StringLength(2)]
        public string SchedTypeCode { get; set; }

        public DateTime? ServicDt { get; set; }

        [StringLength(2)]
        public string ShiftCode { get; set; }

        [StringLength(8)]
        public string ShortID { get; set; }

        [StringLength(1)]
        public string StatCode { get; set; }

        public DateTime? StatDate { get; set; }

        public DateTime? TermDate { get; set; }

        [StringLength(1)]
        public string TransferFlag { get; set; }

        [StringLength(8)]
        public string upperIDSID { get; set; }

        [StringLength(5)]
        public string BldgCode { get; set; }

        [StringLength(2)]
        public string SiteCode { get; set; }

        [StringLength(8)]
        public string WWID { get; set; }

        [StringLength(4)]
        public string WorkerCompCode { get; set; }

        [StringLength(1)]
        public string WorldTypeCode { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "numeric")]
        public decimal FTE_COUNT { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(3)]
        public string HEADCOUNT_TYPE { get; set; }

        [StringLength(8)]
        public string GL_SUPER_GROUP_CODE { get; set; }

        [StringLength(40)]
        public string GL_SUPER_GROUP_DESCR { get; set; }

        [StringLength(4)]
        public string GL_COMPANY_CODE { get; set; }

        [StringLength(8)]
        public string GL_GROUP_CODE { get; set; }

        [StringLength(40)]
        public string GL_GROUP_DESCR { get; set; }

        [StringLength(8)]
        public string GL_DIVISION_CODE { get; set; }

        [StringLength(40)]
        public string GL_DIVISION_DESCR { get; set; }

        [StringLength(10)]
        public string GL_PROFIT_CENTER_CODE { get; set; }

        [StringLength(40)]
        public string GL_PROFIT_CENTER_DESCR { get; set; }

        [StringLength(10)]
        public string GL_COST_CENTER_CODE { get; set; }

        [StringLength(40)]
        public string GL_COST_CENTER_DESCR { get; set; }

        [StringLength(3)]
        public string GL_FUNCTIONAL_AREA { get; set; }

        [StringLength(30)]
        public string Title { get; set; }

        [StringLength(1)]
        public string ExportCountryCode { get; set; }

        [StringLength(30)]
        public string ExportCountryGroup { get; set; }

        public DateTime? CDISTermDate { get; set; }

        public int id { get; set; }
    }
}
