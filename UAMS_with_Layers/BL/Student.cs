using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week5_lab_challange1
{

    public class Student
    {
        public string name;
        public int age;
        public double fsc_marks;
        public double ecat_marks;
        public double merit;
        public List<DegreeProgram> preferences;
        public List<Subject> regSubject;
        public DegreeProgram regDegree;
        public Student(string name, int age, double fscMarks, double ecatMarks, List<DegreeProgram> preferences)
        {
            this.name = name;
            this.age = age;
            this.fsc_marks = fscMarks;
            this.ecat_marks = ecatMarks;
            this.preferences = preferences;
            regSubject = new List<Subject>();
        }
        public void calculateMerit()
        {
            merit = (((fsc_marks / 1100) * 0.45f) + ((ecat_marks / 400) * 0.55f)) * 100;
        }
        public int getCreditHours()
        {
            int ch = 0;
            foreach (Subject item in regSubject)
            {
                ch += item.creditHours;
            }
            return ch;
        }
        public int calculateFee()
        {
            int fees = 0;
            foreach (Subject item in regSubject)
            {
                fees += item.subjectFees;
            }
            return fees;
        }

        public bool reg_student_subject(Subject s)
        {
            int stCH = getCreditHours();
            if (regDegree != null &&
            regDegree.isSubjectExists(s) && stCH +
            s.creditHours <= 9)
            {
                regSubject.Add(s);
                Console.WriteLine("Added");
                return true;
            }
            else
            {
                Console.WriteLine("A student cannot have more than 9 CH or Wrong Subject");
                return false;
            }
        }




    }



}
