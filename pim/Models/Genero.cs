using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace pim.Models
{
    [Table("GENERO", Schema = "dbo")]
    public class Genero
    {
        [Key]
        [Column("GEN_INT_ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("GEN_STR_DESC", TypeName = "VARCHAR(10)")]
        public string Descricao { get; set; }
    }
}
