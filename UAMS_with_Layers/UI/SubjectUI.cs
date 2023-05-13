using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week5_lab_challange1.UI
{
    public class SubjectUI
    {
        public static void viewSubjects(Student sub)
        {
            foreach (Subject subject in sub.regDegree.subjects)
            {
                Console.WriteLine(subject.type + "\t\t" + subject.code + "\t\t" + subject.subjectFees);
            }
        }
        public static Subject InputForSubject()
        {
            Console.WriteLine("Enter Subject Code: ");
            int code = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Subject Type: ");
            string type = (Console.ReadLine());
            Console.WriteLine("Enter Credit Hours for this Subject: ");
            int credit_hours = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Fees for this Subject: ");
            int fee = int.Parse(Console.ReadLine());
            Subject obj = new Subject(code, type, credit_hours, fee);
            return obj;
        }
    }
}
