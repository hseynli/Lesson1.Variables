// QAYDA:
// byte, sbyte, short, ushort tipləri üzərində edilən bütün arifmetik əməliyyatlar nəticə olaraq int qaytarır.

// byte tipində dəyişənin yaradılması.
byte variable1 = 0;

//variable1 = variable1 + 5;       // XƏTA: geriya qayıdan int tipinin byte tipinə mənimətmək istəyi.
//variable1 = (byte)variable1 + 5; // XƏTA: byte tipinin toplama əməliyyatından əvvəl byte tipinə çevrilməsi baş verir.

variable1 = (byte)(variable1 + 5); // Mürəkkəb həl.

variable1 += 5;                    // Eleqant həll.           

//variable1 += 5000;               // XƏTA.  Çünki mənimsədilən ədəd diapazonu keçir

#region Qısaldılmış mənimsətmə operatorları

// Qısaldılmış toplama operatoru.
int variable2 = 0;
variable2 = variable2 + 5;
variable2 += 5;

// Qısaldılmış çıxma operatoru.
uint variable3 = 0;
variable3 = variable3 - 5;
variable3 -= 5;

// Qısaldılmış vurma operatoru.
long variable4 = 0;
variable4 = variable4 * 5;
variable4 *= 5;

// Qısaldılmış bölmə operatoru.
ulong variable5 = 0;
variable5 = variable5 / 5;
variable5 /= 5;

// Qısaldılmış bölmədən alınan qalıq operatoru.
long variable6 = 0;
variable6 = variable6 % 5;
variable6 %= 5;

#endregion