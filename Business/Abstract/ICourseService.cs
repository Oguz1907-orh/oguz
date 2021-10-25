using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICourseService
    {
        IDataResult<List<Course>> GetAll();
        IDataResult<Course> GetById(int id);
        IResult Add(Course course);
        IResult Delete(Course course);
        IResult Update(Course course);
    }
}
