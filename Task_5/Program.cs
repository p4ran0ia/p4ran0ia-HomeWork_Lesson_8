void PrintTable(int[,] tab)
{
    for (int i = 0; i < tab.GetLength(0); i++)
    {
        for (int j = 0; j < tab.GetLength(1); j++)
            Console.Write($"{tab[i, j]} ");
        Console.WriteLine();
    }

}

int[,] table = new int[4, 4];
int num = 1;
int i = 0;
int j = 0;

while (num <= table.GetLength(0) * table.GetLength(1))
{
    table[i,j] = num;
    if (i <= j + 1 && i + j < table.GetLength(0) - 1)
        ++j;
    else if (i < j && i + j >= table.GetLength(0) - 1)
        ++i;
    else if (i >= j && i + j > table.GetLength(0) - 1)
        --j;
    else
        --i;
    ++num;
}

PrintTable(table);