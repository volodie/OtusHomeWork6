namespace OtusHomeWork6_1
{
    internal class Catalog
    {
        public List<Planet> plList = new List<Planet>();

        int counter = 0;

        public (int?, int?, string) GetPlanet(string name)
        {
            
            if (counter != 2) {
                foreach (var item in plList)
                {
                    if (item.Name == name)
                    {
                        counter++;
                        return (item.NumberFromSun, item.EquatorLength, item.Name);
                    }
                        
                }
                counter++;
                return (null, null, "Не удалось найти планету");
            }
            counter = 0;
            return (null, null, "Вы спрашиваете слишком часто!");

        }
    }
}
