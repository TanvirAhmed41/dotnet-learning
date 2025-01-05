using System;

class Test  
{
public static void Main (string[] args){

    /*string productName = "iphone Apple 14";
    double price = 320.5;
    string category = "smart phone";
    bool isAvailable = true;
    int sold = 5;

    Console.Write ("Name : ");
    Console.WriteLine (productName);
    Console.WriteLine (price);
    Console.WriteLine (category);
    Console.WriteLine (isAvailable);
    Console.WriteLine (sold);*/

    string? studentName;
    int age;

    Console.WriteLine ("Enter your name : ");
    studentName = Console.ReadLine ();

    Console.WriteLine ("Enter your age : ");
    age =Convert.ToInt32(Console.ReadLine());

    Console.WriteLine ("Welcome " + studentName);
    Console.WriteLine ("You're " + age + " year's old.");
         
}


}
