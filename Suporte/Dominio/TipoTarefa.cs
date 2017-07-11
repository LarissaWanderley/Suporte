using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Suporte.Dominio
{
     [DBBroker.Mapping.DBMappedClass(Table = "tbTipoTarefa", PrimaryKey = "IdTipoTarefa")]
    public class TipoTarefa 
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string TxTipoTarefa { get; set; }

        [NotMapped]
        public Error Erro { get; set; }
    }
}