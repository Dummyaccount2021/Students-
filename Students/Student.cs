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
        
        public Student(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
        }

        public Student(string firstName, string lastName, string id)
        {
            _firstName = firstName;
            _lastName = lastName;
            _id = id;
        }

        public bool setFirstName(string name)
        {
            _firstName = name;

            return true;
           
        }

        public string getFirstName()
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

        public bool setFavoriteNumber(string number)
        {
            if (int.TryParse(number, out int temp))
            {
                _favNumber = temp;
                return true;
            }
            else
                return false;

          
        }
        public string getFavoriteNumber()
        {
            return _favNumber.ToString();
        }

        public bool setGender(string gender)
        {
            if (gender.Length > 1)
            {
                return false;
            }
            else if (gender.Equals("m") || gender.Equals("M"))
            {
                _gender = gender[0];
                return true;
            }
            else if (gender.Equals("f") || gender.Equals("F"))
            {
                _gender = gender[0];
                return true;
            }
            else
                return false;
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
