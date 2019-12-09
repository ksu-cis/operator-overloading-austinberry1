using System;

namespace VectorMath
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fun with vectors");


            Vector3 one = new Vector3(5, 4, 3);
            Vector3 two = new Vector3(2,8,6);


            Console.WriteLine("Adding two Vectors:");
            Console.WriteLine($"With a static Method: {Vector3.Add(one, two)}");
            ///one.add(two);
            Console.WriteLine($"With a class method: {one}");


            Console.WriteLine($"With operator overloading: {one + two}");
            Console.WriteLine($"With operator overloading: {one - two}");
            Console.WriteLine($"With operator overloading: {10 * one}");
            Console.WriteLine($"With operator overloading: {one == two}");
            Console.WriteLine($"With operator overloading: {one == new Vector3(5,4,3)}");
            Console.WriteLine($"With operator overloading: {one != two}");

            if (one)
            {
                Console.WriteLine("Vector one is not zero");

            }
            else
            {
                Console.WriteLine("Vectore one is zero");
            }


        }
    }
}
