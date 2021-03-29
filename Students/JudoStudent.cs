using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Students
{
    class JudoStudent : Student
    {
        protected string _stance;
        protected string _beltRank;
        public JudoStudent()
        {

        }

        public override bool setId(string id)
        {
           CultureInfo enUS = new CultureInfo("en-US"); 

            //first and second char have to be letters
            string temp = id.Substring(2);

            if (!char.IsLetter(id[0]) && char.IsLetter(id[1]))
            {
                return false;
            }
            else if(!DateTime.TryParse(temp, enUS,DateTimeStyles.None, out _))
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
