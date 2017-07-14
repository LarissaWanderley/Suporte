﻿using Suporte.Dominio;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Suporte.Persistencia
{
    public class DBPerfil : DBBroker.Engine.DBBroker<Perfil>
    {
        internal static List<Perfil> PorNome(string nome)
        {
            return ExecCmdSQL(cmdText: "SELECT * FROM tbPerfil WHERE TxPerfil = @Nome "
                , parameters: new List<DbParameter>() { new SqlParameter("@Nome", nome) });
        }
        /*select * from tbPerfil p inner join tblog l on p.IdLog = l.IdLog
        --
        select * from tbPerfil p
        inner join tblog l on p.IdPerfil = l.IdChave  and l.TxTabela = 'perfil'
        inner join tbLogDetalhe ld on l.IdLog = ld.IdLog
        order by p.IdPerfil, l.IdLog*/
    }
}