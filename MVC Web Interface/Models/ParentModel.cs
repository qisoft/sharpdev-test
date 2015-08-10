namespace MVC_Web_Interface.Models
{
    public class ParentModel
    {
        public int Id { get; set; }
        /// <summary>
        /// ФИО
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// Один из телефонов этого родителя 
        /// </summary>
        public string PhoneNumber { get; set; }
    }
}