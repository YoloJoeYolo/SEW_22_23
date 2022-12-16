Func<int, int, int> operation = new Func<int, int, int>(Addition);      // generische Func ersetzt "Rechenoperation"
int result = operation(4, 5);
Console.WriteLine("Result: " + result);

operation = Subtraction;    // kurze Schreibweise
result = operation(4, 5);
Console.WriteLine("Result: " + result);

Action<int> printer = PrintWithLeadingSpaces;   // generische Action ersetzt "Printer"
printer(77);
Console.WriteLine("--------------");
printer += PrintWithLeading0;
printer(88);
Console.WriteLine("--------------");
printer -= PrintWithLeadingSpaces;
printer(99);
printer -= PrintWithLeading0;
if (printer != null)
{
    printer(110);   // bei Aufruf eines delegates, immer sicherstellen, dass es nicht null ist
}

static int Addition(int x, int y)
{
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