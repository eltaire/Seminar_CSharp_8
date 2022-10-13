// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int rows = ReadInt("Введите количество строк: ");
int columns = ReadInt("Введите количество столбцов: ");
int[,] matrix = new int[rows, columns];
int[,] matrix2 = new int[rows, columns];
int[,] matrixFinal = new int[rows, columns];
Console.WriteLine("Первая матрица");
FillArrayRandom(matrix);
PrintArray2D(matrix);
Console.WriteLine("Вторая матрица");
FillArrayRandom(matrix2);
PrintArray2D(matrix2);
Console.WriteLine("Результат переможения двух матриц");

if (matrix.GetLength(0) != matrix2.GetLength(1))
{
    Console.WriteLine("Попробуйте заново, в этом виде матрицы не перемножить");
    return;
}
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix2.GetLength(1); j++)
    {
        matrixFinal[i, j] = 0;
        for (int k = 0; k < matrix.GetLength(1); k++)
        {
            matrixFinal[i, j] += matrix[i, k] * matrix2[k, j];
        }
    }
}

PrintArray2D(matrixFinal);
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

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

void PrintArray2D(int[,] array)
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
