using System;

namespace Deliverable2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "", message="";
            int checkSum= 0;

            Console.WriteLine("What is your message?");//prints "What is your message?" to console
            input = Console.ReadLine(); //takes user input
            input = input.ToUpper(); //Make letters all caps

            foreach (char c in input)//for every letter in the string input make c that letter and do the following
            {
                checkSum = checkSum + (int)c; // Add the unicode value of the letter in c to checksum
                message = message +((int)c - 64).ToString() + "-"; //Take the ascii value of the letter and subtract 64 and concatenate it to the message
            }
            Console.WriteLine("Your encoded message is {0}", message);
            Console.WriteLine("Message checksum is " + checkSum.ToString());           

        }
    }
}
