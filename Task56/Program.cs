//Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой 
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов

int[,] massiv = new int[4, 6];
FillArrayRandom(massiv);
PrintArray(massiv);
Console.WriteLine();
RowMinSum(massiv);
Console.WriteLine();
Console.WriteLine();
void RowMinSum(int[,] array)
{
    int RowMin = 0;
    int MinSumRow = 0;
    int RowSum = 0;
    for (int i = 0; i < massiv.GetLength(1); i++)
    {
        RowMin += massiv[0, i];
    }
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++) RowSum += massiv[i, j];
        if (RowSum < RowMin)
        {
            RowMin = RowSum;
            MinSumRow = i;
        }
        RowSum = 0;
    }
    Console.Write($"{MinSumRow + 1} строка");
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

// Функция заполнения массива рандомно числами от 1 до 9
void FillArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}
