using AppRestaurant.Models;
using AppRestaurant.Models.ModelService;
using Dapper;
using Microsoft.Data.SqlClient;

namespace AppRestaurant.Repository.Repository.Implement
{
    public class ParametroRepository : Repository<Parametro>, IParametroRepository
    {
        public ParametroRepository(string connectionString) : base(connectionString)
        {
        }
        public ResponseHeader GetByParametro(string id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var respuesta = new ResponseHeader();
                var parameters = new DynamicParameters();
                parameters.Add(Constante.ID, id);
                parameters.Add(Constante.OV_ESTADO, Constante.OV_ESTADO, System.Data.DbType.String, System.Data.ParameterDirection.Output);
                parameters.Add(Constante.OV_MESSAGE, Constante.OV_MESSAGE, System.Data.DbType.String, System.Data.ParameterDirection.Output);

                IEnumerable<Parametro> detalle = connection.Query<Parametro>(Constante.NAME_USP_BUSCAR_PARAMETRO_BY_ID, parameters, commandType: System.Data.CommandType.StoredProcedure);

                respuesta.Estado = parameters.Get<string>(Constante.OV_ESTADO);
                respuesta.Mensaje = parameters.Get<string>(Constante.OV_MESSAGE);

                if (respuesta.Estado.Equals(Constante.OK))
                    respuesta.Detalle.Add(Constante.PARAMETROS, detalle);

                return respuesta;
            }
        }
    }
}
