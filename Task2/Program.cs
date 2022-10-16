// Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива
int[] arr = new int[12];
            int k = 0, sum = 0;
            Random rnd = new Random();
 
            Console.WriteLine("Исходный массив");
            for (int i = 0; i < 12; i++)
            {
                arr[i] = rnd.Next(0, 9);
            }
            
 
            foreach(int element in arr)
            {
                Console.Write("{0} ", element);
                if (element > 0)
                {
                    k++;
                    sum += element;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Cумма элементов {0}", sum);

