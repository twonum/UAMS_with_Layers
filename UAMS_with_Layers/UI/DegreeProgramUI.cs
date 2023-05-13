using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week5_lab_challange1.DL;

namespace week5_lab_challange1.UI
{
    public class DegreeProgramUI
    {
        public static DegreeProgram takeInputForDegree()
        {
            Console.WriteLine("Enter Degree Name: ");
            string degree_name = Console.ReadLine();
            Console.WriteLine("Enter Duration: ");
            int duration = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Seats for this Degree: ");
            int seats = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter No of Subjects Offered in the Degree: ");
            int no_of_subjects = int.Parse(Console.ReadLine());

            DegreeProgram obj = new DegreeProgram(degree_name, duration, no_of_subjects);
            for (int i = 0; i < no_of_subjects; i++)
            {
                Subject sub = SubjectUI.InputForSubject();
                if (obj.AddSubject(sub))
                {
                    if (!(SubjectDL.subjectsList.Contains(sub)))
                    {
                        SubjectDL.add_subjects_to_list(sub);
                    }
                    Console.WriteLine("Subject Added");
                }
                else
                {
                    Console.WriteLine("Subject Not Added");
                    Console.WriteLine("20 credit hour limit exceeded");
                    no_of_subjects--;
                }
            }
            return obj;
        }
    }
}
