
int[] tab = { 1, 2, 4, 3, 2, 4, 451, 1 };

static int GetMaxValue(int[]tab)
{
    int max = 0;
    for (int i = 0; i < tab.Length; i++)
    {
        if (tab[i] > max)
        {
            max = tab[i];
        }
    }

    return max;
} 

Console.WriteLine("Czesc");

Console.WriteLine(GetMaxValue(tab));