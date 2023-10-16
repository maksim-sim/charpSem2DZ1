Console.Write("Введите число день недели:");
string input = Console.ReadLine();

if (int.TryParse(input, out int number) && number > 0 && number < 8){
    if (number > 5) Console.WriteLine("Да");
    else Console.WriteLine("Нет");
}else Console.WriteLine("Ошибка! Введено некорректное число дня недели.");