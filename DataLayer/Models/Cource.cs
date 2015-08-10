using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.Models
{
    [Table("Cources")]
    public class Cource
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}