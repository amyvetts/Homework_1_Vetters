using System;

class Homework_1_Vetters
{
    public static void Main(string[] args)
    {
        //get phrase
        System.Console.Write("Enter a phrase, no punctuation please. ");
        string phrase = System.Console.ReadLine();
        //1a
        processPhrase(phrase);
        //1b
        System.Console.WriteLine($"\"{phrase}\" is a palindrome: \"{isPalindrome(phrase)}\"");
        //1c
        System.Console.Write("Enter one letter from A - Z: ");
        char givenLetter = System.Console.ReadLine().ToUpper()[0];
        System.Console.Write("Enter a number between 0 and 25: ");
        int offset = int.Parse(System.Console.ReadLine());
        System.Console.WriteLine($"\"{givenLetter}\" is rotated by \"{offset}\" to produce \"{rotateChar(givenLetter, offset)}\"");
        //2
        System.Console.Write("Enter a word to encrypt: ");
        string encrypt = System.Console.ReadLine().ToUpper();
        System.Console.Write("Enter a number between 0 and 25: ");
        int num = int.Parse(System.Console.ReadLine());

        //I don't think I need this, but if a number wasn't entered the program crashes
        /*
         int num = 0;
        if (encryptionPostion == String.Empty)
        {
            return int num;
        } else
        {
           moveNum = int.Parse(num);
        }
        */
        System.Console.WriteLine($"\"{encrypt}\" has been rotated by \"{num}\" is: \"{ROTencrypt(encrypt, num)}\".");
        System.Console.WriteLine($"\"{encrypt}\" has been rotated by the default value of 13 is: \"{ROTencrypt(encrypt, num)}\".");




        static void processPhrase(string phrase)
        {
            System.Console.WriteLine($"This is the ORIGINAL phrase: \"{phrase}\"");
            System.Console.WriteLine($"This is the phrase in UPPERCASE: \"{ phrase.ToUpper()}\"");
            System.Console.WriteLine($"This is the phrase in LOWERCASE: \"{ phrase.ToLower()}\"");


        }
        
        static bool isPalindrome(string phrase)
        {
            string reverse = phrase.Replace(" ", "");
            reverse = reverse.ToLower();
            char[] chars = reverse.ToCharArray();
            System.Array.Reverse(chars);
            return new string(chars) == phrase.ToLower().Replace(" ", "");

        }
        
        static char rotateChar(char givenLetter, int offset)
        {
            
            return (char)((givenLetter - 'A' + offset) % 26 + 'A');

        }
        static string ROTencrypt(string phrase, int num=13)
        {
            string newEncryption = "";
           
            foreach(char ix in phrase)
            {
                newEncryption = newEncryption + rotateChar(ix, num);
            }
            return newEncryption;


        }
        
    }
}
