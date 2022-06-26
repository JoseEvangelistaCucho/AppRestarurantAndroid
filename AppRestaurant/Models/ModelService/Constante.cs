using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppRestaurant.Models.ModelService
{
    public class Constante
   {
        /// <summary>
        /// Tabla Cliente
        /// </summary>
        ////dbo.uspBuscarClienteByDocumento
        public const string NAME_USP_BUSCAR_BY_DOCUMENTO = "dbo.uspBuscarClienteByPassword";
        public const string NAME_USP_CREAR_CLIENTE = "dbo.uspCrearCliente";
        public const string DNI = "@dni";
        public const string FIRSNAME = "@FirstName";
        public const string LASTNAME = "@LastName";
        public const string DIRECCTION = "@direccion";
        public const string PHONE = "@Phone";
        public const string TIPO = "@Tipo";
        public const string PASSWORD = "@PasswordUser";
        public const string IDCLIENTE = "@IDCLIENTE";
        //////
        ///Modificar Cliente






        /// <summary>
        ///  Tabla Parametro
        /// </summary>
        /// 
        //dbo.uspDasParametroByTipoParametro
        public const string NAME_USP_BUSCAR_PARAMETRO_BY_ID= "dbo.uspDasParametroByTipoParametro";
        public const string ID = "@id";
        public const string PARAMETROS = "parametros";

        ///RESPONSE
        public const string OV_ESTADO = "@OV_ESTADO";
        public const string OV_MESSAGE = "@OV_MESSAGE";
        public const string OK = "0";

     
    }
}
