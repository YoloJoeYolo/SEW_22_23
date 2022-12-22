using _10_Interfaces;

Coffee espresso = new Coffee("Espresso");
IHotDrink capuccino = new Coffee("Capuccino");
HotSpicedWine wine = new HotSpicedWine();


List<IHotDrink> drinks = new List<IHotDrink>();
drinks.Add(espresso);
drinks.Add(capuccino);
drinks.Add(wine);

foreach(IHotDrink drink in drinks)
{
    Console.WriteLine("Degree: " + drink.Degree);
    drink.cool();
    Console.WriteLine("Degree: " + drink.Degree);
}

List<IHasCaffeine> caffeineDrinks = new List<IHasCaffeine>();
caffeineDrinks.Add(espresso);
// caffeineDrinks.Add(capuccino)    // kann nicht hinzugefügt werden, weil statischer Datentyp: IHotDrink
Coke cola = new Coke();
caffeineDrinks.Add(cola);

foreach(IHasCaffeine drink in caffeineDrinks)
{
    Console.WriteLine("Caffeine: " + drink.Caffeine);
}