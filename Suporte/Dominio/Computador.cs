using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Suporte.Dominio
{
    public class Computador 
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int IdMarca { get; set; }
        public int? IdSetor { get; set; }
        public DateTime DtGarantia { get; set; }
        public string TxComputador { get; set; }
        public string TxModelo { get; set; }
        public string TxProcessador { get; set; }
        public string TxHD { get; set; }
        public string TxMemoria { get; set; }
        public string TxTombo { get; set; }
        public int NuTipo { get; set; }
        public int NuTipoMemoria { get; set; }
        public int NuStatus { get; set; } //1-Operante //2-Estoque//3-Aguardando Peça //4-Inutilizado
        public int IdLog { get; set; }

        [ForeignKey("IdMarca")]
        public virtual Marca Marca { get; set; }
        [ForeignKey("IdSetor")]
        public virtual Setor Setor { get; set; }
    }
}