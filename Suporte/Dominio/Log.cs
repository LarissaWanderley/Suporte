using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Suporte.Dominio
{
     [DBBroker.Mapping.DBMappedClass(Table = "tbLog", PrimaryKey = "IdLog")]
    public class Log 
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string TxTabela { get; set; }
        public int IdChave { get; set; }
        public int NuAcao { get; set; } // 1 = Add; 2 = UPD; 3 = DEL
        public int IdUsuario { get; set; }
        public DateTime DtTransacao { get; set; }
        public string TxUrl { get; set; }
        public string IpUsuario { get; set; }
        public int? IdLogAnterior { get; set; }

        [NotMapped]
        public Error Erro { get; set; }

        [ForeignKey("IdLogAnterior")]
        public virtual Log LogAnterior { get; set; }
    }
     [DBBroker.Mapping.DBMappedClass(Table = "tbLogDetalhe", PrimaryKey = "IdLogDetalhe")]
    public class LogDetalhe 
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int? IdLog { get; set; }
        public string TxObjeto { get; set; }

        [NotMapped]
        public Error Erro { get; set; }

        [ForeignKey("IdLog")]
        public virtual Log Log { get; set; }
    }
}