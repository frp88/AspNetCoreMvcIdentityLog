using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspNetCoreMvcIdentityLog.Models
{
    [Table("LogAuditoria")]
    public class LogAuditoria
    {
        [Column("Id")]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Column("DetalhesAuditoria")]
        [DisplayName("Detalhes auditoria")]
        public string DetalhesAuditoria { get; set; }

        [Column("EmailUsuario")]
        [DisplayName("E-mail do usuário")]
        public string EmailUsuario { get; set; }

    }
}
