// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
int[] arr = new int[123];
            int k = 0;
            Random rnd = new Random();
 
            Console.WriteLine("Исходный массив");
            for (int i = 0; i < 123; i++)
            {
                arr[i] = rnd.Next(0, 1000);
                
            }
 
            foreach(int element in arr)
            {
                Console.Write("{0} ", element);
                if (element > 10 && element < 99)
                {
                    k++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Колличество элементов из отрезка [10, 99] {0}", k);
