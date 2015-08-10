using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.Models
{
    [Table("Phones")]
    public class Phone
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public virtual Person Person { get; set; }
    }
}