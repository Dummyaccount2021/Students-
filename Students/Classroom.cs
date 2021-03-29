using System;
using System.Collections.Generic;
using System.Text;

namespace Students
{
    class Classroom
    {
        CurryStudent curryStudent = new CurryStudent();
        IO io = new IO();

        private Student _student;
        public Classroom()
        {

        }

        public void setFirstName()
        {
            string name = io.inputData("what is the student's first name?");

            curryStudent.setfName(name);
        }

        public string displaysomething(string temp)
        {
            return "";
        }

        public string displaysomething(int temp)
        {
            return "";
        }
    }
}
