int age;
string name;

Console.WriteLine("Enter your name: ");
string? nameInput = Console.ReadLine();
Console.WriteLine("Enter your age: ");
string? ageInput = Console.ReadLine();

age = string.IsNullOrWhiteSpace(ageInput) ? 17 : int.Parse(ageInput);
name = string.IsNullOrEmpty(nameInput) ? "John Doe" : nameInput;

Console.WriteLine($"Hello, {name}!");

if (age >= 18)
{
    Console.WriteLine("You are eligible to vote.");
}
else
{
    Console.WriteLine("You are not eligible to vote.");
}


