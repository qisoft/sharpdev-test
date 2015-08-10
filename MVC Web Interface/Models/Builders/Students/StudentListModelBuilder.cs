using System.Collections.Generic;
using AutoMapper;
using DataLayer.Repositories;

namespace MVC_Web_Interface.Models.Builders.Students
{
    public class StudentListModelBuilder : IStudentListModelBuilder
    {
        private readonly IStudentRepository _students;

        public StudentListModelBuilder(IStudentRepository students)
        {
            _students = students;
        }

        public List<StudentListModel> Build()
        {
            var students = _students.GetAll();
            return Mapper.Map<List<StudentListModel>>(students);
        } 
    }
}
