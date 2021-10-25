using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using Entities.SPs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IStudentDal: IEntitiyRepository<Student>
    {
        List<StudentDetailDto> GetStudentDetails();
        List<StudentSp> GetStudent();
    }
}
