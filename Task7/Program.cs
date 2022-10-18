// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
void Pechat_Massiva(double[] massiv)
{
    foreach (var item in massiv)
    {
        Console.Write($"{item} ");
    }
}
double Raznica_max_min(double[] massiv)
{
    double max = massiv[0] , min= massiv[0], raznica = 0;
    for (int i = 0; i < massiv.Length; i++)
    {
        if (massiv[i] > max)
        {
            max = massiv[i];
        }
        if (massiv[i] < min)
        {
            min = massiv[i];
        }
        raznica = max - min;
    }
    return raznica;
}
double[] Array = {0.158, 0.85, 8.468, 4.586, 99.85, 0.05};
Pechat_Massiva(Array);
Console.WriteLine(" ");
Console.Write($"Разница между максимальным и минимальным числом {Raznica_max_min(Array)}");