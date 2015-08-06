using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Web_Interface.Models
{
    public abstract class Person
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
        
        public string Address { get; set; }

        public List<Phone> Phones { get; set; }

        public string Email { get; set; }
    }

    public class Pupil : Person
    {
        public string School { get; set; }

        public string Class { get; set; }
        /// <summary>
        /// Дата рождения
        /// </summary>
        public DateTime BirthDate { get; set; }
    }

    public abstract class AdultPerson : Person
    {
        
    }

    public class Phone
    {
        public int Id { get; set; }
        public string PhoneNumber { get; set; }
    }

    public enum Gender
    {
        /// <summary>
        /// Мужской
        /// </summary>
        Male = 0,
        /// <summary>
        /// Женский
        /// </summary>
        Female = 1    
    }
}
