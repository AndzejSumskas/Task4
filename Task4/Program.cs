using System;
using System.Collections.Generic;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string textFromCsv = System.IO.File.ReadAllText(@"C:\Users\Andzej\Desktop\IT Tasks\HomeWork\Task2\test.csv");

            char[] separators = new char[] { ',', '\n' };

            string[] wordsArray = textFromCsv.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            List<Person> listPerson = new List<Person>();

            string name="", surname= "", phoneNumber = "";

            for (int i = 0; i < wordsArray.Length; i++)
            {
                if (i % 3 == 0)
                {
                    name = wordsArray[i];
                }
                if (i % 3 == 1)
                {
                    surname = wordsArray[i];
                }
                if (i % 3 == 2)
                {
                    phoneNumber = wordsArray[i];
                    listPerson.Add(new Person(name, surname, phoneNumber));
                }                
            }
        }
    }
}
