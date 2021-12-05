using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_PerStuTea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Greet();

            Teacher teacher = new Teacher();
            teacher.Greet();
            teacher.SetAge(43);
            teacher.Explain();


            Student student = new Student();
            student.Greet();
            student.SetAge(17);
            student.ShowAge();
            student.Study();
        }
    }
}
