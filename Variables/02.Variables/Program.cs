//Dəyişənlərin yaradılması və onlara dəyərin mənimsədilməsi
int number;
number = 45;
Console.WriteLine(number);
Console.WriteLine(new string('-', 120));

//Dəyişəni bir dəfə təyin etdikdən sonra ona sonradan istənilən qədər başqa dəyəri mənimsətmək mümkündür
number = 120;
Console.WriteLine(number);
Console.WriteLine(new string('-', 120));
//Nəticədə dəyişənə sonuncu mənimsədilən dəyər götürüləcəkdir
number = 10;
number = 20;
Console.WriteLine(number);

//İlkin dəyərə mənimsədilməyən dəyişəni ekrana çıxarmaq mümkün detil. XƏTA verəcəkdir.
byte x;
//Console.WriteLine(x); //Use of unassigned local variable 'x'
