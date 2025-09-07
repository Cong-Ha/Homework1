const double pi = 3.14159;
int radius = 5;

double GetArea(double pi, int radius)
{
    double result = pi * radius * radius;
    return result;
}

Console.WriteLine($"the area of a circle with radius 5 is {GetArea(pi, radius)}.");