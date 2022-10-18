// Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
void Zapolnenie_Massiva(int[] massiv, int min, int max)
{
    Random Znach = new Random();
    for (int s = 0; s < massiv.Length; s++)
    {
        massiv[s] = Znach.Next(min, max);
    }
}
void Pechat_Massiva(int[] massiv)
{
    foreach (var item in massiv)
    {
        Console.Write($"{item} ");
    }
}
Console.Write("Введите минимальное число для значений массива:");
int Min = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите максимальное число для значений массива:");
int Max = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите длинну массива:");
int dlinna = int.Parse(Console.ReadLine() ?? "0");
int[] Array = new int[dlinna];
Zapolnenie_Massiva(max: Max + 1, min: Min, massiv: Array);
Pechat_Massiva(Array);
Console.WriteLine(" ");
for (int i = 0; i <= Array.Length / 2; i++)
{
    if (((Array.Length % 2) == 1) && (i == Array.Length / 2)) Console.WriteLine($"Массив имеет нечётное количество элементов у {Array[Array.Length / 2]} нет пары");
    else Console.WriteLine($"Произведение пары чисел: {Array[i] * Array[Array.Length -1 -i]}");
}