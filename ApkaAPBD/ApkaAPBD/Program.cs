
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


string name = "Maksymilian";

Console.WriteLine(name);


Console.WriteLine(GetMaxValue(tab));



int a = 10;
int b = 10;

Console.WriteLine(a);
Console.WriteLine(b);


Console.WriteLine(GetMaxValue(tab));

