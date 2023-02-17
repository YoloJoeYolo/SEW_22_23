using Bsp1;

List<IArticle> articles = new List<IArticle>();

articles.Add(new Book(14.99, "A nice C# book"));
articles.Add(new Smartphone(999.99, "IPhone 1"));
articles.Add(new Book(20, "C# for pros"));
articles.Add(new Smartphone(1499.99, "S22"));

double sum = 0;

articles.ForEach(item => sum += item.Price);

Console.WriteLine("Die Summe beträgt: " + sum);