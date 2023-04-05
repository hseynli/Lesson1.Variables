sbyte a = 127;

//a++;

// Aralığı daşmanın yoxlanılması.
checked
{
    a++; // Kompilyator səviyyəsində xəta
}

// 127 + 1 = -128
Console.WriteLine(a);