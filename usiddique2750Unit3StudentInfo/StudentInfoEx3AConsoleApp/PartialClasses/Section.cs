using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoEx3AConsoleApp
{
    public partial class Section
    {
        public Section(int id, short capacity, Course course, Term term)
        {
            this.Assignments = new HashSet<Assignment>();
            this.Enrollments = new HashSet<Enrollment>();
            this.Id = id;
            this.Capacity = capacity;
            course.Sections.Add(this);
            term.Sections.Add(this);

        }

        public Assignment FindAssignment(string assign)
        {
            //return this.Courses.Find(c => c.CourseNum == courseNum);
            Assignment foundAssignment = null;

            foreach (Assignment a in this.Assignments)
            {
                if (a.Assign == assign)
                {
                    foundAssignment = a;
                    break;
                }
            }
            return foundAssignment;
        }

    }
}

