using MutatedVowel_1_2;

ConsoleInput consoleInput = new ConsoleInput();
consoleInput.MutatedVowelInput += informAboutVowel;

while (true)
{
    consoleInput.ReadInput("Bitte Text eingeben: ");
}

static void informAboutVowel(object? sender, MutatedVowelEventArgs e)
{
    Console.WriteLine("Es wurde der Umlaut: " + e.MutatedVowel + " eingegeben.");
}