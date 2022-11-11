using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MPSTAG.Data;
using Volo.Abp.DependencyInjection;

namespace MPSTAG.EntityFrameworkCore;

public class EntityFrameworkCoreMPSTAGDbSchemaMigrator
    : IMPSTAGDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreMPSTAGDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the MPSTAGDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<MPSTAGDbContext>()
            .Database
            .MigrateAsync();
    }
}
