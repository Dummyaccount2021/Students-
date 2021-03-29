using System;
using System.Collections.Generic;
using System.Text;

namespace Students
{
    class initalizedStudents
    {
        Student student = new Student();
        IO io = new IO();
        public initalizedStudents()
        {
            setName();

            Console.WriteLine(getName());
        }

        public void setName()
        {
           student.setfName(io.inputData("What is your first name?"));
        }

        public string getName()
        {
            return student.getFName();
        }
    }
}
