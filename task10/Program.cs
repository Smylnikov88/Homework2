//Задача 10: Напишите программу, которая принимает на вход 
//трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1


int number = new Random().Next(100,1000);
                                       
//int a3 = number / 100; 
//int a4 = number % 10; 
int a1 = number % 100/10;

Console.WriteLine(number);
Console.WriteLine(a1);
