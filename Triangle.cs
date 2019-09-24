using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Triangle triangle = new Triangle();
        Console.WriteLine("Enter side-1 dimensions: ");
        string stringSide1 = Console.ReadLine();
        int side1 = int.Parse(stringSide1);
        Console.WriteLine("Enter side-2 dimensions: ");
        string stringSide2 = Console.ReadLine();
        int side2 = int.Parse(stringSide2);
        Console.WriteLine("Enter side-3 dimensions: ");
        string stringSide3 = Console.ReadLine();
        int side3 = int.Parse(stringSide3);
        triangle.TriangleChecker(side1, side2, side3);
    }


class Triangle{
    // public double side1;
    // public double side2;
    // public double side3;

    public bool TriangleChecker(double side1, double side2, double side3){
        if(side1 == double.NaN || side2 == double.NaN || side3 ==  double.NaN)
        {
            Console.WriteLine("Please enter valid triangle dimensions");
                return false;
                Main();
        } 
        else if(side1 + side2 < side3 || side1 + side3 < side2 || side3 + side2 < side1)
        {
            Console.WriteLine("Please enter valid triangle dimensions, fool.");
                return false;
                Main();
        }  
        else if(side1 == side2 && side2 == side3){
            Console.WriteLine("This is an equalateral triangle");
            return true;
        }
        else if(side1 == side2 || side2 == side3 || side1 == side3)
        {
            Console.WriteLine("This is an isoceles triangle");
                return true;
            }
        else  
        {
            Console.WriteLine("This is a scalene triangle");
                return true;
            } 
    }   

}

}
