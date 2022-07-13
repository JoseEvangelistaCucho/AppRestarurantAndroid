using AppRestaurant.Models;
using AppRestaurant.Models.ModelService;
using Dapper;
using Microsoft.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace AppRestaurant.Repository.Repository.Implement
{
    public class ClienteRepository : Repository<Cliente>, IClienteRepository
    {
        public ClienteRepository(string connectionString) : base(connectionString)
        {
        }

        public ResponseHeader GetByDocumento(string nroDocumento, string password)
        {
            using (var connection = new MySqlConnection(_connectionString))
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

        public ResponseHeader CreateUserCliente(Cliente cliente)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                var respuesta = new ResponseHeader();
                var parameters = new DynamicParameters();
                int idClienteGenerado = 0;
                parameters.Add(Constante.FIRSNAME, cliente.FirstName);
                parameters.Add(Constante.LASTNAME, cliente.LastName);
                parameters.Add(Constante.PASSWORD, cliente.PasswordUser);
                parameters.Add(Constante.PHONE, cliente.Phone);
                parameters.Add(Constante.DNI, cliente.dni);
                parameters.Add(Constante.DIRECCTION, cliente.direction);
                parameters.Add(Constante.TIPO, cliente.Tipo);
                parameters.Add(Constante.OV_ESTADO, Constante.OV_ESTADO, System.Data.DbType.String, System.Data.ParameterDirection.Output);
                parameters.Add(Constante.OV_MESSAGE, Constante.OV_MESSAGE, System.Data.DbType.String, System.Data.ParameterDirection.Output);
                parameters.Add(Constante.IDCLIENTE, idClienteGenerado, System.Data.DbType.Int32, System.Data.ParameterDirection.Output);

                connection.Query(Constante.NAME_USP_CREAR_CLIENTE, parameters, commandType: System.Data.CommandType.StoredProcedure);

                idClienteGenerado = parameters.Get<Int32>(Constante.IDCLIENTE);
                respuesta.Estado = parameters.Get<String>(Constante.OV_ESTADO);
                respuesta.Mensaje = parameters.Get<String>(Constante.OV_MESSAGE);
                cliente.id = idClienteGenerado;
                respuesta.Detalle.Add(cliente.GetType().Name, cliente);

                return respuesta;
            }
        }

        public ResponseHeader CrearReceta(Receta receta)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                var respuesta = new ResponseHeader();
                var parameters = new DynamicParameters();
               // int idClienteGenerado = 0;
                parameters.Add(Constante.CODIGO, receta.Codigo);
                parameters.Add(Constante.NOMBRE, receta.Nombre);
                parameters.Add(Constante.INGREDIENTES, receta.Ingredientes);
                parameters.Add(Constante.DURACION, receta.Duracion);
                parameters.Add(Constante.OV_ESTADO, Constante.OV_ESTADO, System.Data.DbType.String, System.Data.ParameterDirection.Output);
                parameters.Add(Constante.OV_MESSAGE, Constante.OV_MESSAGE, System.Data.DbType.String, System.Data.ParameterDirection.Output);
               // parameters.Add(Constante.IDCLIENTE, idClienteGenerado, System.Data.DbType.Int32, System.Data.ParameterDirection.Output);

                connection.Query(Constante.NAME_USP_CREAR_RECETA, parameters, commandType: System.Data.CommandType.StoredProcedure);

               // idClienteGenerado = parameters.Get<Int32>(Constante.IDCLIENTE);
                respuesta.Estado = parameters.Get<String>(Constante.OV_ESTADO);
                respuesta.Mensaje = parameters.Get<String>(Constante.OV_MESSAGE);
              //  cliente.id = idClienteGenerado;
              //  respuesta.Detalle.Add(cliente.GetType().Name, cliente);

                return respuesta;
            }
        }
    }
}
