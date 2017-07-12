using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Suporte.Dominio
{
     [DBBroker.Mapping.DBMappedClass(Table = "tbUsuarioSetor", PrimaryKey = "IdUsuarioSetor")]
    public class UsuarioSetor
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public int IdSetor { get; set; }
        public bool IsPrincipal { get; set; }

        [ForeignKey("IdUsuario")]
        public virtual Usuario Usuario { get; set; }
        [ForeignKey("IdSetor")]
        public virtual Setor Setor { get; set; }
    }
}