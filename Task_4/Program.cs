// заполнение 3Д массива рандомными неповторяющимися числами.
Console.Clear();

void FillArray(int[,,] arr)
{
    int[] helpArray = new int[arr.GetLength(0) * arr.GetLength(1) * arr.GetLength(2)];
    for (int i = 0; i < helpArray.Length; i++)
    {
        helpArray[i] = new Random().Next(10, 100);
        if (i > 0)
            for (int j = 0; j < i; j++)
            {
                while(helpArray[i] == helpArray[j])
                {
                    helpArray[i] = new Random().Next(10,100);
                    j = 0;
                }
            }
    }
    int count = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
        for (int j = 0; j < arr.GetLength(1); j++)
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                arr[i, j, k] = helpArray[count];
                count++;
            }

}

void PrintArray(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
        for (int j = 0; j < arr.GetLength(1); j++)
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                Console.WriteLine($"{arr[i, j, k]} ({i},{j},{k})");
            }

}

int[,,] array3D = new int[2, 2, 2];
FillArray(array3D);
PrintArray(array3D);

