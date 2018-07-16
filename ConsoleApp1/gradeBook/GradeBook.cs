using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace nonsenseTutorials.gradeBook
{
  class GradeBook
  {
    public GradeBook()
    {
      grades = new List<float>();
    }

    public GradeStatistics ComputeStatistics()
    {
      GradeStatistics stats =  new GradeStatistics();

      float sum = 0;

      foreach(float grade in grades)
      {
        stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
        stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
        sum += grade;
      }

      if (grades.Count != 0)
      {
        stats.AverageGrade = sum / grades.Count;
      }
      return stats;
    }

    public void AddGrade(float grade)
    {
      grades.Add(grade);
    }
    List<float> grades = new List<float>();
  }
}
