using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using DataLayer.Models;

namespace DataLayer.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<SchoolContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "MVC_Web_Interface.Models.SchoolContext";
        }

        protected override void Seed(SchoolContext context)
        {
            var phone = new Phone()
            {
                Id = 1,
                Number = "1111111111"
            };
            var student = new Student()
            {
                Id = 1,
                FirstName = "Ученик",
                SecondName = "Учеников",
                LastName = "Родителевич",
                BirthDate = new DateTime(2000, 1, 1),
                Address = "Адрес ученика",
                Class = "8а",
                School = "№1",
                Email = "student@school.com",
                Gender = Gender.Male,
                Phones = new List<Phone>()
                {
                    new Phone()
                    {
                        Id = 2,
                        Number = "88002000001"
                    },
                    phone
                }
            };
            context.Students.AddOrUpdate(student);
            context.SaveChanges();
            student.Phones.Remove(phone);
            context.Phones.Attach(phone);
            context.Phones.Remove(phone);
            context.SaveChanges();
            context.Parents.AddOrUpdate(new Parent
            {
                Id = 1,
                FirstName = "Иван",
                SecondName = "Петров",
                LastName = "Борисович",
                Address = "ул. Мира д. 1",
                Email = "parent1@school.com",
                Gender = Gender.Male,
                Phones = new List<Phone>()
                {
                    new Phone()
                    {
                        Id = 3,
                        Number = "88002000002"
                    }
                },
                Position = "Директор",
                WorkPlace = "Завод",
                Childrens = new List<Student>()
                {
                    student
                }
            });
            context.Teachers.AddOrUpdate(new Teacher()
            {
                Id = 1,
                FirstName = "Учитель",
                SecondName = "Родитель",
                LastName = "Михайловна",
                Gender = Gender.Female,
                Address = "Адрес Учителя-родителя",
                Cources = new List<Cource>()
                {
                    new Cource()
                    {
                        Name = "Математика"
                    }
                },
                Degree = "Доктор наук",
                Email = "teacher-parent@school.com",
                Phones = new List<Phone>()
                {
                    new Phone()
                    {
                        Id = 4,
                        Number = "88002000003"
                    },
                    new Phone()
                    {
                        Id = 5,
                        Number = "88002000004"
                    }
                },
                Childrens = new List<Student>()
                {
                    student
                }
            });
            context.Teachers.AddOrUpdate(new Teacher()
            {
                Id = 1,
                FirstName = "Учитель",
                SecondName = "Не-родитель",
                LastName = "Олегович",
                Gender = Gender.Male,
                Address = "Адрес Учителя-не-родителя",
                Cources = new List<Cource>()
                {
                    new Cource()
                    {
                        Name = "Физкультура"
                    }
                },
                Degree = "Доктор наук",
                Email = "teacher-not-parent@school.com",
                Phones = new List<Phone>()
                {
                    new Phone()
                    {
                        Id = 6,
                        Number = "88002000005"
                    },
                    new Phone()
                    {
                        Id = 7,
                        Number = "88002000006"
                    }
                }
            });
        }
    }
}
