using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Suporte.Dominio
{
     [DBBroker.Mapping.DBMappedClass(Table = "tbTipoTarefa", PrimaryKey = "IdTipoTarefa")]
    public class Solucao
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string TxSolucao { get; set; }
        public int IdLog { get; set; }
    }
}