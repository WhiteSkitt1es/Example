void FillArray(int[] collection);
{
    int length = collection.length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int col);
{
    int count = col.Length;
    int position = 0;
    while (position <count)
    {
        Console.Writeline(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find);
{
    int count = collection.Length;
    int index = 0;
    int position = 0;

    while (index < count)
    {
        if (collection[index] == find)
        {
          position = index;
        }
        index++;
    }
    return position;
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);
Console.Writeline();

int pos = IndexOf(array, 4);
Console.Writeline(pos);