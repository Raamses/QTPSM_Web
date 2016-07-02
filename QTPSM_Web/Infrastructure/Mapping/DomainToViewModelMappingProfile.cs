using AutoMapper;
using QTPSM.Entities;
using QTPSM_Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QTPSM_Web.Infrastructure.Mapping
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }


        protected override void Configure()
        {
            Mapper.Initialize(
                cfg =>
                {
                    cfg.CreateMap<effort_per_engineer_and_fp, effort_per_engineer_and_fpViewModel>()
        .ForMember(vm => vm.BillableEffort, map => map.MapFrom(m => m.BillableEffort))
                   .ForMember(vm => vm.BillablePercentage, map => map.MapFrom(m => m.BillablePercentage))
                   .ForMember(vm => vm.DailyBillableEffort, map => map.MapFrom(m => m.DailyBillableEffort))
                   .ForMember(vm => vm.DailyNonBillableEffort, map => map.MapFrom(m => m.DailyNonBillableEffort))
                   .ForMember(vm => vm.DailyTotalEffort, map => map.MapFrom(m => m.DailyTotalEffort))
                   .ForMember(vm => vm.effort, map => map.MapFrom(m => m.effort))
                   .ForMember(vm => vm.engineer_full_name, map => map.MapFrom(m => m.engineer_full_name))
                   .ForMember(vm => vm.finance_period_name, map => map.MapFrom(m => m.finance_period_name))
                   .ForMember(vm => vm.NonBillableEffort, map => map.MapFrom(m => m.NonBillableEffort));

                    cfg.CreateMap<finance_period, finance_periodViewModel>()
                    .ForMember(vm => vm.id, map => map.MapFrom(m => m.id))
                    .ForMember(vm => vm.is_current_period, map => map.MapFrom(m => m.is_current_period))
                    .ForMember(vm => vm.period_end, map => map.MapFrom(m => m.period_end))
                    .ForMember(vm => vm.period_name, map => map.MapFrom(m => m.period_name))
                    .ForMember(vm => vm.period_start, map => map.MapFrom(m => m.period_start));

                    cfg.CreateMap<service, servicesViewModel>()
                    .ForMember(vm => vm.id, map => map.MapFrom(m => m.id))
                    .ForMember(vm => vm.active, map => map.MapFrom(m => m.active))
                    .ForMember(vm => vm.billable, map => map.MapFrom(m => m.billable))
                    .ForMember(vm => vm.current_effort, map => map.MapFrom(m => m.current_effort))
                    .ForMember(vm => vm.current_scope, map => map.MapFrom(m => m.current_scope))
                    .ForMember(vm => vm.exceeding, map => map.MapFrom(m => m.exceeding))
                    .ForMember(vm => vm.name, map => map.MapFrom(m => m.name))
                    .ForMember(vm => vm.po_number, map => map.MapFrom(m => m.po_number))
                    .ForMember(vm => vm.po_remaining_amount, map => map.MapFrom(m => m.po_remaining_amount))
                    .ForMember(vm => vm.scope_exceedings, map => map.MapFrom(m => m.scope_exceeding))
                    .ForMember(vm => vm.service_billing_type, map => map.MapFrom(m => m.service_billing_type));

                    cfg.CreateMap<scope_exceeding, exceedingViewModel>()
                   .ForMember(vm => vm.id, map => map.MapFrom(m => m.id))
                   .ForMember(vm => vm.requested_date, map => map.MapFrom(m => m.requested_date))
                   .ForMember(vm => vm.scope, map => map.MapFrom(m => m.scope))
                   .ForMember(vm => vm.exceeding_comments, map => map.MapFrom(m => m.exceeding_comments))
                   .ForMember(vm => vm.finance_period, map => map.MapFrom(m => m.finance_period))
                   .ForMember(vm => vm.scope_exceeding_status, map => map.MapFrom(m => m.scope_exceeding_status))
                   .ForMember(vm => vm.service_id, map => map.MapFrom(m => m.service_id))
                   .ForMember(vm => vm.status_id, map => map.MapFrom(m => m.status_id))
                   .ForMember(vm => vm.updated_by, map => map.MapFrom(m => m.updated_by))
                   .ForMember(vm => vm.update_timestamp, map => map.MapFrom(m => m.update_timestamp));
                });
        }

    }
}