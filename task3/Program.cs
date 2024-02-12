//Напишите программу, которая принимает на вход целое число из отрезка [10, 99]
// и показывает наибольшую цифру числа.

int Number = 79;
int firstDigit = Number/10;
int secondDigit  = Number % 10;
if (firstDigit >= secondDigit)
{
    Console.WriteLine ($" наибольшая цифра числа {Number} это {firstDigit}");
}
else
{
    Console.WriteLine ($" наибольшая цифра числа {Number} это {secondDigit}");
}