Console.Write("Bitte eine ganze Zahl eingeben: ");
string input = Console.ReadLine();

//int inputValue = int.Parse(input); möglicherweise Fehler wenn etwas anderes als ganze Zahl eingeben wird.

int number;
bool success = int.TryParse(input, out number);
if (success)
{
    Console.WriteLine("Super, do hast: " + number + " eingegeben!");
}
else
{
    Console.WriteLine("Leider keine Zahl!");
    // Eingabe wiederholen --> vermutlich in einer Schleife
    // ...
}

// double.TryParse(...)
// bool.TryParse(...)