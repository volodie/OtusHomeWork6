using System;
using System.Collections.Generic;
using System.Linq;
namespace OtusHomeWork6
{
    internal class PlanetsInfo
    {
        public void GetPlanetsInfo()
        {
            var planetVenus = new
            {
                Name = "Венера",
                NumberFromSun = 2,
                EquatorLength = 38025,
                PreviuosPlanet = (string)null
            };
            Console.WriteLine($"Название планеты: {planetVenus.Name}");
            Console.WriteLine($"Порядковый номер от Солнца: {planetVenus.NumberFromSun}");
            Console.WriteLine($"Длина экватора: {planetVenus.EquatorLength}");
            Console.WriteLine($"Предыдущая планета: {planetVenus.PreviuosPlanet}");
            Console.WriteLine($"{planetVenus.Name} равняется Венере " + planetVenus.Equals(planetVenus));
            Console.WriteLine("-------------------------------------------");

            var planetEarth = new
            {
                Name = "Земля",
                NumberFromSun = 3,
                EquatorLength = 40075,
                PreviuosPlanet = planetVenus
            };
            Console.WriteLine($"Название планеты: {planetEarth.Name}");
            Console.WriteLine($"Порядковый номер от Солнца: {planetEarth.NumberFromSun}");
            Console.WriteLine($"Длина экватора: {planetEarth.EquatorLength}");
            Console.WriteLine($"Предыдущая планета: {planetEarth.PreviuosPlanet.Name}");
            Console.WriteLine($"{planetEarth.Name} равняется Венере " + planetEarth.Equals(planetVenus));
            Console.WriteLine("-------------------------------------------");

            var planetMars = new
            {
                Name = "Марс",
                NumberFromSun = 4,
                EquatorLength = 21344,
                PreviuosPlanet = planetEarth
            };
            Console.WriteLine($"Название планеты: {planetMars.Name}");
            Console.WriteLine($"Порядковый номер от Солнца: {planetMars.NumberFromSun}");
            Console.WriteLine($"Длина экватора: {planetMars.EquatorLength}");
            Console.WriteLine($"Предыдущая планета: {planetMars.PreviuosPlanet.Name}");
            Console.WriteLine($"{planetMars.Name} равняется Венере " + planetMars.Equals(planetVenus));
            Console.WriteLine("-------------------------------------------");

            var planetVenus2 = new
            {
                Name = "Венера",
                NumberFromSun = 2,
                EquatorLength = 38025,
                PreviuosPlanet = (string)null
            };
            Console.WriteLine($"Название планеты: {planetVenus2.Name}");
            Console.WriteLine($"Порядковый номер от Солнца: {planetVenus2.NumberFromSun}");
            Console.WriteLine($"Длина экватора: {planetVenus2.EquatorLength}");
            Console.WriteLine($"Предыдущая планета: {planetVenus2.PreviuosPlanet}");
            Console.WriteLine($"{planetVenus.Name} равняется Венере " + planetVenus.Equals(planetVenus));
            Console.WriteLine("-------------------------------------------");
        }
      
    }
}
