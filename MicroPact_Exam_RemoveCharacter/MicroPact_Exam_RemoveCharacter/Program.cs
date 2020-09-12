using System;

namespace MicroPact_Exam_RemoveCharacter
{
    class Program
    {
        public static string Temp { get; private set; }

        static void Main(string[] args)
        {
           
            string result = string.Empty;

            string inputString;
            char removeChar;

            Console.Write("Enter a string - ");
            inputString = Console.ReadLine();
                        
            Console.Write("Enter a Character to Remove - ");
           
            bool isValid;
            Char value;

            // Input is  String return false 
            string enteredChar = Console.ReadLine();
            isValid = Char.TryParse(enteredChar, out value);

            if (isValid)
            {
                removeChar = Convert.ToChar(enteredChar);
                 result = removeCharacterFromString(inputString, removeChar);
            }
            else
            {
                result = "Invalid Input. Only allows One(1) Character.";
            }
            
          
            Console.WriteLine("Result '{0}'", result);
        }


        public static string removeCharacterFromString(string input, char toRemove)
        {

            int j, count = 0, n = input.Length;
            string result = string.Empty;

            for (int i = j = 0; i < n; i++)
            {
                if (input[i] != toRemove)
                    result += input[i];
                else
                    count++;
            }

            while (count > 0)
                count--;

            return (result);

        }
    }
}
