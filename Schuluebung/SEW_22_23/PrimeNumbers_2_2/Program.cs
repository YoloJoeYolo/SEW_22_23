using PrimeNumbers_2_2;

PrimeNumber primeNumber = new PrimeNumber();

primeNumber.PrimeNumberFound += prim => Console.WriteLine(prim.ToString() +" is a Pprime number!");

Console.WriteLine("Search for prime numbers between 0 and 100 started!");
Task t = primeNumber.GeneratePrimeNumbersAsync(0, 100);

t.Wait();
Console.WriteLine("Search for prime numbers between 0 and 100 finished!");