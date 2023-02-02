// Задача №1. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int CutNumber (int number)
  { int dec = number%100;
    int result = dec/10;
    return result;
  }
int num = new Random().Next(100,1000);
int newNum = CutNumber(num);
Console.WriteLine($"new version of {num} is {newNum}");
*/
//============================================================================
//Задача №2. Напишите программу, которая выводит третью цифру заданного числа.
/*
int CutNumber (int number)
{
     int result = - 1;
     if (number >= 100)
     {
        while (number > 999)
        {
          number = number / 10;
        }
        result =number % 10;
     }
     return result; 
}   
Console.Write("Input a two-digit number: ");
int num = Convert.ToInt32(Console.ReadLine());
//int num = new Random().Next();
int newNum = CutNumber(num);
Console.WriteLine($"new version of {num} is {newNum}");
*/
//======================================================================================================================================
// Задача №3. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*
bool DayOff (int numberDay)
{
  bool result = false;
  if (numberDay==6 || numberDay==7)
      {
          result = true;
      }
  return result;
}
Console.WriteLine( "Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(DayOff(number));
*/
  