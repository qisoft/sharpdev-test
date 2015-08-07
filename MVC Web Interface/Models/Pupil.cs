using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_Web_Interface.Models
{
    [Table("Pupils")]
    public class Pupil : Person
    {
        /// <summary>
        /// Школа
        /// </summary>
        public string School { get; set; }

        /// <summary>
        /// Класс
        /// </summary>
        public string Class { get; set; }

        /// <summary>
        /// Дата рождения
        /// </summary>
        public DateTime BirthDate { get; set; }

        /// <summary>
        /// Родители
        /// </summary>
        public virtual ICollection<Parent> Parents { get; set; } 
    }
}