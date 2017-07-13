using Suporte.Dominio;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Suporte.Persistencia
{
    public class DBLogDetalhe : DBBroker.Engine.DBBroker<LogDetalhe>
    {
        public static LogDetalhe PesqUltimo(string tabela, int idChave)
        {
            var paramentros = new List<DbParameter>()
            {
                new SqlParameter("@Tabela", tabela),
                new SqlParameter("@IdChave", idChave)
            };

            return ExecCmdSQL(cmdText: "SELECT ld.* FROM tbLog l INNER JOIN tbLogDetalhe ld ON ld.IdLog = l.IdLog WHERE TxTabela = @Tabela AND IdChave = @IdChave ORDER BY IdLog desc "
            , parameters: paramentros).FirstOrDefault();

        }

    }
}