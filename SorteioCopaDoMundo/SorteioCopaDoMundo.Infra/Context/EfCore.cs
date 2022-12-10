using Microsoft.Extensions.Configuration;
using System;
using System.Data;
using System.Data.SqlClient;

namespace SorteioCopaDoMundo.Infra.Context
{
    public class EfCore : IDisposable
    {
        public IDbConnection Connection { get; }
        public IDbTransaction Transaction { get; set; }
        public readonly IConfiguration configuration;
        public EfCore(IConfiguration config)
        {
            configuration = config;
            Connection = new SqlConnection("Data Source=;Initial Catalog=;User ID=;password=");
            Connection.Open();
        }
        public void Dispose() => Connection.Dispose();
    }
}
