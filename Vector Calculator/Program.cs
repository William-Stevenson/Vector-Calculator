using System;

namespace Vector_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector test1 = new Vector(1, 2, 3);
            Vector test2 = new Vector(-1, 2, -3);
            Vector negateTest = new Vector(1, -2, 3);
            Vector scaleTest = new Vector(2, -2, 3);
            Vector getMagnitudeTest = new Vector(3, 4, 0);
            Vector getDirectionTest = new Vector(1, 1, 0);
            Vector normalizeTest = new Vector(3, 4, 0);
            Vector dotProductTest1 = new Vector(3, 4, 0);
            Vector dotProductTest2 = new Vector(3, 4, 0);
            Vector angleBetweenTest1 = new Vector(4, 5, 9);
            Vector angleBetweenTest2 = new Vector(8, 2, 1);
            Vector crossProductTest1 = new Vector(2, 3, 4);
            Vector crossProductTest2 = new Vector(4, 5, 6);
            Vector projectionTest1 = new Vector(4, 8, 0);
            Vector projectionTest2 = new Vector(10, 3, 0);

            // This should be 0, 4, 0
            Console.WriteLine(Vector.Add(test1, test2));
            // Oughta be -1, 2, -3
            Console.WriteLine(Vector.Negate(negateTest));
            // Oughta be 4, -4, 6
            Console.WriteLine(Vector.Scale(scaleTest, 2));
            // Oughta be 2, 0, 6
            Console.WriteLine(Vector.Subtract(test1, test2));
            // Oughta be 5
            Console.WriteLine(getMagnitudeTest.GetMagnitude());
            // Oughta be 45 in degrees
            Console.WriteLine(getDirectionTest.GetDirection());
            // Oughta be .6, .8, 0
            Console.WriteLine(Vector.Normalize(normalizeTest));
            // Oughta be 25
            Console.WriteLine(Vector.DotProduct(dotProductTest1, dotProductTest2));
            // Oughta be ~56 in degrees
            Console.WriteLine(Vector.AngleBetween(angleBetweenTest1, angleBetweenTest2));
            // Oughta be -2, 4, -2
            Console.WriteLine(Vector.CrossProduct(crossProductTest1, crossProductTest2));
            // Oughta be 5.9, 1.76, 0
            Console.WriteLine(Vector.ProjectOnto(projectionTest1, projectionTest2));

            Console.WriteLine("It is done. Praise the all mighty CPU.");
        }
    }
}
