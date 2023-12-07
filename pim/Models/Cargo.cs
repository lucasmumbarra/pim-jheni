using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace pim.Models
{
    [Table("CARGO", Schema = "dbo")]
    public class Cargo
    {
        [Key]
        [Column("CAR_INT_ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Column("CAR_STR_NOME", TypeName = "VARCHAR(50)")]
        public string Nome { get; set; }
    }
}
