using QTPSM.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QTPSM.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        PSMContext Init();
        //CDISContext CDISInit();
    }
}
