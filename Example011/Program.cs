void FillArray(int[] collection)

{
    int Length = collection.Length;
    int index = 0;
    while(index<Length)
    {
        collection[index] = new Random().Next(1,10);
        index++;
    }
}

void PrintArray(int[] coll)
{
    int count = coll.Length;
    int position = 0;
    while(position<count)
    {
        Console.WriteLine(coll[position]);
        position++;
    }
}

int IndexOff(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while(index<count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
        if (position == -1)
        {
            Console.WriteLine("Такой элемент не найден");
            break;
        }
        
    }
    return position;
    
}



int[] array = new int[10];

FillArray(array);
array[4] = 4;
array[6] = 4;
PrintArray(array);
Console.WriteLine();
int pos = IndexOff(array,433);
Console.WriteLine(pos);