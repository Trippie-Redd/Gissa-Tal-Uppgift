// Variablar
Random rnd = new Random();
int number = rnd.Next(1, 101);
int tries = 1;

// För första gissningen
Console.Write("Gissa ett heltal mellan 1 och 100: ");
int guess = Convert.ToInt32(Console.ReadLine());

// För resterande gissningar
while (guess != number) {
    tries++;
    if (guess > number) 
        Console.Write("För högt! Försök igen: ");
    else if (guess < number)
        Console.Write("För lågt! Försök igen: ");
    guess = Convert.ToInt32(Console.ReadLine());
}

// När spelaren har gissat rätt
Console.WriteLine("Rätt tal! Du klarade det på " + tries + " försök.");

/* 
Start

Slumpa fram ett heltal mellan 1 och 100 och spara det som "number"
Sätt variabeln 'tries' till 1

Skriv "Gissa ett heltal mellan 1 och 100: "
Läs in 'guess' från användaren

Medans'guess' inte är lika med 'number' gör
    Öka 'tries' med 1
    Om 'guess' är större än 'number' 
        Skriv "För högt! Försök igen: "
    Annars om 'guess' är mindre än 'number'
        Skriv "För lågt! Försök igen: "
    Läs in 'guess' från användaren
Avsluta loopen

Skriv "Rätt tal! Du klarade det på " + 'tries' + " försök."

Slut
*/