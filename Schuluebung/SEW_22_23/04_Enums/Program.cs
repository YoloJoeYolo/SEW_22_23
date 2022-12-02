DayOfWeek startOfWeek = DayOfWeek.Monday;
Classes bestClassAtFJ = Classes.IT19;

Console.WriteLine("Besste Klasse des FJ: " + bestClassAtFJ);
Console.WriteLine("Besste Klasse des FJ: " + (int) bestClassAtFJ);
Console.WriteLine("Red: " + Color.Red);
Console.WriteLine("Red: " + (int) Color.Red);

// Enums müssen am Ende der Datei definiert werden
public enum Classes { IT19, IT20, IT21, IT22}

public enum Color { Red=16711680, Green=65280, Blue=255}   // Red: 2550000 #FF0000, Green: #00FF00