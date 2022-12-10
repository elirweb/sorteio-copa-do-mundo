using System;
using System.Collections.Generic;
using System.Text;

namespace SorteioCopaDoMundo.Infra.Common
{
    public class RepositoryBase<T> : IRepository
    {
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
