using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week5_lab_challange1.DL
{
    public class DegreeProgramDL
    {
        public static List<DegreeProgram> degreesList = new List<DegreeProgram>();

        public static void addDegree(DegreeProgram program)
        {
            degreesList.Add(program);
        }
    }
}
