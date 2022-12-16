 using _06_Events;

Person jakob = new Person() { Name="Jakob Prem"};
Person florian = new Person() { Name = "Florian Winkler" };

Bar excalibur = new Bar() { Name = "Excalibur" };

jakob.enter(excalibur);
florian.enter(excalibur);

excalibur.SpendRound();

Person tobias = new Person() { Name = "Tobias Zarzer" };
tobias.enter(excalibur);

excalibur.SpendRound();

jakob.leave(excalibur);

excalibur.SpendRound();

ExtendedBar moon = new ExtendedBar() { Name = "Moon" };

jakob.enter(moon);
florian.enter(moon);
tobias.enter(moon);

moon.SpendNonAlcoholicDrink();
moon.SpendAlcoholicDrink();

