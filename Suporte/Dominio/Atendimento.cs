using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Suporte.Dominio
{
    [DBBroker.Mapping.DBMappedClass(Table = "tbAtendimento", PrimaryKey = "IdAtendimento")]
    public class Atendimento 
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int IdSolicitante { get; set; }
        public int IdSetorSolicitante { get; set; }
        public int IdTipoAtendimento { get; set; }
        public int IdMotivo { get; set; }
        public int? IdComputador { get; set; }
        public DateTime DtCadastro { get; set; }
        public string TxProtocolo { get; set; }
        public int NuPrioridade { get; set; }

        [NotMapped]
        public Error Erro { get; set; }

        [ForeignKey("IdSolicitante")]
        public virtual Usuario Solicitante { get; set; }
        [ForeignKey("IdSetorSolicitante")]
        public virtual Setor SetorSolicitante { get; set; }
        [ForeignKey("IdTipoAtendimento")]
        public virtual TipoAtendimento TipoAtendimento { get; set; }
        [ForeignKey("IdMotivo")]
        public virtual Motivo Motivo { get; set; }
        [ForeignKey("IdComputador")]
        public virtual Computador Computador { get; set; }
    }

    public enum AtendimentoPrioridadeEnum
    {
        ALTA = 1, MEDIA = 2, BAIXA = 3
    }
}