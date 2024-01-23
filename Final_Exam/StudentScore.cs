using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Exam;

public class StudentScore
{
    public string StudentName { get; set; } = null!;
    public int Point { get; set; }
    public StudentScore(string studentName, int point)
    {
        StudentName = studentName;
        Point = point;
    }
}