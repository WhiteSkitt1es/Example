int[] array = { 1, 22, 36, 98, 59, 67, 73, 85, 98 };

int number = array.Length;
int find = 98;

int index = 0;

while (index < number)
{
    if(array[index] == find)
    {
     Console.WriteLine(index);
     break;
    }
    index++;
}