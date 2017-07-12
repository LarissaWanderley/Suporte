using Suporte.Dominio;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Suporte.Persistencia
{
    public class DBLog : DBBroker.Engine.DBBroker<Log>
    {
        internal static int PesqLogAnterior(string tabela, int idChave)
        {
            var paramentros = new List<DbParameter>()
            {
                new SqlParameter("@Tabela", tabela),
                new SqlParameter("@IdChave", idChave)
            };

            Log procurado = new Log();
                
            procurado = ExecCmdSQL(cmdText: "SELECT ISNULL(IdLog,0) as IdLog FROM tbLog WHERE TxTabela = @Tabela AND IdChave = @IdChave ORDER BY IdChave desc "
            , parameters: paramentros).FirstOrDefault();

            return (procurado == null) ? 0 : procurado.Id;
        }

    }
}