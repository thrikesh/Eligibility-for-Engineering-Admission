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

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter marks obtained in Maths:");
        int mathsMarks = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter marks obtained in Physics:");
        int physicsMarks = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter marks obtained in Chemistry:");
        int chemistryMarks = Convert.ToInt32(Console.ReadLine());

        int totalMarks = mathsMarks + physicsMarks + chemistryMarks;

        if (mathsMarks >= 65 && physicsMarks >= 55 && chemistryMarks >= 50 && (totalMarks >= 180 || (mathsMarks + physicsMarks) >= 140))
        {
            Console.WriteLine("Congratulations! You are eligible for admission to the engineering course.");
        }
        else
        {
            Console.WriteLine("You are not eligible for admission to the engineering course.");
        }
    }
}

## Output:
![308843896-8425ac22-fd15-4da6-8b55-51cfdfc13491](https://github.com/thrikesh/Eligibility-for-Engineering-Admission/assets/119576222/2c985ffa-e5ca-434e-94d0-af5eea6b48a3)



## Result:
Thus the above C# program to check the eligibility of engineering admission is successfully executed

