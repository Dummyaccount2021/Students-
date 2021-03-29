using System;
using System.Collections.Generic;
using System.Text;

namespace Students
{
    class DanceStudent : Student
    {
        private string _danceStyle;
        protected string _specialty;
        public DanceStudent()
        {

        }

        public override bool setId(string id)
        {
            //types of dance
            //hip hop:  hphp
            //contemporary: contp
            //Jazz: Jazz
            //tap dance: tapd 

            string placeHolder = "dnce";

            if (id.Length != 4)
            {
                _danceStyle = placeHolder;
                return true;
            }
            else
            {
                _danceStyle = id;
                return true;
            }
                
        }
    }
}
