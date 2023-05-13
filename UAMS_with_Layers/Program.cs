using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using EZInput;
using static week5_lab_challange1.DegreeProgram;
using static week5_lab_challange1.Student;
using static week5_lab_challange1.Subject;
using week5_lab_challange1.UI;
using week5_lab_challange1.DL;

namespace week5_lab_challange1
{
    class Program
    {
        public static void Main(string[] args)
        {
            string option;
            do
            {
                option = Menu();
                Console.Clear();
                if (option == "1")
                {
                    if (DegreeProgramDL.degreesList.Count > 0)
                    {
                        Student s = StudentUI.takeInputForStudent();
                        StudentDL.add_student_to_list(s);
                    }
                    else
                    {
                        Console.WriteLine("No DegreeProgram available yet ! Enter Degree Program first...");
                        Console.ReadKey();
                    }
                }
                else if (option == "2")
                {
                    DegreeProgram degree = DegreeProgramUI.takeInputForDegree();
                    DegreeProgramDL.addDegree(degree);
                }
                else if (option == "3")
                {
                    Console.Clear();
                    List<Student> sorted_Students_List = new List<Student>();
                    sorted_Students_List = StudentDL.sort_students_acc_to_merit();
                    StudentDL.whom_to_give_admission(sorted_Students_List);
                    StudentUI.view_students();
                }
                else if (option == "4")
                {
                    Console.Clear();
                    StudentUI.Registered_Students();
                    Console.ReadKey();
                }
                else if (option == "5")
                {
                    Console.Clear();
                    StudentUI.specificStudents();
                }
                else if (option == "6")
                {
                    Console.Clear();
                    Console.Write("Enter Student name: ");
                    string name = Console.ReadLine();
                    Student student = StudentDL.studentList.Find(e => e.name == name);
                    if (student != null)
                    {
                        SubjectUI.viewSubjects(student);
                        Subject.register_subject(student);

                    }
                }
                else if (option == "7")
                {
                    StudentUI.view_fee();
                }
                else
                {
                    Console.WriteLine("Invalid Option ");
                }
                Console.Clear();
            } while (option != "8");
            Console.Write("Thank You for using UMS...! ");
            Console.ReadKey();
        }
        static string Menu()
        {
            Console.Clear();
            print_header();
            Console.WriteLine("\n1)Add Student");
            Console.WriteLine("2)Add Degree Program");
            Console.WriteLine("3)Generate Merit List");
            Console.WriteLine("4)View Registered Students");
            Console.WriteLine("5)View Students of Specific Program");
            Console.WriteLine("6)Register Subjects for a Specific Student");
            Console.WriteLine("7)Calculate Fees for all Registered Students");
            Console.WriteLine("8)Exit");
            Console.Write("Option--> ");
            string option = Console.ReadLine();
            return option;
        }
        static void print_header()
        {
            Console.Clear();
            Console.WriteLine("******************************************************");
            Console.WriteLine("                         UAMS                         ");
            Console.WriteLine("******************************************************");
        }

    }
}