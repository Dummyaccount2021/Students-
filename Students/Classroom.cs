using System;
using System.Collections.Generic;
using System.Text;

namespace Students
{
    class Classroom
    {
        IO io = new IO();

        CurryStudent [] csa = new CurryStudent[2];
        DanceStudent [] dance = new DanceStudent[2];
        JudoStudent [] judo = new JudoStudent[2];
        NuseryStudent[] nurse = new NuseryStudent[2];
        public Classroom()
        {
            for (int a = 0; a < csa.Length; a++)
            {
                csa[a] = new CurryStudent();

                Console.WriteLine("what is your first name?");
                while (!csa[a].setFirstName(Console.ReadLine())) ;

            }
        }

      
    }
}
