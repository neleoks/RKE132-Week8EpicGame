string folderPath = @"C:\Users\****\Documents\data\";
string heroFile = "heroes.txt";
string villainFile = "villains.txt";

string[] heroes = File.ReadAllLines(Path.Combine(folderPath, heroFile));
string[] villains = File.ReadAllLines(Path.Combine(folderPath, villainFile));

//string[] heroes = { "Harry Potter", "Elsa", "Rapunzel", "Anna" };
//string[] villains = { "Voldemort", "Cruella", "Dracula", "Joker", "Dexter" };


string[] weapon = { "magic wand", "plastic fork", "banana", "wooden sword", "Lego brick" };

//Random rnd = new Random(); - lisasin static koodi
//int randomIndex = rnd.Next(0, heros.Length);

//string hero = heros[randomIndex]; - all muudetud
string hero = GetRandomValueFromArray(heroes);
string heroWeapon = GetRandomValueFromArray(weapon);
Console.WriteLine($"Today {hero} with {heroWeapon} saves the day");



//randomIndex = rnd.Next(0, villains.Length); - alumises koodis

//string villain = villains[randomIndex]; muudetud kuju all
string villain = GetRandomValueFromArray(villains);
string villainWeapon = GetRandomValueFromArray(weapon);
Console.WriteLine($"Today {villain} with {villainWeapon} tries to take over the world!");

static string GetRandomValueFromArray(string[] someArray)
{
    Random rnd = new Random();
    int randomIndex = rnd.Next(0, someArray.Length);
    string randomStringFromArray = someArray[randomIndex];
    return randomStringFromArray;
}