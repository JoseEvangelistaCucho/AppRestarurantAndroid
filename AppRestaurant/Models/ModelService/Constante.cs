using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppRestaurant.Models.ModelService
{
    public class Constante
   {
        //cliente Parametros
        ////dbo.uspBuscarClienteByDocumento
        public const string NAME_USP_BUSCAR_BY_DOCUMENTO = "dbo.uspBuscarClienteByPassword";
        public const string DNI = "@dni";
        public const string PASSWORD = "@PasswordUser";


        ///RESPONSE
        public const string OV_ESTADO = "@OV_ESTADO";
        public const string OV_MESSAGE = "@OV_MESSAGE";
        public const string OK = "0";
    }
}
