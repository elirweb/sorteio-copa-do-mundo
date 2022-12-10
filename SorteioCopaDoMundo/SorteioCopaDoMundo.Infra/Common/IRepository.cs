using System;
using System.Collections.Generic;
using System.Text;

namespace SorteioCopaDoMundo.Infra.Common
{
    public interface IRepository: IDisposable
    {
    }
    public interface IRepository<T> where T : class
    {
        void dispose();
    }
}
