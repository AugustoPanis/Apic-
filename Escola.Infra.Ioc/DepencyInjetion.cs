using System.Net.Mime;
using Escola.Domain.Interfaces;
using Escola.Infra.Context;
using Escola.Infra.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Escola.Infra.Ioc;

public static class DepencyInjetion
{
    public static IServiceCollection AddInfraestructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ApplicationDbContext>(options =>
        {
            options.UseNpgsql(configuration.GetConnectionString("DefaultConnection"),
            b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName));
        });
        services.AddScoped<ICursoRepository, CursoRepository>();
        services.AddScoped<IMatriculaRepository, MatriculaRepository>();
        services.AddScoped<INotaRespositoryRepository, NotaRepository>();
        services.AddScoped<ITurmaRepository, TurmaRepository>();
        services.AddScoped<IUsuarioRepository, UsuarioRepository>();
        
        return services;
    }
    
}