using Bsp2;

PrimeNumber primeNumber = new PrimeNumber();

primeNumber.PrimeFactorFound += (number) => Console.WriteLine("Es wurde eine Primfaktor gefunden: " +number);

primeNumber.GeneratePrimeFactorsAsync(275);