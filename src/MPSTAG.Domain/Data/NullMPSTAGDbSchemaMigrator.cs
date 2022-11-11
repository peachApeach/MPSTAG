using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace MPSTAG.Data;

/* This is used if database provider does't define
 * IMPSTAGDbSchemaMigrator implementation.
 */
public class NullMPSTAGDbSchemaMigrator : IMPSTAGDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
