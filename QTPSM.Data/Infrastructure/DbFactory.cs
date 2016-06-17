using QTPSM.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QTPSM.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        PSMContext psmDbContext;
        //CDISContext cdisDbContext;

        //public CDISContext CDISInit()
        //{
        //    return cdisDbContext ?? (cdisDbContext = new CDISContext());
        //}

        public PSMContext Init()
        {
            return psmDbContext ?? (psmDbContext = new PSMContext());
        }

        protected override void DisposeCore()
        {
            if (psmDbContext != null)
                psmDbContext.Dispose();

            //if (cdisDbContext != null)
            //    cdisDbContext.Dispose();
        }
    }
}
