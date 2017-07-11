using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Suporte.Dominio
{
    [DBBroker.Mapping.DBMappedClass(Table = "tbChatRoom", PrimaryKey = "IdChatRoom")]
    public class ChatRoom 
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdRoom { get; set; }
        public int IdUnique { get; set; }
        public DateTime DtCadastro { get; set; }

        [NotMapped]
        public Error Erro { get; set; }
    }
}