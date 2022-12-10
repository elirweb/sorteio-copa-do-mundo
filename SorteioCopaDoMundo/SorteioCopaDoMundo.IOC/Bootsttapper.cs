using Microsoft.Extensions.DependencyInjection;
using SorteioCopaDoMundo.Infra.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace SorteioCopaDoMundo.IOC
{
    public class Bootsttapper
    {
        public static void Register(IServiceCollection service)
        {
            #region App
            service.AddScoped<Aplication.Interfaces.IGrupos, Aplication.App.GruposApp>();
            service.AddScoped<Aplication.Interfaces.IJogos, Aplication.App.JogosApp>();
            service.AddScoped<Aplication.Interfaces.ISelecoes, Aplication.App.SelecoesApp>();
            #endregion

            #region Infra
            service.AddScoped<Infra.Interfaces.IGruposRepository, Infra.Repositorios.GruposRepository>();
            service.AddScoped<Infra.Interfaces.ISelecoesRepository, Infra.Repositorios.SelecoesRepository>();
            service.AddScoped<Infra.Interfaces.IJogosRepository, Infra.Repositorios.JogosRepository>();

            #endregion

            #region Db
            service.AddScoped(typeof(IRepository<>), typeof(RepositoryBase<>));
            service.AddScoped<Infra.Context.EfCore>();
            #endregion
        }
    }
}
