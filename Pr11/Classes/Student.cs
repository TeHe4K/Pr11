using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr11.Classes
{
    internal class Student
    {
        public string FullName { get; set; }
        public Student(string FullName)
        {
            this.FullName = FullName;
        }
        public override string ToString()
        {
            return FullName;
        }
    }
}
