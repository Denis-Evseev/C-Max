using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main()
        {
            int[] msv = { 1, 3, 5, 7, 3, 2, 5, 7 };
            //var result = msv.Where(n => n > 5).Sum(); // 3, 4
            //Console.Write("Sum="+ result+ "\n");

            var res = msv.Select(n => n * 2);
            Console.Write(String.Join(",", res));
            
            //Console.WriteLine("csr");
            List<string> cars = new List<string> { "Nissan", "Aston Martin", "Chevrolet", "Alfa Romeo", "Chrysler", "Dodge", "BMW",
          "Ferrari", "Audi", "Bentley", "Ford", "Lexus", "Mercedes", "Toyota", "Volvo", "Subaru", "Жигули :)"};

            var sequence = cars.Where((p, i) => ((i % 2) == 1) && (p.Length > 9))/*.Select(p => p.Length)*/;//(i & 1)//четные элементы
            Console.Write(String.Join(" | ", sequence));
            
            var car = cars.First(p => p.Length == 5);//одноразовое соответствие, дефолт 1 элемент, если нет ошибка
            Console.WriteLine("First=" + car);
            var car2 = cars.FirstOrDefault(p => p.Length == 2);//тоже тока ошибку модно обрабатывать
            Console.WriteLine(car2 == null ? "Ничего не найдено :(" : car2);

            var car3 = cars.Last(p => p.Length == 5);//одноразовое соответствие, дефолт 1 элемент, если нет ошибка
            Console.WriteLine("Last=" + car3);
            var car4 = cars.LastOrDefault(p => p.Length == 2);//тоже тока ошибку модно обрабатывать
            Console.WriteLine(car4 == null ? "Ничего не найдено :(" : car4);

            var list = new List<int> { -71, 9, 6, -3, 43, 8, 10, 12, 14, 3, 9, 5, 791 };//int[] не работало
            int find = list.Find(x => x == 8);
            Console.WriteLine(find != default(int) ? "Элемент найден" : "Элемент не найден");

            //var query = sequence.Select(n => new
            //{
            //    Name = n,
            //    Length = n.Length
            //});//ругается антивир
            //foreach (var s in query)
            //{
            //    Console.WriteLine(s);
            //}
            Console.ReadLine();
        }
    }
}
