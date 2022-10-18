
// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
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
int Kolichestvo_chisel(int[] massiv)
{
    int kolichestvo = 0;
        for(int i =0; i<massiv.Length;i++)
        {
            if (massiv[i]>=10 && massiv[i]<=99) kolichestvo++;
        } 
    return kolichestvo;
}
Console.Write("Введите минимальное число для значений массива:");
int Min = int.Parse(Console.ReadLine()??"0");
Console.Write("Введите максимальное число для значений массива:");
int Max = int.Parse(Console.ReadLine()??"0");
int[] Array = new int[123];
Zapolnenie_Massiva(Array, Min, Max+1);
Pechat_Massiva(Array);
Console.WriteLine("");
Console.WriteLine($"Количество элементов в диапазоне [10,99]: {Kolichestvo_chisel(Array)}");