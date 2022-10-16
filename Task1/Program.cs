// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран
using System;
                    
public class Program
{
    public static void Main()
    {
        int n = 0, a = 0, b = 0;
        int[] arr = null;
        
        Console.Write("Введите n - размер массива arr (n > 1): ");
        n = Int32.Parse(Console.ReadLine());
        while (n < 2)
        {
            Console.WriteLine("Ошибка: значение n должно быть больше 1!");
            Console.Write("Повторите ввод: ");
            n = Int32.Parse(Console.ReadLine());
        }
        
        Console.Write("Введите a - левую границу промежутка для заполнения нулями (a < n): ");
        a = Int32.Parse(Console.ReadLine());
        while (a <= 0 || a >= n)
        {
            Console.WriteLine("Ошибка: значение a должно быть больше 0 и меньше n!");
            Console.Write("Повторите ввод: ");
            a = Int32.Parse(Console.ReadLine());
        }
        
        Console.Write($"Введите b - правую границу промежутка для заполнения нулями (b > a и b <= n): ");
        b = Int32.Parse(Console.ReadLine());
        while (b <= a || b > n)
        {
            Console.WriteLine($"Ошибка: значение b должно быть больше a и меньше или равно n!");
            Console.Write("Повторите ввод: ");
            b = Int32.Parse(Console.ReadLine());
        }
        
        arr = new int[n];
        Console.Write("Полученный массив arr: ");
        for (int i = 0; i < arr.Length; i++)
            arr[i] = Convert.ToInt32(!((i + 1 > a) && (i + 1 < b)));
        Console.WriteLine(String.Join(", ", arr));
        
        Console.ReadKey(true);
    }
}
