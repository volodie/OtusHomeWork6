using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtusHomeWork6_2
{
    internal class PlanetCheck
    {
        public static int i = 0;
        public static PlanetValidator planetCheker = Tuple<int, int, string> (string name) =>
        {
            i ++;
            if (i == 3)
            {
                i = 0;
                var result = Tuple.Create (0, 0, "Вы спрашиваете слишком часто");
                return result;
            }
            else 
            {
                var result = Tuple.Create(0, 0, "");
                return result;
            }
        };
        public static PlanetValidator searchForbiddenPlanet = Tuple<int, int, string> (string name) =>
        {
            if (name == "Лимония")
            {
                var result = Tuple.Create(0, 0, "Это запретная планета");
                return result;
            }
            else
            {
                return Tuple.Create(0, 0, ""); ;
            }
        };
    }
}
