using System.Collections.Generic;

namespace MVC_Web_Interface.Models.Builders.Parents
{
    public interface IParentsListModelBuilder
    {
        IEnumerable<ParentModel> BuildForStudent(int studentId);
    }
}