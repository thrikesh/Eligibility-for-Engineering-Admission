# Eligibility-for-Engineering-Admission
## Aim:
To write a C# program to check whether the student is eligibile for the engineering admission

## Algorithm:
## Step1:
Get the maths, chemistry and physics marks from the user using ReadLine().

## Step2:
Calculate the sum of all three subjects and check whether the sum is greater than and equal to 180.

## Step3:
Calculate the sum of physics and maths and check the condition.

## Step4:
Calculate the sum of all three subjects and maths-physics total.

## Step5:
Check for the given criteria for eligibility using if-else statements.

## Step6:
Display whether the person is eligible for admission or not based on the given criteria.

## Step7:
Exit the Program.

## Program:
NAME:THRIKESWAR P
REGISTER NO:212222230162

using System;
    class Eligibility
    {
        static void Main(string[] args)
        {
           int mpc,mp,maths, physics, chemistry;
        string name;
        Console.WriteLine("Enter mark in maths:");
        maths = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter mark in physics:");
        physics = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter mark in chemistry:");
        chemistry = int.Parse(Console.ReadLine());
        mpc=maths+physics+chemistry;
        mp=maths+physics;
        if(maths>=65&&physics>=55&&chemistry>=50)
        {
            if(mpc>=180||mp>=140)
            {
                Console.WriteLine("eligible for admission.");
            }
            else
            {
                Console.WriteLine("not eligible for admission.");
            }
        }
        else
        {
            Console.WriteLine("not eligible for admission.");
        }
    }
        }


## Output:
![308843896-8425ac22-fd15-4da6-8b55-51cfdfc13491](https://github.com/thrikesh/Eligibility-for-Engineering-Admission/assets/119576222/2c985ffa-e5ca-434e-94d0-af5eea6b48a3)



## Result:
Thus the above C# program to check the eligibility of engineering admission is successfully executed

