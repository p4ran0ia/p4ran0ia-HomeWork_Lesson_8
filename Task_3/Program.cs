// произведение чисел в матрице
// Задачу сделал, как показал на семинаре :)

Console.Clear();

void FillTable(int[,] tab)
{
    for (int i = 0; i < tab.GetLength(0); i++)
    {
        for (int j = 0; j < tab.GetLength(1); j++)
            tab[i, j] = new Random().Next(2, 10);
    }
}

void PrintTable(int[,] tab)
{
    for (int i = 0; i < tab.GetLength(0); i++)
    {
        for (int j = 0; j < tab.GetLength(1); j++)
            Console.Write($"{tab[i, j]} ");
        Console.WriteLine();
    }

}

void Multiplier(int[,] tabOne, int[,] tabTwo)
{
    int[,] tabThree = new int[3, 3];
    for (int i = 0; i < tabOne.GetLength(0); i++)
        for (int j = 0; j < tabOne.GetLength(1); j++)
        {
            tabThree[i, j] = tabOne[i, j] * tabTwo[i, j];
        }
    PrintTable(tabThree);
}

int[,] tableOne = new int[3, 3];
int[,] tableTwo = new int[3, 3];
FillTable(tableOne);
FillTable(tableTwo);
PrintTable(tableOne);
Console.WriteLine();
PrintTable(tableTwo);
Console.WriteLine();
Multiplier(tableOne, tableTwo);
