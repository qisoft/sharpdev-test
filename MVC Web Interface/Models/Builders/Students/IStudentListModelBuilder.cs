using System.Collections.Generic;

namespace MVC_Web_Interface.Models.Builders.Students
{
    public interface IStudentListModelBuilder
    {
        List<StudentListModel> Build();
    }
}