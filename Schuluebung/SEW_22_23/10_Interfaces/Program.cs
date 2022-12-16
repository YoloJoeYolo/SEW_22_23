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
    Console.WriteLine(drink.Degree);
    drink.cool();
    Console.WriteLine(drink.Degree);
}