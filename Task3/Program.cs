// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, columns];
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        array[i, j] = Convert.ToInt32(new Random().Next(10));
        System.Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine("Среднее арифметическое каждого столбца:");
for (int i = 0; i < columns; i++)
{
    double arithmeticMean = 0;
    for (int j = 0; j < rows; j++)
    {
        arithmeticMean += array[j, i];
    }
    Console.Write(Math.Round(arithmeticMean / rows, 2) + "\t");
}