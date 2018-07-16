using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace nonsenseTutorials.gradeBook
{
    class GradeStatistics
    {
    public GradeStatistics()
    {
      HighestGrade = 0;
      LowestGrade = float.MaxValue;

    }
    public float AverageGrade;
    public float HighestGrade;
    public float LowestGrade;

    }
}
