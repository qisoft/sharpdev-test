using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_Web_Interface.Models
{
    [ComplexType]
    public class Teacher
    {
        public string Degree { get; set; }
        public ICollection<Cource> Cources { get; set; }
    }
}