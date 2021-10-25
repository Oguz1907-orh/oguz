using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using Entities.SPs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//LINQ KULLANIMI
namespace DataAccess.Concrete.EntityFramework
{
    public class EfStudentDal : EfEntityRepositoryBase<Student, StudentContext>, IStudentDal
    {
        public List<StudentSp> GetStudent()
        {
            using (StudentContext context = new StudentContext())
            {
                var result2 = context.Students.FromSqlInterpolated($"EXEC [dbo].[GetStudents]");

                return (List<StudentSp>)result2;
                
                
            }
            
        }

        public List<StudentDetailDto> GetStudentDetails()
        {
            using (StudentContext context = new StudentContext())
            {
                var result = from n in context.Notes
                             join s in context.Students
                             on n.StudentId equals s.Id
                             join ins in context.Instructor on n.InstructorId equals ins.InstructorId
                             join co in context.Courses on n.CourseId equals co.CourseId
                             select new StudentDetailDto
                             {
                                 StudentId = s.StudentId,
                                 StudentName = s.StudentName,
                                 StudentSurname = s.StudentSurname,
                                 CourseName = co.CourseName,
                                 InstructorName = ins.InstructorName,
                                 ExamOne = n.ExamOne,
                                 ExamTwo = n.ExamTwo,
                                 Average = n.Average
                             };
                return result.ToList();
            }
        }
    }
}
