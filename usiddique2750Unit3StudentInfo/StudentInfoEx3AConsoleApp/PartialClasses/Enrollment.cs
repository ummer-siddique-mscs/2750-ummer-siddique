﻿using System;
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
            this.Id = id;
            this.GradeType = gradeType;
            this.Grade = grade;
            this.Student = student;
            student.Enrollments.Add(this);
            this.Section = section;
            section.Enrollments.Add(this);
        }

        public AssignmentGrade FindAssignmentGrade(string assign)
        {
            AssignmentGrade foundAssignmentGrade = null;
            foreach (AssignmentGrade e in this.AssignmentGrades)
            {
                if (e.Assignment.Assign == assign)
                {
                    foundAssignmentGrade = e;
                    break;
                }
            }
            return foundAssignmentGrade;
        }

    }
}
