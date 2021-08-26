using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            int minLength = 8;
            string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lowercase = "abcefghijklmnopqrstuvwxyz";
            string digits = "0123456789";
            string specialChars = "!#~@$%^&*()_+-?";
            Console.WriteLine("Enter your password:");
            string passWord = Console.ReadLine();
            //Score the entered password
            int score = 0;

            if (passWord.Length >= minLength)
            {
                score = score + 1;

            }
            if (Tools.Contains(passWord, uppercase))
            {
                score++;

            }
            if (Tools.Contains(passWord, lowercase))
            {
                score++;
                if (passWord == "password")
                {
                    score = 0;
                }
            }
            if (Tools.Contains(passWord, digits))
            {
                score++;
                if (passWord == "12345678")
                {
                    score = 0;
                }
            }
            if (Tools.Contains(passWord, specialChars))
            {
                score++;

            }
            Console.WriteLine($"Strength of password:{score}");
            switch (score)
            {
                case 5:
                case 4:
                    Console.WriteLine("password is extremely strong");
                    break;
                case 3:
                    Console.WriteLine("password is strong");
                    break;
                case 2:
                    Console.WriteLine("password is medium");
                    break;
                case 1:
                    Console.WriteLine("password is weak");
                    break;
                default:
                    Console.WriteLine("password doesn't meet any standards");
                    break;


            }
            Console.ReadLine();
        }
    }
}
