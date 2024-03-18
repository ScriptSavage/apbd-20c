
int[] tab = { 1, 2, 4, 3, 2, 4, 451, 1 };

static int GetAverage(int[]tab)
{
    int sum = 0;
    for (int i = 0; i < tab.Length; i++)
    {
        sum += tab[i];
    }
    return sum / tab.Length;
} 