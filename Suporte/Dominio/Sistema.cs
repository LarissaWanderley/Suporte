using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Suporte.Dominio
{
     [DBBroker.Mapping.DBMappedClass(Table = "tbSistema", PrimaryKey = "IdSistema")]
    public class Sistema 
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string TxSistema { get; set; }
        public string TxIdentificador { get; set; }

    }
}