using Newtonsoft.Json;
using Suporte.Dominio;
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
       
        public static bool Sava(Perfil perfil, string ipUsuario, string txUrl)
        {
            int nuAcao = perfil.Id < 1 ? 1 : 2;
            Perfil antigo = DBPerfil.GetById(perfil.Id);
            if (nuAcao == 1 || antigo.Id != perfil.Id || antigo.IdLog != perfil.IdLog || antigo.TxPerfil != perfil.TxPerfil )
            {
                Log log = new Log();
                log.NuAcao = nuAcao;
                log.IdUsuario = 1;
                log.IpUsuario = ipUsuario;
                log.TxTabela = "Perfil";
                log.DtTransacao = DateTime.Now;
                log.TxUrl = txUrl;
                log.IdLogAnterior = antigo.IdLog;
                DbTransaction transacao = GetTransaction();
                try
                {
                    DBPerfil.Save(perfil, transacao);
                    log.IdChave = perfil.Id;
                    DBLog.Save(log, transacao);
                    perfil.IdLog = log.Id;
                    DBPerfil.Save(perfil,transacao);
                    if (antigo.IdLog > 0)
                    {
                        LogDetalhe logDetalhe = new LogDetalhe();
                        logDetalhe.IdLog = antigo.IdLog;
                        logDetalhe.TxObjeto = JsonConvert.SerializeObject(antigo);//Log t = JsonConvert.DeserializeObject<Log>(l.txObjeto)
                        DBLogDetalhe.Save(logDetalhe, transacao);
                    }
                    transacao.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    if (transacao.Connection != null)
                    {
                        transacao.Rollback();
                    }
                    return false;
                }

            }
            return true;
        }
        public static bool Excui(Perfil perfil, string ipUsuario, string txUrl)
        {
            DbTransaction transacao = GetTransaction();
            try
            {
                LogDetalhe logDetalhe = new LogDetalhe();
                logDetalhe.IdLog = perfil.IdLog;
                logDetalhe.TxObjeto = JsonConvert.SerializeObject(perfil);
                DBLogDetalhe.Save(logDetalhe, transacao);

                Log log = new Log();
                log.IdChave = perfil.Id;
                log.NuAcao = 3;
                log.IdUsuario = 1;
                log.IpUsuario = ipUsuario;
                log.TxTabela = "Perfil";
                log.DtTransacao = DateTime.Now;
                log.TxUrl = txUrl;
                log.IdLogAnterior = perfil.IdLog;
                DBLog.Save(log, transacao);

                DBPerfil.Delete(perfil.Id);
                return true;
            }
            catch (Exception ex)
            {
                if (transacao.Connection != null)
                {
                    transacao.Rollback();
                }
                return false;
            }

           
        }
    }
}
/*select * from tbPerfil p inner join tblog l on p.IdLog = l.IdLog
    --
    select * from tbPerfil p
    inner join tblog l on p.IdPerfil = l.IdChave  and l.TxTabela = 'perfil'
    inner join tbLogDetalhe ld on l.IdLog = ld.IdLog
    order by p.IdPerfil, l.IdLog*/

