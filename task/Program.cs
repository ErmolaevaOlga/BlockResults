Console.Clear();
Console.WriteLine("Введите количество строк массива:");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива:");
int n = int.Parse(Console.ReadLine());
int[,] array = GetArray(m, n, 1, 9);
PrintArray(array);
Console.WriteLine();
int[] minElem = FindMin(array);

Console.WriteLine($"{String.Join(", ", minElem)}");
PrintArray(ChangeArray(array, minElem));

int[] FindMin(int[,] array)
{
    int[] massiv = new int[3];
    int min = 10;
    int minI = 0;
    int minJ = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           if ( array[i,j] < min)
           {
            min = array[i,j];
            minI = i;
            minJ = j;
           }
        }     
    }
    massiv[0] = min;
    massiv[1] = minI;
    massiv[2] = minJ;
    return massiv;
}



int[,] ChangeArray(int[,] array, int[] minEl)
{
    int[,] massiv = new int[array.GetLength(1)-1, array.GetLength(0)-1];    
    int index1 = -1;
    int index2 = -1; 
    for (int i = 0; i < array.GetLength(0); i++)
    {
        index1++;
        if (i == minEl[1])
        {
            index1 = i - 1;
            continue;
        }
        for (int j = 0; j < array.GetLength(1); j++)
        {
           index2++;
           if (j == minEl[2])
           {
            index2 = j - 1;
            continue;
           }
           massiv[index1,index2] = array[i,j];
           
        }  
           
    }
   return massiv;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}


int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int [m, n];
    for (int i = 0; i <m; i++)
    {
        for (int j = 0; j< n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}
