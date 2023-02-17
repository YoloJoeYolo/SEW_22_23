using Bsp2;

PrimeNumber primeNumber = new PrimeNumber();

primeNumber.PrimeFactorFound += (number) => Console.WriteLine("Es wurde eine Primzahl gefunden: " +number);

primeNumber.GeneratePrimeFactorsAsync(275);