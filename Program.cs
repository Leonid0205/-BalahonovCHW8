// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы 
// каждой строки двумерного массива.

int[,] Create2dArray(int n, int m, int minValue, int maxValue)
{
    int[,] array = new int[n, m];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}
void Show2dArray(int[,] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
int[,] ArrangeMinToMax(int [,] array)
{
    int temp;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - j - 1; k++)
            {
                if (array[i, k] > array[i, k + 1])
                {
                temp = array[i, k];
                array[i, k] = array[i, k + 1];
                array[i, k + 1] = temp;
                }
            }
        }
    }
    return array;
}
Console.WriteLine();
Console.Write("Input number of strings: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input minimal value of an element: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max value of an element: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
int[,] array = Create2dArray(n, m, minValue, maxValue);
Show2dArray(array);
Console.WriteLine("The array with sorted strings is below!");
Show2dArray(ArrangeMinToMax(array));
Console.WriteLine();

// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.

int[,] Create2dArray2(int n2, int m2, int minValue2, int maxValue2)
{
    int[,] array = new int[n2, m2];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(minValue2, maxValue2);
        }
    }
    return array;
}
void Show2dArray2(int[,] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
void SumRowsMass(int[,] array, int n2, int m2)
{
    if (n2 == m2)
    {
        Console.WriteLine("The array you want to create is square!");
    }
    else
    {
        int rowSum = 9999999;
        int rowNumber = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            int sum = 0;
            for (int j = 0; j < array.GetLength(1); j++)
            {
                sum += array[i, j];
            }
            if(sum < rowSum)
            {
                rowSum = sum;
                rowNumber = i + 1;
            }   
        }
        Console.Write($"The number of string with minimal sum of elements is: {rowNumber}");
    }
}
Console.WriteLine();
Console.Write("Input number of strings: ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int m2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input minimal value of an element: ");
int minValue2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max value of an element: ");
int maxValue2 = Convert.ToInt32(Console.ReadLine());
int[,] array2 = Create2dArray2(n2, m2, minValue2, maxValue2);
Show2dArray2(array2);
SumRowsMass(array2, n2, m2);
Console.WriteLine();

// Задайте две матрицы. Напишите программу, которая будет находить
// произведение двух матриц.

int[,] Create2dArray3(int n2, int m2, int minValue2, int maxValue2)
{
    int[,] array = new int[n2, m2];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(minValue2, maxValue2);
        }
    }
    return array;
}
void Show2dArray3(int[,] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
int[,] ProductOfTwoArray(int[,] array1, int[,]array2)
{
    int[,] array = new int[array1.GetLength(0), array1.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            array[i, j] = array1[i, j] * array2[i, j];
        }
    }
    return array;
}
Console.WriteLine();
Console.Write("Input number of strings: ");
int n3 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int m3 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input minimal value of an element: ");
int minValue3 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max value of an element: ");
int maxValue3 = Convert.ToInt32(Console.ReadLine());
int[,] array31 = Create2dArray3(n3, m3, minValue3, maxValue3);
int[,] array32 = Create2dArray3(n3, m3, minValue3, maxValue3);
Show2dArray3(array31);
Show2dArray3(array32);
Console.WriteLine("The composition os two arrays is below!");
Show2dArray3(ProductOfTwoArray(array31, array32));

// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя 
// индексы каждого элемента.

// массив размером 2 x 2 x 2

// 12(0,0,0) 22(0,0,1)

// 45(1,0,0) 53(1,0,1)

int[] Create1dArray4(int d)
{
    int[] array = new int[d];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(10,100);
        for (int j = 0; j < i; j++)
        {
            while (array[i] == array[j])
            {
                array[i] = new Random().Next(10,100);
                j = 0;
            }
        }
    }
    return array;
}
int[,,] Create3dArray4(int[] array1d, int a, int b, int c)
{
    int[,,] array = new int[a, b, c];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (i == 0 && j == 0)   array[i, j, k] = array1d[k];
                if (i == 0 && j == 1)   array[i, j, k] = array1d[k + 2];
                if (i == 1 && j == 0)   array[i, j, k] = array1d[k + 4];
                if (i == 1 && j == 1)   array[i, j, k] = array1d[k + 6];
            }
        }
    }
    return array;
}
void Show3dArray4(int[,,] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
int[] array1d4 = Create1dArray4(8);
int[,,] array4 = Create3dArray4(array1d4, 2, 2, 2);
Console.WriteLine("The three dementional array is below!");
Show3dArray4(array4);