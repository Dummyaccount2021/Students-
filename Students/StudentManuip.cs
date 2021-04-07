using System;
using System.Collections.Generic;
using System.Text;

namespace Students
{
    class StudentManuip
    {
        IO io = new IO();
 
        private DanceStudent[] dance;
        private JudoStudent[] judo;
        private NuseryStudent[] nurse;
        private Student[] roster;

        public StudentManuip()
        {
            String opt = options();

            int type = typeOfStudent(opt);

            switch (type) 
            {
                case 1:
                    if (!addStudent())
                        io.writeAMessage("class is full");
                    break;
            }



        }

        public bool initalizeAStudent(Student stu)
        {
           
            Console.WriteLine("what is your first name?");
            while (!stu.setFirstName(Console.ReadLine())) ;

            Console.WriteLine("what is your last name?");
            while (!stu.setLastName(Console.ReadLine())) ;

            Console.WriteLine("what is the student's favorite number?");
            while (!stu.setFavoriteNumber(Console.ReadLine())) ;

            return true;

        }

        public bool addStudent()
        {
            CurryStudent csa = new CurryStudent();

            if(initalizeAStudent(csa))
            {
                int n = 0;
                Student placeHolder = roster[n];

                while (placeHolder != null)
                {
                    n++;
                    if (n == roster.Length)
                        return false;

                    placeHolder = roster[n];
                }

                roster[n] = csa;
                return true;

            }
            return false;
        }

        public int typeOfStudent(string types)
        {
           return int.Parse(io.inputData("what type of student would you like to create " +types));
        }

        public int numberOfStudents()
        {
            return int.Parse(io.inputData("how many student are in this class?"));
        }

        public string options()
        {
            string opt = "\n1-Curry Student\n2-Dance Student";

            return opt;
        }
    }
}
