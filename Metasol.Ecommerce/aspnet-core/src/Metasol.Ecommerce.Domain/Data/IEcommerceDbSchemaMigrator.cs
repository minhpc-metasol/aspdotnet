using System.Threading.Tasks;

namespace Metasol.Ecommerce.Data;

public interface IEcommerceDbSchemaMigrator
{
    Task MigrateAsync();
}
