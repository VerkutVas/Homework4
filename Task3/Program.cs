// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

int size = 8;
int[] array = new int[size];



void FullArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1,100);
        Console.Write(array[i] + " ");
    }
}

void PrintArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " "); // через пробел
    }
    Console.WriteLine();
}
FullArray(array);
PrintArray(array);
