using AppRestaurant.Models;
using AppRestaurant.Models.ModelService;
using Dapper;
using Microsoft.Data.SqlClient;

namespace AppRestaurant.Repository.Repository.Implement
{
    public class ClienteRepository : Repository<Cliente>, IClienteRepository
    {
        public ClienteRepository(string connectionString) : base(connectionString)
        {
        }

        public ResponseHeader GetByDocumento(string nroDocumento, string password)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var respuesta = new ResponseHeader();
                var parameters = new DynamicParameters();
                parameters.Add(Constante.DNI, nroDocumento);
                parameters.Add(Constante.PASSWORD, password);
                parameters.Add(Constante.OV_ESTADO, Constante.OV_ESTADO, System.Data.DbType.String, System.Data.ParameterDirection.Output);
                parameters.Add(Constante.OV_MESSAGE, Constante.OV_MESSAGE, System.Data.DbType.String, System.Data.ParameterDirection.Output);

                Cliente responsedetail = connection.QueryFirstOrDefault<Cliente>
                (Constante.NAME_USP_BUSCAR_BY_DOCUMENTO, parameters, commandType: System.Data.CommandType.StoredProcedure);

                respuesta.Estado = parameters.Get<string>(Constante.OV_ESTADO);
                respuesta.Mensaje = parameters.Get<string>(Constante.OV_MESSAGE);

                if (respuesta.Estado.Equals(Constante.OK))
                    respuesta.Detalle.Add(responsedetail.GetType().Name, responsedetail);

                return respuesta;
            }
        }
    }
}
