/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3


int max = 0;
int min = 0;

Console.Write("Укажите первое значение: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Укажите второе значение: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if(firstNumber > secondNumber)
{
    max = firstNumber;
    min = secondNumber;
}
else
{
    max = secondNumber;
    min = firstNumber;
}
Console.WriteLine("max = " + max + " и " + "min = " + min);



Задача 4. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22


Console.WriteLine("Введите первое значение");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе значение");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье значение");
int r = Convert.ToInt32(Console.ReadLine());
int max = a;

if (a>max) max=a;
if (b>max) max=b;
if (r>max) max=r;

Console.WriteLine(max);


Задача 6. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

if (number%2==0)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
*/

//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int first = 1;

while (first<number)
{
    Console.WriteLine(first+1);
    first +=2;

}

