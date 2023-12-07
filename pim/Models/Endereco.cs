using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace pim.Models
{
    [Table("ENDERECO", Schema = "dbo")]
    public class Endereco
    {
        [Key]
        [Column("END_INT_ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Column("END_STR_LOGRADOURO", TypeName = "VARCHAR(70)")]
        public string Logradouro { get; set; }

        [Required]
        [Column("END_STR_NUM", TypeName = "VARCHAR(10)")]
        public string Numero { get; set; }

        [Required]
        [Column("END_STR_COMPLEMENTO", TypeName = "VARCHAR(30)")]
        public string Complemento { get; set; }

        [Required]
        [Column("END_STR_BAIRRO", TypeName = "VARCHAR(70)")]
        public string Bairro { get; set; }

        [Required]
        [Column("END_STR_CEP", TypeName = "CHAR(8)")]
        public string CEP { get; set; }

        [Required]
        [Column("CID_INT_ID")]
        public int CidadeId { get; set; }

    }
}
