//Задача 13: Напишите программу, которая выводит третью цифру 
//заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.WriteLine("Ввести первое число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number <= 99)
{
    Console.WriteLine("Третьей цифры нет");
}
if(number >= 100 && number <1000)
{
  int number2= number% 10; 
  Console.WriteLine(number2);  
}
if(number >= 1000 && number <10000)
{
  int number3= number% 100/10; 
  Console.WriteLine(number3);  
}
if(number >= 10000 && number <100000)
{
  int number4= number% 1000/100; 
  Console.WriteLine(number4);  
}