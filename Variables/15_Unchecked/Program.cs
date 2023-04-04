sbyte a = 127;

// Проверять переполнение.
unchecked
{
    a++; // Логическая ошибка
}

// 127 + 1 = -128
Console.WriteLine(a);