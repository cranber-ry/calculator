var isValueInput = false;

while (!isValueInput)
{
    Console.WriteLine("Выбирите действие:" +
    "\n1. Сложение;" +
    "\n2. Вычитание;" +
    "\n3. Умножение;" +
    "\n4. Деление;" +
    "\nq. Выход");
    var str = Console.ReadLine();
    if (str.ToLower() == "q")
    {
        return;
    }

    decimal value1;
    decimal value2;
    decimal result;

    switch (str)
    {
        case "1":
            Console.WriteLine($"Вы выбрали {str}");
            value1 = ReadValid("Введите a: ");
            value2 = ReadValid("Введите b: ");
            result = value1 + value2;
            Console.WriteLine($"Результат умножения {value1} + {value2} равен {result}");
            break;
        case "2":
            Console.WriteLine($"Вы выбрали {str}");
            value1 = ReadValid("Введите a: ");
            value2 = ReadValid("Введите b: ");
            result = value1 - value2;
            Console.WriteLine($"Результат вычитания {value1} - {value2} равен {result}");
            break;
        case "3":
            Console.WriteLine($"Вы выбрали {str}");
            value1 = ReadValid("Введите a: ");
            value2 = ReadValid("Введите b: ");
            result = value1 * value2;
            Console.WriteLine($"Результат деления {value1} * {value2} равен {result}");
            break;
        case "4":
            Console.WriteLine($"Вы выбрали {str}");
            value1 = ReadValid("Введите a: ");
            value2 = ReadValid("Введите b: ");
            result = value1 / value2;

            Console.WriteLine($"Результат деления {value1} / {value2} равен {result}");
            break;
        case "5":
            Console.WriteLine($"Вы выбрали {str}"); break;
        default:
            Console.WriteLine("Ты ввёл невеное значение. Введи число!"); break;
    }
}


static decimal ReadValid(string prompt)
{
    decimal number = 0;
    var isValid = false;
    while (!isValid)
    {
        Console.WriteLine(prompt);
        var input = Console.ReadLine();
        if (decimal.TryParse(input, out number))
        {
            isValid = true;
            Console.WriteLine($"a = {number}");
        }
        else
        {
            Console.WriteLine("ОШИБКА ВВОДА!! Введите число");
        }
    }
    return number;
}