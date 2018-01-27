using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Max;

namespace Array
{
    public class Car
    {
        public int Doors { get; private set; }
        public int Weight { get; set; }
        public List<Passenger> Passengers { get; set; }
        public int Limit { get; set; }

        // Добавить класс Passeger я полями (свойствами) рост, вес, имя, возраст
        // Добавить функцию (метод) фильтрирования пассажиров по параметрам
        // Написать по примеру на каждую LINQ команду

        public Car() { }

        public Car(int number)
        {
            Limit = 700;
            Weight = 500;
            Doors = (0 < number) && (number <= 4) ? number : 0;
        }

        public void PassengerExit()
        {
            int payload = Limit - Weight;
            var sumPassenger = Passengers.Sum(x => x.Weight);
            var dictionary = Passengers.ToDictionary(k => k.Weight, i => i.Name);

            Console.WriteLine("\nExit: ");
            foreach (var i in dictionary)
            {
                if (payload < sumPassenger)
                {
                    sumPassenger = sumPassenger - i.Key;
                    Console.Write(i.Value + " ");
                }
            }
        }
        
        //result = names.Where(n => Passengers.Contains(n)).ToList();

        //First()
        //FirstOrDefault()
        //Last()
        //LastOrDefault
        //Select
        //Where
        //Find
        //FindAll

    public void AddOr(int number)
    {
        while ((Doors < 4) && (number > 0))
        {
            Doors++;
            number--;
        }

        Console.WriteLine("Amount of doors:" + number);
    }
}
}
