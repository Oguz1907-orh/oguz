using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
   public  class StudentDetailDto:IDto
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string StudentSurname { get; set; }
        public string CourseName { get; set; }
        public string InstructorName { get; set; }
        public double ExamOne { get; set; }
        public double ExamTwo { get; set; }
        public double Average { get; set; }

    }
}
