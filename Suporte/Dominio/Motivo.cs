using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Suporte.Dominio
{
     [DBBroker.Mapping.DBMappedClass(Table = "tbMotivo", PrimaryKey = "IdMotivo")]
    public class Motivo 
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int IdTipoAtendimento { get; set; }
        public string TxMotivo { get; set; }
        public int IdLog { get; set; }

        [ForeignKey("IdTipoAtendimento")]
        public virtual TipoAtendimento TipoAtendimento { get; set; }
    }
}