Console.Clear();
Console.WriteLine("Введите строки через запятую:");
string numbers = Console.ReadLine();

string[] massiv = GetArrayFromString(numbers);

string[] result = new string[CountElement(massiv)];
int j = 0;
for (int i = 0; i < massiv.GetLength(0); i++)
    {
        if (massiv[i].Length <= 3)
        {
            result[j] = massiv[i];
            j++;
        }
                
    }

Console.WriteLine($"[{String.Join(", ", result)}]");

// Перевод введенной строки в массив
string[] GetArrayFromString(string text)
{
    string[] result = text.Split( ',', StringSplitOptions.RemoveEmptyEntries);
    
    return result;
}

// Подсчет количества строк длиной <= 3
int CountElement (string[] array)
{
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (array[i].Length <= 3)
        {
            count++;
        }
                
    }
    return count;
}


