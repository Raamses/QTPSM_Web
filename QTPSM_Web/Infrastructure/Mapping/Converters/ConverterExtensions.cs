using AutoMapper;
using QTPSM.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QTPSM_Web.Infrastructure.Mapping.Converters
{
    public class IntFPNameTypeConverter : ITypeConverter<int, string>
    {
        public string Convert(ResolutionContext context)
        {
            throw new NotImplementedException();
        }

        public string Convert(int source, ResolutionContext context)
        {
            using (PSMContext ctx = new PSMContext())
            {
                return ctx.finance_period.Find(source).period_name;
            }
        }
    }
}