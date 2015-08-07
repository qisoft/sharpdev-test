using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_Web_Interface.Models
{
    [ComplexType]
    public class Parent
    {
        /// <summary>
        /// Место работы
        /// </summary>
        public string WorkPlace { get; set; }

        /// <summary>
        /// Должность
        /// </summary>
        public string Position { get; set; }

        /// <summary>
        /// Дети
        /// </summary>
        public virtual ICollection<Pupil> Pupils { get; set; } 
    }
}