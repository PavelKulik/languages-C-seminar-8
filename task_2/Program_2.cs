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

int[] ArraySumRow(int[,] array)
{
    int[] sumArray = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        sumArray[i] = sum;
    }
    return sumArray;
}

int SearchRowMaximumSum(int[] sumArray)
{
    int index = 0;
    int sum = sumArray[0];
    for (int i = 1; i < sumArray.Length; i++)
    {
        if (sum > sumArray[i])
        {
            sum = sumArray[i];
            index = i;
        }
    }

    return index + 1;
}


int[,] array = GetArray(4, 5, 1, 10);
PrintArray(array);
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {SearchRowMaximumSum(ArraySumRow(array))}");
