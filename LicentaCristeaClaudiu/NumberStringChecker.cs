using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicentaCristeaClaudiu
{
    class NumberStringChecker
    {

        public NumberStringChecker ()
        {

        }

        public Boolean IsString(String s)
        {
            double d;
            Boolean isNumeric = double.TryParse(s, out d);
            if (isNumeric)
                return false;
            else
                return true;
        }

        public String TransformIfString(String s)
        {
            double d;
            Boolean isNumeric = double.TryParse(s, out d);
            if (isNumeric)
                return s;
            else
                return "'" + s + "'";
        }
    }
}
