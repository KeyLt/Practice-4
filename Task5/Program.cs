// Найти сумму чисел одномерного массива стоящих на нечетной позиции

int[] arr = new int[20];
            int k = 0, sum = 0;
            Random rnd = new Random();
 
            Console.WriteLine("Исходный массив");
            for (int i = 0; i < 20; i++)
            {
                arr[i] = rnd.Next(0, 50);
                
            }
        foreach(int element in arr)
            {
                Console.Write("{0} ", element);
            }
                sum = arr[0] + arr[1] + arr[3] + arr[5] + arr[7] + arr[9] + arr[11] + arr[13] + arr[15] + arr[17] + arr[19];
            // foreach(int element in arr)
            // {
            //     Console.Write("{0} ", element);
            //     if (i % 2 == 1 && i = 0)
            //     {
            //         k++;
            //         sum += element;
            //     }
            // }
            Console.WriteLine();
            Console.WriteLine("Cуммa чисел одномерного массива стоящих на нечетной позиции {0}", sum);