using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Suporte.Dominio
{
    [DBBroker.Mapping.DBMappedClass(Table = "tbMarca", PrimaryKey = "IdMarca")]
    public class Marca 
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string TxMarca { get; set; }

    }
}