using System;
using System.Collections.Generic;
using System.Text;

namespace Students
{
    class IO
    {
        public IO()
        {

        }

        public void writeAMessage(string message)
        {
            Console.WriteLine(message);
        }

        public string inputData(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }
    }
}
