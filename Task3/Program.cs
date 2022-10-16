// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
int[] arr = new int[12];
            int k = 0, p = 0;
            Random rnd = new Random();
 
            Console.WriteLine("Исходный массив");
            for (int i = 0; i < 12; i++)
            {
                arr[i] = rnd.Next(99, 1000);
                
            }
 
            foreach(int element in arr)
            {
                Console.Write("{0} ", element);
                if (element % 2 == 0)
                {
                    k++;
                }
                if (element % 2 == 1)
                {
                    p++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Количество четных элементов {0}, Количество нечетных элементов {1}", k, p);
