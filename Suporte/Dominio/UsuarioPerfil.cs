using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Suporte.Dominio
{
    [DBBroker.Mapping.DBMappedClass(Table = "tbUsuarioPerfil", PrimaryKey = "IdUsuarioPerfil")]
    public class UsuarioPerfil
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public int IdPerfil { get; set; }
        public int IdLog { get; set; }

        [ForeignKey("IdUsuario")]
        public virtual Usuario Usuario { get; set; }
        [ForeignKey("IdPerfil")]
        public virtual Perfil Perfil { get; set; }
    }
}