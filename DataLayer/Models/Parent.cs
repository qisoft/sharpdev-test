using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.Models
{
    [Table("Parents")]
    public class Parent : AdultPerson
    {
        /// <summary>
        /// Место работы
        /// </summary>
        public string WorkPlace { get; set; }

        /// <summary>
        /// Должность
        /// </summary>
        public string Position { get; set; }
    }
}