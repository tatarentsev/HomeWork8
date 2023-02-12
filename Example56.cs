/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

int count = 0;
int[,] arr = new int[4, 4];

void CreateArray(int[,] array)
{
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			array[i, j] = new Random().Next(1, 10);
		}
	}
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j], 4}");
        }
        Console.WriteLine();
    }
}

int[] list = new int[4];
void NimimumSymbolsInString(int[,] array)
{
	for (int i = 0; i < array.GetLength(0); i++)
	{
        count = 0;
        for (int j = 0; j < array.GetLength(1); j++)
		{
            count += array[i, j];
        }
        list[i] = count;
    }
}

CreateArray(arr);
PrintArray(arr);
NimimumSymbolsInString(arr);

int min = list[0];
int index = 1;
for (int k = 1; k < list.Length; k++)
{
    if (list[k] < min)
    {
        min = list[k];
        index = k+1;
    }
}
Console.WriteLine();
Console.WriteLine($"{index} строка с наименьшим количество элементов");
Console.ReadLine();