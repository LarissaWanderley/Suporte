using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Suporte.Dominio
{
    [DBBroker.Mapping.DBMappedClass(Table = "tbSituacao", PrimaryKey = "IdSituacao")]
    public class Situacao
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string TxSituacao { get; set; }

        [NotMapped]
        public Error Erro { get; set; }
    }
}