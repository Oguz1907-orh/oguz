using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using Entities.SPs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IStudentService
    {

        IDataResult<List<StudentDetailDto>> GetStudentDetails();
        IDataResult<List<StudentSp>> GetStudent();
        IDataResult<List<Student>> GetAll();
        IDataResult<Student> GetById(int id);
        IResult Add(Student student);
        IResult Delete(Student student);
        IResult Update(Student student);
    }
}
