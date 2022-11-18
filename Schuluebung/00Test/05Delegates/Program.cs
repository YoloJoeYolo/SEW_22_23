
Rechnenoperation operation = new Rechnenoperation(Addition);    // lange Schreibweise
int result = operation(4, 5);
Console.WriteLine("Result: " + result);

operation = Subtraction;    // kurze Schreibweise
result = operation(4, 5);
Console.WriteLine("Result: " + result);

Printer printer = PrintWithLeadingSpaces;
printer(77);
Console.WriteLine("--------------");
printer += PrintWithLeading0;
printer(88);
Console.WriteLine("--------------");
printer -= PrintWithLeadingSpaces;
printer(99);
printer -= PrintWithLeading0;
if(printer != null)
{
    printer(110);   // bei Aufruf eines delegates, immer sicherstellen, dass es nicht null ist
}

static int Addition(int x, int y) {
    return x + y;
}

static int Subtraction(int x, int y)
{
    return x - y;
}

static void PrintWithLeadingSpaces(int x)
{
    Console.WriteLine("    " + x);
}

static void PrintWithLeading0(int x)
{
    Console.WriteLine("0000" + x);
}

public delegate int Rechnenoperation(int x, int y);     // Definition eines Datentyps
                                                        // mögliche Werte: alle Funktionen oder Methoden,
                                                        // welche int als Rückgabe haben und 2 int als Parameter

public delegate void Printer(int x);