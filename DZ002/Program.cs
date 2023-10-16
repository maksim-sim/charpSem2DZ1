Console.Write("Введите число: ");
int input = Convert.ToInt32(Console.ReadLine());

int thirdDigit = GetThirdDigit(input);

if (thirdDigit != -1) Console.WriteLine("Третья цифра числа: " + thirdDigit);
else Console.WriteLine("Ошибка! Введено некорректное число или третьей цифры нет.");

static int GetThirdDigit(int input){
    if (input > 99){
        while (input > 999) input /= 10;
        return input % 10;
    }
    return -1;
}
