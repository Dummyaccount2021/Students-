using System;
using System.Collections.Generic;
using System.Text;

namespace Students
{
    class Date
    {
        private string _day;
        private string _month;
        private string _year;

        public Date()
        {

        }

        public bool setDay(string day)
        {
            // lenght cannot be longer than three digits
            //if input is longer one digit, the first digit cannot be greater than 3
            //if the first digit is equal 3 then the second digit cannot be greater than 1
            //if length is equal to 2, the first digit and second digit cannot be 0
            //if length 1, value has to be greater than or equal to 1
            if(!int.TryParse(day, out int result))
            {
                return false;
            }
            if (day.Length > 3)
            {
                //means input is longer than threee
                return false;
            }
            else if (day.Length == 1 && int.Parse(day) < 1)
            {
                //input length is 1 but the value is less than 1
                return false;
            }
            else if (day.Length == 2 && day[0] > 3)
            {
                return false;
            }
            else if (day.Length == 2 && day[0] == 3 && day[1] > 1)
            {

                return false;
            }
            else if (day.Length == 2 && day[0] == 0 && day[1] < 1)
            {
                return false;
            }
            else
            {
                day = _day;
                return true;
            }
                

        }

        public bool setMonth(string month)
        {
            if (int.TryParse(month, out int result))
            {
                if (result >= 1 || result <= 12)
                {
                    month = _month;
                    return true;
                }
                else return false;
            }
            else
            {
                return false;
            }
        }

        public bool setYear(string year)
        {
            //1900
            //length cannot be greater 4 or less than 4
            //first digit can not be less than 1 or greater than 2
            //first digit is greater than 1 second digit cannot be more than 0
            //if first digit is equal to 1, second digit has to equal 9
            //

            if (year.Length != 4)
            {
                return false;
            }
            else
            {
                if (!int.TryParse(year, out int result))
                {
                    return false;
                }
                else
                {
                    if (year[0] == 1)
                    {
                        if (year[1] != 9)
                        {
                            return false;
                        }
                    }
                    else if (year[0] == 2)
                    {
                        if (year[1] != 0)
                        {
                            return false;
                        }
                    }
                    else if (year[0] ==1 && year[2] !>= 4)
                    {
                        return false;
                    }
                    else if(year[0] ==2 && year[2] !<= 2)
                    {
                        return false;
                    }
                    year = _year;
                    return true;
                }
                    
            }

        }

    }
}
