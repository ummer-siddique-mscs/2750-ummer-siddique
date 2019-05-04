using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoEx3AConsoleApp
{
    public partial class Enrollment
    {
        public Enrollment(int id, GradeTypesEnum gradeType, GradesEnum grade, Student student, Section section)
        {
            this.AssignmentGrades = new HashSet<AssignmentGrade>();
            this.Id= id;
            this.GradeType = gradeType;
            this.Grade = grade;
            section.Enrollments.Add(this);
            student.Enrollments.Add(this);

        }
    }
}
