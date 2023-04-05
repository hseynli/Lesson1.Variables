sbyte a = 127;

// Aralığı daşmanın yoxlanılması.
unchecked
{
    a++; // Məntiqi xəta. Aralıqdan qırağa çıxır
}

// 127 + 1 = -128
Console.WriteLine(a);

Console.WriteLine(new string('-', 120));
//const int E_FAIL = int.MaxValue + 1; //XƏTA mənimsədilən ədəd int tipinin aralığına yerləşmir

const int E_FAIL = unchecked(int.MaxValue + 1);
Console.WriteLine(E_FAIL);