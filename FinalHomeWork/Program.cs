Console.Clear();
string[] array = newArray();
string[] result = Find(array, 3);

Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Green; 
Console.WriteLine($"Вы задали массив: [{string.Join(", ", array)}]");
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine($"Выбранные элементы массива по условию задачи: [{string.Join(", ", result)}]");
Console.ResetColor();


string[] Find(string[] input, int k) {
    string[] output = new string[CountLess(input, k)];

    for(int i = 0, j = 0; i < input.Length; i++) {
        if(input[i].Length <= k) {
            output[j] = input[i];
            j++;
        }
    }

    return output;
}

int CountLess(string[] input, int k) {
    int count = 0;

    for(int i = 0; i < input.Length; i++) {
        if(input[i].Length <= k) {
            count++;
        }
    }

    return count;
}

string[] newArray() {
    Console.Write("Введите значения через пробел: ");
    return Console.ReadLine().Split(" ");
}
