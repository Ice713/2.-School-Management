using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.School_Management
{
    internal class Student : Person
    {
        public int GradeLever { get; set; }

        public Student(string name, int gradeLevel) : base(name)
        {
            GradeLever = gradeLevel;
        }

        public override string GetDetails()
        {
            return $"{base.GetDetails()}\nGrade Level: {GradeLever}";
        }
    }
}
