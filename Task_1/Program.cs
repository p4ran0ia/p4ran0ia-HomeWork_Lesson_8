// Строка по убыванию

Console.Clear();

void FillTable(int[,] tab)
{
    for (int i = 0; i < tab.GetLength(0); i++)
    {
        for (int j = 0; j < tab.GetLength(1); j++)
            tab[i, j] = new Random().Next(1, 10);
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

void Decreasing(int[,] tab)
{
    for (int i = 0; i < tab.GetLength(0); i++)
    {
        for (int j = 0; j < tab.GetLength(1); j++)
        {
            for (int k = 0; k < tab.GetLength(1) - 1; k++)
            {
                if (tab[i, k] < tab[i, k + 1])
                {
                    int t = tab[i, k];
                    tab[i, k] = tab[i, k + 1];
                    tab[i, k + 1] = t;
                }
            }
        }
    }
}
    
    int[,] table = new int[4, 5];
    FillTable(table);
    PrintTable(table);
    Console.WriteLine();
    Decreasing(table);
    PrintTable(table);




