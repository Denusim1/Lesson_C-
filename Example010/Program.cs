int[] array = {14,42,3887,4,55,54,73,83};

int n = array.Length;
int find = 83;

int index = -1;

while(index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    
    index++;
}