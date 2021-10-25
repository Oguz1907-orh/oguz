using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Note:IEntity
    {
        public int Id { get; set; }
        public int InstructorId { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public float ExamOne { get; set; }
        public float ExamTwo { get; set; }
        public float Average { get; set; }
        public int ExamYear { get; set; }

    }
}
