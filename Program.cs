// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class eligiblity
{
    public static void Main(string[] args)
    {
      int maths,physics,chemistry,totalmark,sum;
        Console.WriteLine("enter the physics mark");
        physics=int.Parse(Console.ReadLine());
        Console.WriteLine("enter the maths mark");
        maths=int.Parse(Console.ReadLine());
        Console.WriteLine("enter the chemistry mark");
        chemistry=int.Parse(Console.ReadLine());
        totalmark=maths+physics+chemistry;
        sum=maths+physics;
        if(chemistry>=50 && maths>=65 && physics>=55)
        {
            if(totalmark>=180 || sum>=140)
            {
                Console.WriteLine("the candidate is eligible for admission.");
            }
            else
            {
                Console.WriteLine("the candidate is not eligible for admission.");
            }
        }
    }
}
