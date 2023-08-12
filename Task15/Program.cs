// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
Console.WriteLine("Веддите цифру от одного до семи:");
int number = Convert.ToInt32(Console.ReadLine());
if(Examination_Error(number)){
int res = Examination_Weekend(number);
}

int Examination_Weekend(int num){
    if(num == 6 || num == 7){
    Console.WriteLine("Да");}
    else{
        Console.WriteLine("Нет");
    }
    return 0;
}
bool Examination_Error(int num){
    if(num > 7){
        Console.WriteLine("Ошибка ввода");
    return false;}
    return true;
}