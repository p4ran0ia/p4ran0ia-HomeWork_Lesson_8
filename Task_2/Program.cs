// минимальная сумма строки

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

int[,] table = new int[4, 4];
FillTable(table);
PrintTable(table);

Console.WriteLine();
int minSum = Int32.MaxValue;
int indexLine = 0;
for (int i = 0; i < table.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < table.GetLength(1); j++)
        sum += table[i, j];
    if (sum < minSum)
    {
        minSum = sum;
        indexLine = i + 1;
    }
}

Console.WriteLine($"Минимальная сумма в строке {indexLine}");