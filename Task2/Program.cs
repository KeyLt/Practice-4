//Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива
void Zapolnenie_Massiva(int[] massiv)
{
    Random Znach = new Random();
    for (int s = 0; s < massiv.Length; s++)
    {
        massiv[s] = Znach.Next(-9, 10);
    }
}
void Pechat_Massiva(int[] massiv)
{
    foreach (var item in massiv)
    {
        Console.Write($"{item} ");
    }
}
int[] Array = new int[12];
Zapolnenie_Massiva(Array);
Pechat_Massiva(Array);
Console.WriteLine(" ");
int summa_polojitelnih = 0;
int summa_otricatelnih = 0;
for (int s = 0; s < Array.Length; s++)
{
    if (Array[s] < 0)
    {
        summa_otricatelnih += Array[s];
    }
    if (Array[s] > 0)
    {
        summa_polojitelnih += Array[s];
    }
};
Console.WriteLine($"Сумма положительных чисел {summa_polojitelnih}");
Console.WriteLine($"Сумма отрицательных чисел {-summa_otricatelnih}");