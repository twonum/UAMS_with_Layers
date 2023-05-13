using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week5_lab_challange1.DL
{
    public class StudentDL
    {
        public static List<Student> studentList = new List<Student>();

        public static void add_student_to_list(Student s)
        {
            studentList.Add(s);
        }

        public static List<Student> sort_students_acc_to_merit()
        {
            List<Student> myList = new List<Student>();
            foreach (Student student in studentList)
            {
                student.calculateMerit();
            }
            myList = studentList.OrderByDescending(o => o.merit).ToList();
            return myList;
        }

        public static void whom_to_give_admission(List<Student> myList)
        {
            foreach (Student student in myList)
            {
                foreach (DegreeProgram p in student.preferences)
                {
                    if (p.seats > 0 && student.regDegree == null)
                    {
                        student.regDegree = p;
                        int seats = p.seats;
                        seats--;
                        p.set_noOf_seats(seats);
                        break;
                    }
                }
            }
        }
    }
}
