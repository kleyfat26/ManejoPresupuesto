using Dapper;
using ManejoPresupuesto.Models;
using Microsoft.Data.SqlClient;

namespace ManejoPresupuesto.Servicios
{
    public interface IRepositorioTiposCuentas
    {
        void Crear(TipoCuenta tipoCuenta);
    }
    public class RepositoriosTiposCuentas : IRepositorioTiposCuentas
    {
        private readonly string connectionString;

        public RepositoriosTiposCuentas(IConfiguration configuration)
        {
            connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public void Crear(TipoCuenta tipoCuenta)
        {
            using var connection = new SqlConnection(connectionString);
            var id = connection.QuerySingle<int>($@"INSERT INTO TiposCuentas(Nombre,UsuarioID,Orden)
                                               VALUES(@Nombre,@UsuarioID,0);
                                                SELECT SCOPE_IDENTITY();", tipoCuenta);
            tipoCuenta.ID= id;
        }
    }
}
