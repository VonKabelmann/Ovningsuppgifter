using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övningsuppgifter
{
    public class CarClass
    {
        public enum Colors
        {
            Red,
            Blue,
            Green,
            Black,
            White
        }

        public Colors Color { get; private set; }
        public double Length { get; private set; }

        public CarClass()
        {
            Random random = new Random();
            Colors randColor = (Colors)random.Next(6);
            Color = randColor;
            Length = random.Next(3, 6);
        }

        public override string ToString()
        {
            return $"Color: {Color}, Length: {Length}";
        }

        //Övningsuppgift 32
        //Lägg till en statisk metod på klassen i uppgift 29.
        //Metoden ska ta en bil som inparameter och returnera en array med 10 bilar i samma färg, men med olika längd.

        public static CarClass[] GetTenCars(CarClass car)
        {
            Random random = new Random()
            CarClass[] cars = new CarClass[9];
            for (int i = 0; i < cars.Length; i++)
            {
                
            }
        }
    }
}
