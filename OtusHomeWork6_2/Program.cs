namespace OtusHomeWork6_2
{
    delegate Tuple<int, int, string> PlanetValidator(string message);
    internal class Program
    {
        
        private static void Main(string[] args)
        {
            
            Planet planetVenus = new Planet("Венера", 2, 38025, null);
            Planet planetEarth = new Planet("Земля", 3, 40075, planetVenus);
            Planet planetMars = new Planet("Марс", 4, 21344, planetEarth);

            PlanetsCatalog catalog = new PlanetsCatalog();
            catalog.plList.Add(planetVenus);
            catalog.plList.Add(planetEarth);
            catalog.plList.Add(planetMars);

            var findPlanet = catalog.GetPlanet("Земля", PlanetCheck.planetCheker, PlanetCheck.searchForbiddenPlanet);
            Console.WriteLine($"Название {findPlanet.Item3}, порядковый номер: {findPlanet.Item1}, длина экватора: {findPlanet.Item2}");
            var findPlanet1 = catalog.GetPlanet("Лимония", PlanetCheck.planetCheker, PlanetCheck.searchForbiddenPlanet);
            Console.WriteLine($"Название {findPlanet1.Item3}, порядковый номер: {findPlanet1.Item1}, длина экватора: {findPlanet1.Item2}");
            var findPlanet2 = catalog.GetPlanet("Марс", PlanetCheck.planetCheker, PlanetCheck.searchForbiddenPlanet);
            Console.WriteLine($"Название {findPlanet2.Item3}, порядковый номер: {findPlanet2.Item1}, длина экватора: {findPlanet2.Item2}");
        }
    }
}