using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Suporte.Dominio
{
    [DBBroker.Mapping.DBMappedClass(Table = "tbAtendimento", PrimaryKey = "IdAtendimento")]
    public class AtendimentoHistorico 
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int IdAtendimento { get; set; }
        public int? IdUsuario { get; set; }
        public int? IdTipoTarefa { get; set; }
        public DateTime DtHistorico { get; set; }
        public string TxObservacao { get; set; }
        public int NuTipo { get; set; }
        public int NuStatus { get; set; }

        [NotMapped]
        public Error Erro { get; set; }

        [ForeignKey("IdAtendimento")]
        public virtual Atendimento Atendimento { get; set; }
        [ForeignKey("IdUsuario")]
        public virtual Usuario Usuario { get; set; }
        [ForeignKey("IdTipoTarefa")]
        public virtual TipoTarefa TipoTarefa { get; set; }
    }

    public enum HistoricoTipoEnum {
        NORMAL = 1, DISTRIBUIDO = 2
    }

    public enum HistoricoStatusEnum
    {
        ABERTO = 1, EXECUTANDO = 2, AGUARDANDO = 3, FINALIZADO = 4
    }
}