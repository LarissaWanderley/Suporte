using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Suporte.Dominio
{
    [DBBroker.Mapping.DBMappedClass(Table = "tbChatUserRoom", PrimaryKey = "IdChatUserRoom")]
    public class ChatUserRoom 
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdUserRoom { get; set; }
        public int IdRoom { get; set; }
        public int IdUserFrom { get; set; }
        public int IdUserTo { get; set; }
        public DateTime DtCadastro { get; set; }

        [NotMapped]
        public Error Erro { get; set; }

        [ForeignKey("IdRoom")]
        public virtual ChatRoom Room { get; set; }
        [ForeignKey("IdUserFrom")]
        public virtual Usuario UserFrom { get; set; }
        [ForeignKey("IdUserTo")]
        public virtual Usuario UserTo { get; set; }
    }
}