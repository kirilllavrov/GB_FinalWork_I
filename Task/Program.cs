string[] Names = new string[6] { "Bob", "Liza", "John", "Ann", "Sara", "Am" };

int count = 0;

for (int i = 0; i < Names.Length; i++)
{
    if (Names[i].Length <= 3)
    {
        count++;
    }
}

string[] NamesSort = new string[count];
int j = 0;

for (int i = 0; i < Names.Length; i++)
{
    if (Names[i].Length <= 3)
    {
        NamesSort[j++] = Names[i];
    }
}


for (int i = 0; i < NamesSort.Length; i++)
{
    Console.WriteLine(NamesSort[i]);
}