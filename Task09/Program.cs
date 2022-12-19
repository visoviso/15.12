int number = new Random().Next(10, 100);
Console.WriteLine($"случайное число из отрезка 10-99 => {number}");

int firstDigit = number / 10;
int secondDigit = number % 10;

// if (firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа => {firstDigit}");
// else Console.WriteLine($"Наибольшая цифра числа => {secondDigit}");




// int result = firstDigit > secondDigit ? firstDigit : secondDigit;
// Console.Write($"Наибольшая цифра числа => {result}");

int maxDigit = MaxDigit(number);
Console.Write($"Наибольшая цифра числа => {maxDigit}");

int maxDigit1 = MaxDigit(45);
Console.Write($"Наибольшая цифра числа => {maxDigit1}");

int maxDigit2 = MaxDigit(78);
Console.Write($"Наибольшая цифра числа => {maxDigit1}");

int MaxDigit(int number)
{
    int firstDigit = number / 10;
    int secondDigit = number % 10;
    int result = firstDigit > secondDigit ? firstDigit : secondDigit;
    return result;
}
