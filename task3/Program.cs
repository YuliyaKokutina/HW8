/* 60. Сформируйте трёхмерный массив . Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */
System.Console.WriteLine("Введите размер массива");
string stroka = Console.ReadLine();
string[] str = stroka.Split(", ");
int k = int.Parse(str[0]);
int n = int.Parse(str[1]);
int m = int.Parse(str[2]);

int[,,] CreateRandomMatrix(int k, int n, int m)
{
    Random rand = new Random();
    int[,,] array = new int[k, n, m];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        {
            for (m = 0; m < array.GetLength(2); m++)
                for (n = 0; n < array.GetLength(1); n++)
                {
                    array[i, n, m] = rand.Next(1, 100);
                }
        }
    }
    return array;
}
void PrintArray(int[,,] array)
{
    for (m = 0; m < array.GetLength(2); m++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (n = 0; n < array.GetLength(1); n++)
            {
                System.Console.Write($"{array[i, n, m]} {(i, n, m)} {"\t"}");
            }
            System.Console.WriteLine();
        }
        Console.WriteLine();
    }
}
int[,,] array = CreateRandomMatrix(k, n, m);
PrintArray(array);
