// вводит слуайное трехзначное число и удаляет вторую цифру этого числа 456-46, 782-72

int number = new Random().Next(100, 100);
Console.WriteLine($"случайное число из отрезка 100-999 => {number}");

// int firstDigit = number / 100;
// int secondDigit = number % 10;
// int result = firstDigit * 10 + secondDigit;

int maxDigit2 = RemovesecondDigit(number);
Console.Write($"два числа, которые будут показаны => {maxDigit2}");

int RemovesecondDigit(int number)
{
    int firstDigit = number / 100;
    int secondDigit = number % 10;
    int result = firstDigit * 10 + secondDigit;
    return result;
}


// int maxDigit = MaxDigit(number);
// Console.Write($"Наибольшая цифра числа => {maxDigit}");

// int maxDigit1 = MaxDigit(45);
// Console.Write($"Наибольшая цифра числа => {maxDigit1}");

// int maxDigit2 = MaxDigit(78);
// Console.Write($"Наибольшая цифра числа => {maxDigit1}");

// int MaxDigit(int number)
// {
//     int firstDigit = number / 10;
//     int secondDigit = number / 10;
//     int thirddDigit = number % 10;
//         int result = firstDigit > secondDigit ? firstDigit : secondDigit;
//     return result;
// }
