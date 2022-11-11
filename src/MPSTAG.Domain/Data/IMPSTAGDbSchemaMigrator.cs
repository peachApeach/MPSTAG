using System.Threading.Tasks;

namespace MPSTAG.Data;

public interface IMPSTAGDbSchemaMigrator
{
    Task MigrateAsync();
}
