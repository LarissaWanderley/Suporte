using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Suporte.Dominio
{
     [DBBroker.Mapping.DBMappedClass(Table = "tbPerfil", PrimaryKey = "IdPerfil")]
    public class Perfil
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required,MaxLength(50)] 
        public string TxPerfil { get; set; }
        public int IdLog { get; set; }

    }
}