using System;
using AutoMapper;
using DataLayer.Repositories;

namespace MVC_Web_Interface.Models.Builders.Students
{
    public class StudentDetailsModelBuilder : IStudentDetailsModelBuilder
    {
        private readonly IStudentRepository _students;

        public StudentDetailsModelBuilder(IStudentRepository students)
        {
            _students = students;
        }

        public StudentModel Build(int id)
        {
            var student = _students.Get(id);
            if (student == null)
            {
                throw new ArgumentException("Student not found", "id");
            }

            return Mapper.Map<StudentModel>(student);
        }
    }
}
