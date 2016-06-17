using FluentValidation;
using QTPSM_Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QTPSM_Web.Infrastructure.Validators
{
    public class effort_per_engineer_and_fpValidator : AbstractValidator<effort_per_engineer_and_fpViewModel>
    {
        public effort_per_engineer_and_fpValidator()
        {
            RuleFor(ep => ep.DailyBillableEffort).GreaterThan(0)
                .WithMessage("Please Report Daily Effort");

            RuleFor(ep => ep.DailyTotalEffort).Empty().GreaterThan(0)
                .WithMessage("Please Report Daily Effort");
        }

        //private bool ValidTrailerURI(string trailerURI)
        //{
        //    return true;
        //}
    }
}