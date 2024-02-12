//Задача 4: Напишите программу, которая на вход принимает натуральное число N,
// а на выходе показывает его цифры через запятую.

int Number = 11;
while (Number >= 1)
{
    int Digit = Number % 10;
    Console.Write (Digit + ",");
    Number = Number/10;
}