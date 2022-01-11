<<--!-->>
Exception Filter.cs

using System;
class Program
{
 static void Main(string[] args)
 {
 Console.Write("Please enter a number to divide 100: ");
 
 try
 {
 int num = int.Parse(Console.ReadLine());
 int result = 100 / num;
 Console.WriteLine("100 / {0} = {1}", num, result);
 }
 catch(DivideByZeroException ex)
 {
 Console.Write("Cannot divide by zero. Please try again.");
 }
 catch(InvalidOperationException ex)
 {
 Console.Write("Invalid operation. Please try again.");
 }
 catch(FormatException ex)
 {
 Console.Write("Not a valid format. Please try again.");
 }
 catch(Exception ex)
 {
 Console.Write("Error occurred! Please try again.");
 }
 }
}

<<--!-->>
program cs

using System; 
 using System.Collections.Generic; 
 using System.Linq; 
  using System.Text; 
 using System.Text.RegularExpressions; 
 
 namespace RegularExpression1 
 { 
 class Program 
 { 
 static void Main(string[] args) 
 { 
  Regex r = new Regex(@"^\+?\d{0,2}\-?\d{4,5}\-?\d{5,6}"); 
 //class Regex Repesents an immutable regular expression. 

 string[] str = { "+91-9678967101", "9678967101", "+91-9678-967101", "+91-96789-67101", "+919678967101"}; 
 //Input strings for Match valid mobile number.
foreach(string s in str) 
 { 
 Console.WriteLine("{0} {1} a valid mobile number.", s, 
 r.IsMatch(s) ? "is":"is not"); 
 //The IsMatch method is used to validate a string or 
//to ensure that a string conforms to a particular pattern. 
 } 
} 
 } 
}


<<--!-->>
Finallyblock.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.IO;

class program
{
static void Main(string[] args)
{
    FileInfo file = null;
    try
    {
        Console.Write("Enter a file name to write: ");
        string fileName = Console.ReadLine();
        file = new FileInfo(fileName);
        File.AppendText("Hello World!");
    }
    
    catch (Exception ex)
    {
        Console.WriteLine("Error occurred: {0}", ex.Message);
    }
    finally
    {
     
        file = null;
    }
}
}