using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Suporte.Dominio
{
    [DBBroker.Mapping.DBMappedClass(Table = "tbSetor", PrimaryKey = "IdSetor")]
    public class Setor 
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int? IdSetorPai { get; set; }
        public string TxSetor { get; set; }
        public bool IsArquiva { get; set; }
        public int? NuSetor { get; set; }

        [NotMapped]
        public Error Erro { get; set; }

        [ForeignKey("IdSetorPai")]
        public virtual Setor SetorPai { get; set; }
    }
}