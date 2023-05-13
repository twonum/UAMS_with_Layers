using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week5_lab_challange1.DL;

namespace week5_lab_challange1.UI
{
    public class StudentUI
    {
        public static Student takeInputForStudent()
        {
            Console.Clear();
            Console.WriteLine("Enter Student Name: ");
            string student_name = Console.ReadLine();
            Console.WriteLine("Enter Age: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Fsc Marks: ");
            int fsc_marks = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Ecat Marks: ");
            int ecat_marks = int.Parse(Console.ReadLine());

            Console.WriteLine("Available Degree Programs:");
            for (int i = 0; i < DegreeProgramDL.degreesList.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {DegreeProgramDL.degreesList[i].degreeName}");
            }

            Console.WriteLine("Enter Preferences to Select : ");
            int no_of_preferences = int.Parse(Console.ReadLine());
            List<DegreeProgram> preferences = new List<DegreeProgram>();
            for (int i = 0; i < no_of_preferences; i++)
            {
                Console.WriteLine($"Enter Preference no { i + 1}:");
                string name_of_preference = Console.ReadLine();
                DegreeProgram degree_name = DegreeProgramDL.degreesList.Find(d => d.degreeName == name_of_preference);
                if (degree_name != null)
                {
                    preferences.Add(degree_name);
                }
                else
                {
                    Console.WriteLine("In Degree programs \'" + name_of_preference + "\' not found!");
                }
            }
            Student s = new Student(student_name, age, fsc_marks, ecat_marks, preferences);
            return s;

        }

        public static void view_fee()
        {
            foreach (Student item in StudentDL.studentList)
            {
                Console.WriteLine(item.name + " has to Pay " + item.calculateFee() + "rs Fee");
                Console.ReadKey();
            }
        }

        public static void view_students()
        {
            foreach (Student student in StudentDL.studentList)
            {
                if (student.regDegree != null)
                {
                    Console.WriteLine(student.name + " got admission in " + student.regDegree.degreeName);
                }
                else
                {
                    Console.WriteLine(student.name + " did not get admission in " + student.regDegree.degreeName);

                }
            }
            Console.ReadKey();
        }

        public static void specificStudents()
        {
            Console.WriteLine("Enter Degree Name: ");
            string name = Console.ReadLine();
            DegreeProgram degree = DegreeProgramDL.degreesList.Find(e => e.degreeName == name);
            if (degree != null)
            {
                Console.WriteLine("Name\t\tAge\t\tFsc Marks\t\tEcat Marks");

                foreach (Student student in StudentDL.studentList)
                {
                    if (student.regDegree != null)
                    {
                        if (student.regDegree == degree)
                        {
                            Console.WriteLine(student.name + "\t" + student.age + "\t" + student.fsc_marks + "\t" + student.ecat_marks);
                        }
                    }
                }
            }
            Console.ReadKey();
        }

        public static void Registered_Students()
        {
            Console.WriteLine("Name\t\tAge\t\tFsc Marks\t\tEcat Marks");
            foreach (Student student in StudentDL.studentList)
            {
                Console.WriteLine(student.name + "\t" + student.age + "\t" + student.fsc_marks + "\t" + student.ecat_marks);
            }
            Console.ReadKey();
        }
    }
}
