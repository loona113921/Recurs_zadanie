// Задача 1: Задайте значения M и N. Напишите программу, которая выведет 
//все натуральные числа в промежутке от M до N.
// Использовать рекурсию, не использовать циклы.


void Main()

{
 int M = ReadInt("Введите первое число M: ");
 int N = ReadInt("Введите второе число N: ");
 PrintNumbers(M, N);

}

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintNumbers(int number, int N)

{

if (number <= N)

Console.Write(number + " ");
PrintNumbers(number + 1, N);
}

Main();