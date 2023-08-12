// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

bool res_ex = Examination(number);
if (res_ex == true)
{

   int result = ThirdDigit(number);

Console.WriteLine($"Третье число = {result}");
}
int ThirdDigit(int num)
{
   while (num > 999)
   {
      num /= 10;
   }
   return num % 10;
}

bool Examination(int num)
{
   if (num < 100)
   {
      Console.WriteLine("Третьего числа нет");
      return false;
   }
   return true;

}
