using Business.Abstract;
using Business.Constants;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Entities.SPs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class StudentManager : IStudentService
    {
        IStudentDal _studentDal;
        public StudentManager(IStudentDal studentDal)
        {
            _studentDal = studentDal;
        }

        public IEnumerable<object> GetAll()
        {
            throw new NotImplementedException();
        }

        public IResult Add(Student student)
        {
            IResult result = BusinessRules.Run(
            CheckIfStudentExists(student.StudentId));
            if (result != null)
            {
                return result;
            }
            _studentDal.Add(student);
            return new SuccessResult(Messages.StudentAdded);
        }

        public IResult Delete(Student student)
        {
            _studentDal.Delete(student);
            return new SuccessResult(Messages.StudentDeleted);
        }


        public IDataResult<Student> GetById(int id)
        {
            return new SuccessDataResult<Student>(_studentDal.Get(b => b.Id == id));
        }

        /*public List<StudentSp> GetStudent()
        {
            return _studentDal.GetStudent();
        }*/
        //bakılacak
        public List<StudentDetailDto> GetStudentDetails()
        {
            return _studentDal.GetStudentDetails();
        }
        //ok
        public IResult Update(Student student)
        {
            IResult result = BusinessRules.Run(
            CheckIfStudentExists(student.StudentId));
            if (result != null)
            {
                return result;
            }
            _studentDal.Update(student);
            return new SuccessResult(Messages.StudentUpdated);
        }
        //ok
        IDataResult<List<Student>> IStudentService.GetAll()
        {
            return new SuccessDataResult<List<Student>>(_studentDal.GetAll(), Messages.StudentListed);
        }

        private IResult CheckIfStudentExists(int studentId)
        {
            var result = _studentDal.GetAll(b => b.StudentId == studentId).Any();
            if (result)
            {
                return new ErrorResult(Messages.StudentExists);
            }
            return new SuccessResult();
        }

        public IDataResult<List<StudentSp>> GetStudent()
        {
            throw new NotImplementedException();
        }
        IDataResult<List<StudentDetailDto>> IStudentService.GetStudentDetails()
        {
            throw new NotImplementedException();
        }
    }
}
