using System;
using System.Collections.Generic;
using System.Text;

namespace Students
{
    class Classroom
    {
        IO io = new IO();

        private CurryStudent[] csa;
        private DanceStudent[] dance;
        private JudoStudent[] judo;
        private NuseryStudent[] nurse;
        private Student[] stu;
        public Classroom()
        {
            for (int a = 0; a < csa.Length; a++)
            {
                csa[a] = new CurryStudent();

                Console.WriteLine("what is your first name?");
                while (!csa[a].setFirstName(Console.ReadLine())) ;

            }
        }

        public bool setStudentFName(Student stu)
        {
            if (stu.setFirstName(io.inputData("what is the student's first name?")))
            {
                return true;
            }
            else
                return false;
        }

        public bool setStudentLName(Student stu)
        {
            if (stu.setLastName(io.inputData("what is the student's last name?")))
            {
                return true;
            }
            else
                return false;
        }



    }
}
