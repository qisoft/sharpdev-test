using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DataLayer.Models;

namespace MVC_Web_Interface.Models.Mapping
{
    public class StudentListMapping : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<Student, StudentListModel>()
                .ForMember(d => d.FullName,
                    o => o.MapFrom(s => string.Format("{0} {1} {2}", s.SecondName, s.FirstName, s.LastName)));
        }
    }
}
