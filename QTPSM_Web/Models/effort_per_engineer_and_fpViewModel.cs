using QTPSM_Web.Infrastructure.Validators;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace QTPSM_Web.Models
{
    public class effort_per_engineer_and_fpViewModel : IValidatableObject
    {
        public string engineer_full_name { get; set; }
        public string finance_period_name { get; set; }
        public double effort { get; set; }
        public double BillableEffort { get; set; }
        public double NonBillableEffort { get; set; }
        public double? BillablePercentage { get; set; }
        public double DailyTotalEffort { get; set; }
        public double DailyBillableEffort { get; set; }
        public double DailyNonBillableEffort { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var validator = new effort_per_engineer_and_fpValidator();
            var result = validator.Validate(this);
            return result.Errors.Select(item => new ValidationResult(item.ErrorMessage, new[] { item.PropertyName }));
        }
    }
}