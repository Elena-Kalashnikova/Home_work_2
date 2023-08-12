// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
 if (number < 0){
    number *= -1;
 }

if (number >=100 && number <= 999){
    int second_digit = Second_digit(number);
    Console.Write($"Вторая цифра числа: {second_digit}");
}
else {
    Console.Write("Ошибка ввода");
}
int Second_digit(int digit){
    return digit  = number/ 10 % 10;
}