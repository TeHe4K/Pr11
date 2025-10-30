using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr11.Classes
{
    internal class StudentList
    {
        private List<Student> students = new List<Student>();
        public StudentList()
        {
            students.Add(new Student("Иванов Иван Иванович"));
            students.Add(new Student("Сидоров Алексей Валерьевич"));
            students.Add(new Student("Петрова Анна Сергеевна"));
        }
        public string DisplayStudents()
        {
            return DisplayStudents(",");
        }
        public string DisplayStudents(string separator)
        {
            var name = students.Select(s => s.FullName);
            return string.Join(separator, name);
        }
        public List<Student> GetStudents()
        {
            return students;
        }
    }
}
