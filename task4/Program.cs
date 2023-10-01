/* 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
1 2 3 4
12 13 14 5
11 16 15 6
10 9 8 7 */

System.Console.WriteLine("Введите размер массива");
string stroka = Console.ReadLine();
string[] str = stroka.Split(", ");
int n = int.Parse(str[0]);
int m = int.Parse(str[1]);
int plus = int.Parse(str[2]);

int[,] CreateRandomMatrix(int n, int m)
{
    int[,] array = new int[n, m];
    int width = array.GetLength(0);
    int size = array.GetLength(1);
    int count = 0;
    array[0, 0] = 1;
    for (int c = 0; c < 2; c++)
    {
        for (m = count; m < size - 1; m++)
        {
            array[count, m + 1] = array[count, m] + plus;
        }
        for (n = count; n < width - 1; n++)
        {
            array[n + 1, size - 1] = array[n, size - 1] + plus;
        }
        for (int i = count; i < size - 1; size = size - 1)
        {
            array[n, size - 2] = array[n, size - 1] + plus;
        }
        for (int j = count; j < width - 2; width--)
        {
            array[width - 2, count] = array[width - 1, count] + plus;
        }
        count = count + 1;
        size = size - 1;
        width = width - 1;
        array[count, count] = array[count, count - 1] + plus;
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int n = 0; n < array.GetLength(0); n++)
    {
        for (int m = 0; m < array.GetLength(1); m++)
        {
            System.Console.Write(array[n, m] + "\t");
        }
        System.Console.WriteLine();
    }
}
int[,] array = CreateRandomMatrix(n, m);
PrintArray(array);
