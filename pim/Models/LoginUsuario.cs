using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace pim.Models
{
    [Table("LOGIN_USUARIO", Schema = "dbo")]
    public class LoginUsuario
    {
        [Key]
        [Column("LOG_INT_ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Column("LOG_STR_LOGIN", TypeName = "VARCHAR(30)")]
        public string Login { get; set; }

        [Required]
        [Column("LOG_STR_SENHA", TypeName = "VARCHAR(30)")]
        public string Senha { get; set; }
    }
}
