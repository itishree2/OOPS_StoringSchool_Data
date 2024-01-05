using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_StoringSchoolDt
{
    internal class Teacher
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _subject;

        public string Subject
        {
            get { return _subject; }
            set { _subject = value; }
        }

        private string _teacherClass;

        public string TeacherClass
        {
            get { return _teacherClass; }
            set { _teacherClass = value; }
        }

        private string _section;

        public string Section
        {
            get { return _section; }
            set { _section = value; }
        }

        public Teacher(string name, string subject, string teacherClass, string section)
        {
            Name = name;
            Subject = subject;
            TeacherClass = teacherClass;
            Section = section;
        }
    }
}

