using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Suporte.Dominio
{
    [DBBroker.Mapping.DBMappedClass(Table = "tbUsuario", PrimaryKey = "IdUsuario")]
    public class Usuario 
    {
        //[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string TxNome { get; set; }
        public string TxSobreNome { get; set; }
        public string TxCpf { get; set; }
        public string TxEmail { get; set; }
        public string TxTelefone { get; set; }
        public string TxObservacao { get; set; }
        public string TxLogin { get; set; }
        public string TxSenha { get; set; }
        public string TxSalt { get; set; }
        public bool IsAtivo { get; set; }
        public int? Hits { get; set; }
        public string ConnectionId { get; set; }
        public DateTime DtCadastro { get; set; }

    }
}