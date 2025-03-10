Console.WriteLine("Zadanie pierwsze APBD.");
Powitanie(); 

Console.Write("Podaj swoje imię: ");
string imie = Console.ReadLine();
Console.WriteLine($"Witaj, {imie}!");

static void Powitanie() {
    Console.WriteLine("Cześć, użytkowniku!");
}
