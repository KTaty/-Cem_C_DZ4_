// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран


int[] InputArray(int N)
{
    //Console.Write("Введите количество элементов: ");
    //int N = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[N];
    for (int i = 0; i < N; i++)
    {
        Console.Write($"Введите {i} элемент: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine($"{array[array.Length - 1]}]");
}

int[] array = new int[8];
array = InputArray(8);
PrintArray(array);