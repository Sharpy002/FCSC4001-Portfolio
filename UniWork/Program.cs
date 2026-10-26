using System.Runtime.Intrinsics.X86;

Console.Write("What Is Your Name? :");
string name = Console.ReadLine(); 
Console.Write("What Is Your Weight? :");
double weight = double.Parse(Console.ReadLine()); 
Console.Write("What Is Your Height In Meters? :");
double height = double.Parse(Console.ReadLine()); 

double weight2 = height * height ;
double bmi = weight / weight2 ;

Console.WriteLine();
Console.WriteLine("Your BMI is :");
Console.WriteLine(bmi); 

if (bmi < 18.5)
{
    Console.WriteLine("You Are Underweight:");
}
else if (bmi >= 18.5 && bmi <= 24.9)
{
    Console.WriteLine("You Are Normal Weight:");
}
else if (bmi >= 25 && bmi <= 29.9)
{
    Console.WriteLine("You Are Overweight:");
}
else if (bmi >= 30 && bmi <= 34.9)
{
    Console.WriteLine("You Are Obese:");
}
else if (bmi >= 35)
{
    Console.WriteLine("You Are Extremely Obese:");
}