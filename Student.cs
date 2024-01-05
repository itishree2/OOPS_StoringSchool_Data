using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_StoringSchoolDt
{
    internal class Student
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private int _class;

        public int Class
        {
            get { return _class; }
            set { _class = value; }
        }

        private char _section;

        public char Section
        {
            get { return _section; }
            set { _section = value; }
        }

        public Student(string n, int c, char s)
        {
            Name = n;
            Class = c;
            Section = s;

        }


    }
}


