using System;
using System.Collections.Generic;
using System.Linq;

namespace Max
{

    class Program
    {
        static void Main()
        {
            var car = new Car(4);

            var passenger = new Passenger
            {
                Age = 24,
                Name = "Max",
                Height = 170,
                Weight = 70
            };
            var passenger1 = new Passenger
            {
                Age = 30,
                Name = "Miki",
                Height = 160,
                Weight = 65
            };
            var passenger2 = new Passenger
            {
                Age = 16,
                Name = "Oleg",
                Height = 160,
                Weight = 55
            };
            var passenger3 = new Passenger
            {
                Age = 25,
                Name = "Denis",
                Height = 185,
                Weight = 85
            };

            var passenger4 = new Passenger
            {
                Age = 45,
                Name = "Vova",
                Height = 199,
                Weight = 100
            };
            
            car.Passengers = new List<Passenger>
            {
                passenger,
                passenger1,
                passenger2,
                passenger3,
                passenger4
            };
            
            // Создать функцию поиска пассажира по имени
            // Сумма веса машины и пассажиров
            // Если больше лимита (машина 500кг, лимит 700кг) 
            // 5 пассажиров * 70 = 350кг
            // Функция должна выводить список пассажиров на выход
            // 60 70 80 90 100 + 500 = 900 - 700 = 200

            void SearchName(string name, List<Passenger> list)
            {
                var result = list.Where(x => x.Name == name).Select(x => x.Name).ToList();
                if (result.Count != 0)
                {
                    Console.Write(String.Join(",", result) + " in the list");
                }
                else
                {
                    Console.Write("no in list");
                }
            }
            //SearchName("Denis", car.Passengers);

            car.PassengerExit();

            //var more80 = car.Passengers.Where(x => x.Weight > 80).Select(x => x.Name).ToList();
            //Console.Write("More 80kg: " + string.Join(",", more80));

            Console.ReadLine();
        }
    }
}