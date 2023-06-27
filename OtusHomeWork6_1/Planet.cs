namespace OtusHomeWork6_1
{
    internal class Planet
    {
        public Planet(string name, int numberFromSun, int equatorLength, Planet previuosPlanet)
        {
            Name = name;
            NumberFromSun = numberFromSun;
            EquatorLength = equatorLength;
            PreviuosPlanet = previuosPlanet;
        }

        public string Name { get; set; }
        public int NumberFromSun { get; set; }
        public int EquatorLength { get; set; }
        public Planet PreviuosPlanet { get; set; }
    }
}
