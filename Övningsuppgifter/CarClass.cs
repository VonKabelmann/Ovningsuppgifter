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
            Length = random.Next(3, 14);// + random.NextDouble();
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
            Random random = new Random();
            CarClass[] cars = new CarClass[10];
            for (int i = 0; i < cars.Length; i++)
            {
                var sameLength = false;
                CarClass newCar = new CarClass();
                newCar.Color = car.Color;
                for (int j = 0; j < i; j++)
                {
                    if (cars[j].Length == newCar.Length)
                    {
                        sameLength = true;
                    }
                }
                if (sameLength)
                {
                    i--;
                }
                else
                {
                    cars[i] = newCar;
                }
            }

            return cars;

        }
    }
}
