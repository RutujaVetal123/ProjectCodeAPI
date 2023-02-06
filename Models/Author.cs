using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectCode.Models
{
    public class Author
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AuthorID { get; set; }

        [Required]
        public string Authorname { get; set; }

        [DataType("varchar(30)")]
        [Required(ErrorMessage = "Email can not be empty")]
        public string Email { get; set; }

        [Required]
        public string Expertise { get; set; }
    }
}
