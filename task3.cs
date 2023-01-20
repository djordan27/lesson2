/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет */

int GetNumber() {
    return Convert.ToInt32(Console.ReadLine());
}

String holiday(int a) {
    if(a >= 1 && a <= 5) {
        return "нет";
    } else if(a >=6 && a <= 7) {
        return "да";
    } else {
        Console.WriteLine("ВВедите число от 1 до 7");
        holiday(GetNumber());
        return "false";
    }
}
int number = GetNumber();
Console.WriteLine($"{number} -> {holiday(number)}");