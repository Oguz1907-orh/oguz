using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            TEST();
            //StudentTest();
            //StudentSpTest();
        }

        private static void TEST()
        {
            StudentManager studentManager = new StudentManager(new EfStudentDal());

            foreach (var student in studentManager.GetAll())
            {
                Console.WriteLine(student.studentName + " " + student.StudentSurname);
            }

        }
        //private static void StudentTest()
        //{
        //    StudentManager studentManager = new StudentManager(new EfStudentDal());
        //    var result = studentManager.GetStudentDetails();
        
        //    foreach (var student in result)
        //    {
        //        Console.WriteLine(student.StudentName );
        //    }


        //}
        //private static void StudentSpTest()
        //{
        //    StudentManager studentManager = new StudentManager(new EfStudentDal());
        //    var result = studentManager.GetStudent();
        //    //,new InstructorManager(new EfInstructorDal()),new CourseManager(new EfCourseDal()),new NoteManager(new EfNoteDal())
        //    foreach (var student in result)
        //    {
        //        Console.WriteLine(student.StudentName);
        //    }


        //}

    }
}
