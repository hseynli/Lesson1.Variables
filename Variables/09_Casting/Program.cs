#region Təhlükəsiz çevrilmə:

// byte tipindən int tipinə təhlükəsiz çevrilmə. (daha az ölçükü tipi daha böyük ölçülü tipə çeviririk)
byte a = 10;     //                                      0000 1010  -  1 bayt
int b = 0;       //  0000 0000   0000 0000   0000 0000   0000 0000  -  4 bayt
b = a;           //  0000 0000   0000 0000   0000 0000   0000 1010  -  4 bayt              

Console.WriteLine(b);

// int tipindən float tipinə təhlükəsiz çevrilmə. (kəsr ədədli tipi tam ədədə çeviririk).
int c = 255;
float d = 0f;
d = c;

Console.WriteLine(d);

#endregion

#region Təhlükəli çevrilmə:

// int tipindən byte tipinə təhlükəli çevrilmə. 
// (Daha böyük ölçüdən daha az kiçik ölçüyə çevilmə düzgün nəticənin itirlməsinə gətirib çıxarır.      

int e = 256;     //  0000 0000   0000 0000   0000 0001   0000 0000  -  4 bayt
byte f = 0;      //                                      0000 0000  -  1 байт
f = (byte)e;     //                                      0000 0000  -  1 байт
                 // f = e;        //  XƏTA.

Console.WriteLine(f);

// float tipindən int tipinə təhlükəli çevrilmə. 
// (Kəsr tipli ədədləri tam tipli dəyişənlərə çevirəndə kəsr tipinin itirilməsinə gətirib çıxarır.

float g = 10.5F;
int h = 0;
h = (int)g;
// h = g;         // XƏTA.

Console.WriteLine(h);

#endregion
