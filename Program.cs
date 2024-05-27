using System;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Globalization;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
          //initializes a string array of five numbers
          //.Length() to calculate the length of the array
            int [] numbers = new int[5];
            numbers[0] = 23;
            numbers[1] = 24;
            numbers[2] = 40;
            numbers[3] = 59;
            numbers[4] = 60;
            Console.WriteLine(numbers.Length);
            Console.WriteLine(numbers[4].ToString());
            Console.ReadLine();

            //declare an empty string array called names
            //stores the string names 
            //uses foreach to execute every name

            string[] names = new string[] {"Diana", "Njoki", "Leah", "Tom", "Lucy"};
            foreach (string name in names)
            {
                Console.WriteLine(name);
                
            }
            Console.ReadLine();

           // This block of code create a string with the name zig
           //then creates and empty char called charArray and converts the string zig to char
           // then reverse the string using .Reverse();
           //executes the char in a reverse order using foreach statement

            string zig = "Thank you for your prompt attention to this matter" + "  I look forward to your guidance on how to proceed.";
            char[] charArray = zig.ToCharArray();
            Array.Reverse(charArray);

            foreach (char zigChar in charArray)
            
                Console.Write(zigChar);
              
            
            Console.ReadLine();


            Console.ReadLine();
            
        }
    }
}