using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Clinic_Management_System.models
{

    public class DataModel
    {
         [StringLength(10)]
            [Key]
            public int Id { get; set; }
            [Required]
            [StringLength(40)]
            [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Use letters only please")]
            [Column(TypeName="varchar(20)")]
            public string Name { get; set; }
            [Required]
            [StringLength(40)]
            [EmailAddress]
            public string email { get; set; }
            [Required]
            [StringLength(11)]
            public string Number { get; set; }
            [Required]
            public DateTime Date { get; set; }
           
        }
    }
