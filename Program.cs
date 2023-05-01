// Урок 7. Двумерные массивы
//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет




//Ввод чисел с экрана
int Promt(string message)
{
    Console.Write(message);
    string ReadInput = Console.ReadLine()!;
    int result = int.Parse(ReadInput);
    return result;
}

//Создание массива 
double[,] GenerateArray(int row1, int colmn1, int maxValue, int minValue)
{
    double[,] array = new double[row1, colmn1];
    Random random = new Random();
    for (int i = 0; i < row1; i++)
    {
        for (int j = 0; j < colmn1; j++)
        {
            array[i, j] = Math.Round(random.Next(minValue, maxValue) + random.NextDouble(), 1);
        }
    }
    return array;
}

// Метод вывода массива
void PrintArray(double[,] array)
{
    int length_0 = array.GetLength(0);
    int length_1 = array.GetLength(1);
    //Console.Write("[");
    for (int i = 0; i < length_0; i++)
    {
        for (int j = 0; j < length_1; j++)
        { Console.Write($"{array[i, j]}  "); };
        Console.WriteLine();
    }

    //Console.WriteLine("]");
}



Lable1:
int row = Promt("Введите количество строк  :");
int colmn = Promt("Введите количество столбцов  :");
int max = Promt("Введите максимальное значение для массива  :");
int min = Promt("Введите минимальное значение для массива  :");
if (min > max) { Console.WriteLine("Минимум не должен быть больше максимума"); goto Lable1; }
else { Console.WriteLine("Данные введены корректно"); }
double[,] array = GenerateArray(row, colmn, max, min);
PrintArray(array);

Lable2:
int rowSearch = Promt("Введите строку искомого элемента  :");
int colmnSearch = Promt("Введите столбец искомого  :");
if (rowSearch > row || colmnSearch > colmn) { Console.WriteLine("Такого элемента не существует"); }
else { Console.WriteLine(array[rowSearch - 1, colmnSearch - 1]); }
Console.Write("Если хотите повторить поиск ведите цифру 1 :");
int ret = int.Parse(Console.ReadLine()!);
if (ret == 1){goto Lable2;}
