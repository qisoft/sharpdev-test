using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.Models
{
    [Table("Teachers")]
    public class Teacher : AdultPerson
    {
        public string Degree { get; set; }
        public ICollection<Cource> Cources { get; set; }
    }
}