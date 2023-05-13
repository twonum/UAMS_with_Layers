using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week5_lab_challange1
{
    public class DegreeProgram
    {
        public string degreeName;
        public float degreeDuration;
        public int seats;
        public int no_of_subject_offered;
        public List<Subject> subjects;

        public DegreeProgram(string degreeName, float degreeDuration, int seats)
        {
            this.degreeName = degreeName;
            this.degreeDuration = degreeDuration;
            this.seats = seats;
            subjects = new List<Subject>();
        }
        public void set_noOf_seats(int seats)
        {
            this.seats = seats;
        }


        public int calculateCreditHours()
        {
            int ch = 0;
            foreach (Subject item in subjects)
            {
                ch += item.creditHours;

            }
            return ch;
        }
        public bool isSubjectExists(Subject sub)
        {
            Subject s = subjects.Find(e => e.type == sub.type);
            if (s != null)
            {
                return true;
            }

            return false;
        }
        public bool AddSubject(Subject sub)
        {
            int creditHours = calculateCreditHours();
            if (creditHours + sub.creditHours
            <= 20)
            {
                subjects.Add(sub);
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
