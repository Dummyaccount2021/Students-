using System;
using System.Collections.Generic;
using System.Text;

namespace Students
{
    class CurryStudent : Student //inheritance
    {

        private string _major;
        private string _housingStatus;
        public CurryStudent()
        {

        }

        public override bool setId(string id)
        {
            //A00984834
            string temp = id.Substring(1);

            if (id.Length != 9)
            {
                return false;
            }
            else if (!char.IsUpper(id[0]))
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
