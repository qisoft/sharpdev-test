using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.Models
{
    [Table("Persons")]
    public class Person
    {
        public int Id { get; set; }

        /// <summary>
        /// Имя
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Фамилия
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Отчество
        /// </summary>
        public string SecondName { get; set; }

        /// <summary>
        /// Пол
        /// </summary>
        public Gender Gender { get; set; }
        
        /// <summary>
        /// Адрес
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Телефоны
        /// </summary>
        public virtual ICollection<Phone> Phones { get; set; }

        /// <summary>
        /// E-mail
        /// </summary>
        public string Email { get; set; }
    }
}
