int[,,] GetArray(int size, int valueMin, int valueMax)
{
    int[,,] array = new int[size, size, size];
    int[] inArray = new int[3 * size];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = new Random().Next(valueMin, valueMax);
                while(inArray.Contains(array[i, j, k]))
                {
                    array[i, j, k] = new Random().Next(valueMin, valueMax);
                }
                inArray[i + j + k] = array[i, j, k];
            }
        }
    }

    return array;
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($" {array[i, j, k]}({i}, {j}, {k}) ");
            }
            Console.WriteLine();
        }
    }
}




int[,,] array = GetArray(2, 10, 100);
PrintArray(array);