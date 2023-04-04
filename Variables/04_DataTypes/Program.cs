#region Tam ədədlər

// 8-bits == 1 byte. ----------------------------------------------------------------------------

// Diapazon -  0 - 255.
byte a = 0;
Byte b = 255;

// Diapazon -  -128 - +127.
sbyte c = -128;
SByte d = +127;


// 16-bits == 2 bytes. -------------------------------------------------------------------------

// Diapazon -  0 - 65535.
ushort e = 0;
UInt16 f = 65535;

// Diapazon -  -32768 - +32767.
short g = -32768;
Int16 h = +32767;


// 32-bits = 4 bytes. ---------------------------------------------------------------------------

// Diapazon -  0 - 4294967295.
uint i = 0u;
UInt32 j = 4294967295U;

// Diapazon -  -2147483648 - +2147483647.
int k = -2147483648;
Int32 l = +2147483647;


// 64-bits = 8 bytes. ---------------------------------------------------------------------------

// Diapazon -  0 - 18446744073709551615.
ulong m = 0ul;
UInt64 n = 18446744073709551615UL;

// Diapazon -  -9223372036854775808 - +9223372036854775807.
long o = -9223372036854775808L;
Int64 p = +9223372036854775807L;

#endregion

#region Kəsr tipli ədədlər

// 32-bits = 4 bytes. ---------------------------------------------------------------------------

// Diapazon -  +/-1.5 x 10^-45 - +/-3.4 x 10^38.
float q = -0.123456789f;  // f suffiksinin olması mütləqdir,
Single r = +1.123456789F; // çünki kompilyator bu ədədir double kimi görür


// 64-bits = 8 bytes. ---------------------------------------------------------------------------

// Diapazon -  +/-5.0 x 10^-324 - +/-1.7 x 10^308.
double s = -0.123456789d;
Double t = +1.123456789;

// 128-bits = 16 bytes. -----------------------------------------------------------------------

// #endregion -   +/-1.0 x 10^-28 - +/-7.9 x 10^28.
decimal u = -0.12345m;   // f suffiksinin olması mütləqdir, 
Decimal v = +1.1234567M; // çünki kompilyator bu ədədir double kimi görür

#endregion

#region Məntiq tipi

// 8-bits == 1 byte. ----------------------------------------------------------------------------

// Məntiq tipi Doğru/Yalan.
bool w = true;
Boolean x = false;

#endregion

#region Simvol tipi

// 16-bits == 2 bytes. -------------------------------------------------------------------------

// UNICODE formatında simvol.
char y = 'a';
Char z = 'A';

#endregion

#region Sətir tipi

// UNICODE formatında sətr.
string firstString = "hello";
String secondString = "HELLO";

#endregion