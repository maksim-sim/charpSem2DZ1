Console.WriteLine("Введите трехзначное число:");
string input = Console.ReadLine();

int secondDigit = GetSecondDigit(input);

if (secondDigit != -1) Console.WriteLine("Вторая цифра числа: " + secondDigit);
else Console.WriteLine("Ошибка! Введено некорректное трехзначное число.");

static int GetSecondDigit(string input){
        if (input.Length == 3 && int.TryParse(input, out int number)) return (number / 10) % 10;
        else return -1;
}