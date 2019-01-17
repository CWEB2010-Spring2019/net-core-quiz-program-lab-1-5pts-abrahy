using System;

//abrahy

namespace Quiz {
    class Program
    {
        static void Main(string[] args)
        {
            //declaring an array that holds correctAnswers
            string[] correctAnswers = { "B", "B", "C", "A", "D", "A", "A", "C", "D", "A" };

            //declaring an array that holds the question
            string[] quizQuestions = new string[] { "When was .NET core released?", "What is the current version of .NET core?", "How much does it cost to use .NET Core", "Which operating system is NOT supported by .NET Core?", "What company rolled out .NET Core?", " When was .NET Core 2.1 released", " What else was released on May 30, 2018?", "What is the name of there main website?", "Who has the liscense for .NET core?", "Who developed .NET Core?" };

            //declaring a multi-dimensional array that holds options for each questions
            string[,] quizQuestionsOptions = new string[,]{
                    {"A) 2019", "B) 2014", "C) 2003", "D) 1990"},
                    {"A) 1.0", "B) 2.2", "C) 10.0 ", "D)3.0"},
                    {"A)$10.00 ", "B)$15.00 ", "C)Free ", "D)$20.00"},
                    {"A)Pharo ", "B) Windows", "C)Linux ", "D)mac OS"},
                    {"A)Best Buy ", "B)Google ", "C)Apple ", "D)Microsoft"},
                    {"A)May 30, 2018 ", "B) June 3, 2017", "C)November 2, 1984 ", "D)September 29, 1987"},
                    {"A) Visual Studio Code", "B)Myspace ", "C)Facebook ", "D)Twitter"},
                    {"A)darnell.github.io ", "B) digit.github.io", "C)	dotnet.github.io ", "D)donut.github.io"},
                    {"A)DREW liscense ", "B)BILLY liscense ", "C)BLUE liscense ", "D)MIT License"},
                    {"A).NET Foundation ", "B)Google ", "C)Apple ", "D)Facebook"},

                    };
            

            int EXIT = 1; //sentinal value 
            string  selection;
            int correct = 0;
            greetings();

            while (EXIT != -1) 
            {
                for (int x = 0; x < quizQuestions.Length; x++)
                {
                    Console.WriteLine(quizQuestions[x]);

                    for (int i = 0; i < 4; i++)
                    {
                        Console.WriteLine(quizQuestionsOptions[x, i]);
                    }
                    

                    selection = Console.ReadLine();

                    if (selection == correctAnswers[x])
                    {
                        correct++;
                    }

                    if (correct >= 6)
                    {
                        Console.WriteLine("YOU PASSED");
                    }
                    else 
                    {
                        Console.WriteLine("YOU FAILED");
                    }
                }
            }

        }
        public static void greetings()
        {
            Console.WriteLine("Welcome to the program");
            Console.WriteLine("Press enter to begin");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
        }
    }

}//end of main method


