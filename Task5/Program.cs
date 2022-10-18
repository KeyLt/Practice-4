// Найти сумму чисел одномерного массива стоящих на нечетной позиции
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
int Summa_chisel(int[] massiv)
{
    int summa = 0;
    for (int i = 0; i < massiv.Length; i++)
    {
        if (i % 2 == 1) summa += massiv[i];
    }
    return summa;
}
Console.Write("Введите минимальное число для значений массива:");
int Min = int.Parse(Console.ReadLine()??"0");
Console.Write("Введите максимальное число для значений массива:");
int Max = int.Parse(Console.ReadLine()??"0");
Console.Write("Введите длинну массива:");
int dlinna = int.Parse(Console.ReadLine() ?? "0");
int[] Array = new int[dlinna];
Zapolnenie_Massiva(max: Max+1, min: Min, massiv: Array);
Pechat_Massiva(Array);
Console.WriteLine(" ");
Console.WriteLine($"Сумма чисел на нечётной позиции: {Summa_chisel(Array)}");