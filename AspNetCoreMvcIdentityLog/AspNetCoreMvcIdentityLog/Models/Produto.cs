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

    }
}
