using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Suporte.Dominio
{
    [DBBroker.Mapping.DBMappedClass(Table = "tbChatMessage", PrimaryKey = "IdChatMessage")]
    public class ChatMessage 
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int IdRoom { get; set; }
        public int IdUser { get; set; }
        public string TxMessage { get; set; }
        public DateTime DtCadastro { get; set; }

        [NotMapped]
        public Error Erro { get; set; }

        [ForeignKey("IdRoom")]
        public virtual ChatRoom Room { get; set; }
        [ForeignKey("IdUser")]
        public virtual Usuario User { get; set; }
    }
}