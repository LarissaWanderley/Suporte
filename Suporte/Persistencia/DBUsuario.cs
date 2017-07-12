using Suporte.Dominio;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Suporte.Persistencia
{
    public class DBUsuario : DBBroker.Engine.DBBroker<Usuario>
    {
        public static Usuario ValidaLogin(string login, string senha)
        {
            var paramentros = new List<DbParameter>()
            {
                new SqlParameter("@Login", login),
                new SqlParameter("@Senha", senha)
            };

            return ExecCmdSQL("SELECT * FROM tbUsuario WHERE txLogin = @Login AND txSenha = @Senha ", parameters: paramentros).FirstOrDefault();

        }
        internal static List<Usuario> PorNome(string nome)
        {
            return ExecCmdSQL(cmdText: "SELECT * FROM tbUsuario WHERE txNome = @Nome "
                , parameters: new List<DbParameter>() { new SqlParameter("@Nome", nome) });
        }
        
    }
}