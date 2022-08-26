// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,7 -> такого числа в массиве нет (1 строчка, 7 столбец)

int[,] GetArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(10);
            System.Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
    return array;
}
void CheckingItemIndices(int[,] array, int indexRow, int indexColumns)
{
    if (array.GetLength(0) > indexRow && array.GetLength(1) > indexColumns)
    {
        Console.WriteLine($"Элемент массива [{indexRow} {indexColumns}] равен: {array[indexRow, indexColumns]}");
    }
    else Console.Write($"Элемента с индексами[{indexRow} строчка, {indexColumns} столбец] в массиве нет. ");
}

Console.Write("Введите разряд массива, количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите позицию элемента в двумерном массиве i: ");
int indexRow = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите позицию элемента в двумерном массиве j: ");
int indexColumns = Convert.ToInt32(Console.ReadLine());

CheckingItemIndices(GetArray(rows, columns), indexRow, indexColumns);
