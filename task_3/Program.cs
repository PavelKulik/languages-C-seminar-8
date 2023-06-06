int[,] GetArray(int row, int col, int valueMin, int valueMax)
{
    int[,] array = new int[row, col];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(valueMin, valueMax);
        }
    }

    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {array[i, j]} ");
        }
        Console.WriteLine();
    }
}

bool isMatrixMultiplications(int[,] arrayA, int[,] arrayB)
{
    return arrayA.GetLength(1) == arrayB.GetLength(0);
}

int[,] MatrixMultiplications(int[,] arrayA, int[,] arrayB)
{
    int[,] mulArray = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
    for (int i = 0; i < arrayA.GetLength(0); i++)
    {
        for (int j = 0; j < arrayB.GetLength(1); j++)
        {
            for (int k = 0; k < arrayB.GetLength(0); k++)
                mulArray[i, j] += arrayA[i, k] * arrayB[k, j];
        }
    }
    return mulArray;
}

Console.Write("Введите строки первой матрици: ");
int rowA = int.Parse(Console.ReadLine()!);
Console.Write("Введите столбци первой матрици: ");
int colA = int.Parse(Console.ReadLine()!);
int[,] arrayA = GetArray(rowA, colA, 1, 10);
Console.Write("Введите строки второй матрици: ");
int rowB = int.Parse(Console.ReadLine()!);
Console.Write("Введите столбци второй матрици: ");
int colB = int.Parse(Console.ReadLine()!);
int[,] arrayB = GetArray(rowB, colB, 1, 10);
Console.WriteLine("Перввая матрица:");
PrintArray(arrayA);
Console.WriteLine("Втарая матрица:");
PrintArray(arrayB);
if (!isMatrixMultiplications(arrayA, arrayB))
    Console.WriteLine($"Количество столбцов первой матрицы не равно количеству строк второй матрицы");
else
{
    Console.WriteLine("Умножения матриц:");
    int[,] mulArray = MatrixMultiplications(arrayA, arrayB);
    PrintArray(mulArray);
}