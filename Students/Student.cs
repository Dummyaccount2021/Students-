using System;
using System.Collections.Generic;
using System.Text;

namespace Students
{
    class Student
    {
        //properties

        protected string _firstName;
        protected string _lastName;
        protected string _id;
        protected char _gender;
        protected int _favNumber;
        protected Date _age; // composition

        public Student()
        {
            //constructor
        }
        
        public Student(string _firstName, string _lastName)
        {

        }

        public Student(string _firstName, string _lastName, string _id)
        {

        }

        public string setfName(string name)
        {
            _firstName = name;

            return _firstName;
           
        }

        public string getFName()
        {
            return _firstName;
        }


        public string setLastName(string name)
        {
            _lastName = name;

            return _lastName;
        }

        public string getLastName()
        {
            return _lastName;
        }
        public void setAge(string age)
        {
            try
            {
                int.Parse(age);
            }
            catch
            {
                Console.WriteLine(age + " is an invalid input");
            }
        }

        public virtual bool setId(string id)
        {
            //@00984834
            string temp = id.Substring(1);

            if(id.Length != 9)
            {
                return false;
            }
            else if(id[0] != '@')
            {
                return false;
            }
            else if (!int.TryParse(temp, out _))
            {
                return false;
            }
            else
            {
                _id = id;
                return true;
            }
        }

    }
}
