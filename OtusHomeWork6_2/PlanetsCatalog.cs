

namespace OtusHomeWork6_2
{
    internal class PlanetsCatalog
    {
        public List<Planet> plList = new List<Planet>();

        public Tuple<int, int, string> GetPlanet(string name, PlanetValidator validator, PlanetValidator searchForbidPlanet)
        {
            var r1 = plList.FirstOrDefault(m => m.NumberFromSun == 0 && m.EquatorLength == 0 && m.Name == name);
            var r2 = plList.Select(m => m.Name).Contains(name);

            var validatorResult = validator(name);
            if (validatorResult.Item3.Length !=0) 
            {
                return validatorResult;
            }

            var searchPlanetResult = searchForbidPlanet(name);
            if (searchPlanetResult.Item3.Length != 0)
            {
                return searchPlanetResult;
            }

            if (r1 != null || !r2)
            {
                var result = Tuple.Create(0, 0, "Не удалось найти планету");
                return result;
            }
            else
            { 
                var result = from m in plList where m.Name == name select new Tuple<int, int, string>(m.NumberFromSun, m.EquatorLength, m.Name);
                return result.FirstOrDefault();
            }
         }
    }
}
