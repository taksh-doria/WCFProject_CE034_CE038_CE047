using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MovieRatingSystem.Model
{
    public class Student
    {
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Student_Id { get; set; }
        [Required]
        public string Student_Name { get; set; }
        [Required]
        public string Student_Branch { get; set; }
        public double Student_CPI { get; set; }
    }
}
