using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspNetCoreMvcIdentityLog.Models
{
    [Table("Produto")]
    public class Produto
    {
        [Column("Id")]
        [DisplayName("Código")]
        public int Id { get; set; }

        [Column("Nome")]
        [DisplayName("Nome")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Nome { get; set; }

        [Column("CriadoEm")]
        [DisplayName("Data de criação")]
        public DateTime CriadoEm { get; set; } = DateTime.Now;

        [Column("AtualizadoEm")]
        [DisplayName("Data da última alteração")]
        public DateTime AtualizadoEm { get; set; } = DateTime.Now;
        
    }
}
