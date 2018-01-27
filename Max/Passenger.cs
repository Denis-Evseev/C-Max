using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max
{
    public class Passenger
    {
        //public Guid Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }

        public Passenger() {}

        public Passenger(string name, int age, int height, int weight)
        {
            //Id = Guid.NewGuid();
            Name = name;
            Age = age;
            Height = height;
            Weight = weight;
        }
    }
}
