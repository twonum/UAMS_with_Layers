using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week5_lab_challange1.DL
{
    public class SubjectDL
    {
        public static List<Subject> subjectsList = new List<Subject>();

        public static void add_subjects_to_list(Subject subject)
        {
            subjectsList.Add(subject);
        }
    }
}
