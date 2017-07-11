using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Suporte.Dominio
{
    [DBBroker.Mapping.DBMappedClass(Table = "tbError", PrimaryKey = "IdError")]
    public class Error
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string Message { get; set; }
        public string StackTrace { get; set; }
        public DateTime DateCreated { get; set; }

        [NotMapped]
        public Error Erro { get; set; }
    }
}