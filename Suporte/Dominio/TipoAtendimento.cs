using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Suporte.Dominio
{
     [DBBroker.Mapping.DBMappedClass(Table = "tbTipoAtendimento", PrimaryKey = "IdTipoAtendimento")]
    public class TipoAtendimento
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string TxTipoAtendimento { get; set; }
        public int IdLog { get; set; }
    }
}