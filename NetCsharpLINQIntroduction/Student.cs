using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCsharpLINQIntroduction
{
    public class Student
    {
        public string Name { get; set; }
        public string Lastname { get; set; }
        public int age { get; set; }
        public string univName { get; set; }
        public Student(string n, string ln, string un, int a)
        {
            Name = n;
            Lastname = ln;
            age = a;
            univName = un;
        }
        public override string ToString()
        {
            return $"{Name} - {Lastname} - {age} - {univName}";
        }
    }
}
