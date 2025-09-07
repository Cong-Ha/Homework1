Console.WriteLine("Enter first number: ");
float firstnum =  float.Parse(Console.ReadLine());
Console.WriteLine("Enter second number: ");
float secondnum =  float.Parse(Console.ReadLine());
Console.WriteLine("1. Addition\n2. Subtraction\n3. Multiplication\n4. Division ");
Console.WriteLine("Enter your choice: ");
int choice = int.Parse(Console.ReadLine());

switch (choice)
{
    case 1: 
        var addResult = firstnum + secondnum;
        Console.WriteLine($"Addition result = {addResult}");
        break;
    case 2:
        var subResult = firstnum - secondnum;
        Console.WriteLine($"Subtraction result = {subResult}");
        break;
    case 3:
        var multipResult = firstnum * secondnum;
        Console.WriteLine($"Multiplication result = {multipResult}");
        break;
    case 4:
        var divisionResult = firstnum / secondnum;
        Console.WriteLine($"Division result = {divisionResult}");
        break;
    default:
        Console.WriteLine("Invalid choice.");
        break;
}