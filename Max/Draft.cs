
            ////Задача: есть нули и единицы в массиве. 
            ////Надо для каждого нуля посчитать сколько единиц правее него и вывести сумму таких чисел. 
            ////Сделать за один проход.
            ////int n = Console.Read();
            //int[] array = new int[20];
            //Random rand = new Random();

            //for (int i = 0; i < array.Length; i++)
            //    array[i] = rand.Next() % 2;

            //foreach (int i in array)
            //{
            //    Console.Write(i);
            //}

            //int entry = 0;
            //int index_list = -1;
            //List<int> list = new List<int>();//список интеджер
            //for (int i = 0; i < array.Length - 1; i++)
            //{
            //    if ((array[i] == 0 || entry > 0) && array[i + 1] == 1)
            //    {
            //        entry++;
            //        if (entry == 1)
            //        {
            //            list.Add(1);
            //            index_list++;
            //        }
            //        else
            //        {
            //            list[index_list]++;
            //        }
            //    }
            //    else
            //    {
            //        entry = 0;
            //    }
            //}

            //if (list.Count != 0)//с list != null непохало
            //{
            //    Console.WriteLine("\ntotal:");
            //    foreach (int i in list)
            //    {
            //        Console.Write(i);
            //    }
            //    int sum = 0;
            //    foreach (int i in list)
            //    {
            //        sum += i;
            //    }
            //    Console.WriteLine("\nSumm numbers:");
            //    Console.WriteLine(sum);
            //}
            //else Console.WriteLine("\nSumm non");



            ////string[] arr = new string[] { "Anton", "Lew", "An", "Max", "leo", "Inna"};
            //car.Passenger("Anton", "Lew", "An", "Max", "leo", "Inna");
            ////car.Passenger;
            //foreach (string i in car.Passenger)
            //{
            //    Console.Write(i + ", ");
            //}
            ////var result =// array.TakeWhile(i => i == 1);
            ////    from i in array
            ////    where (i == 1)//Skip(индекс где 0 -1)
            ////    select i;
            ////foreach (int i in result) { Console.Write(i); }
            ////Console.WriteLine("\nSumm LINQ=" + result.Sum());
            //Console.ReadLine();