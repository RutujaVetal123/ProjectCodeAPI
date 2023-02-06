using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectCode.Models
{
    public class CodeDetails
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CodeID { get; set; }

        [Required]
        public string Author { get; set; }

        [DataType("varchar(30)")]
        [Required(ErrorMessage = "Please provide valid Github link")]
        public string GitLink { get; set; }

        [Required]
        public string Technology { get; set; }

        [Required]
        public string Description { get; set; }
    }
}
