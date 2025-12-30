using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based
{
    internal class EducationalQuiz
    {
        static void Main(string[] args)
        {
            EducationalQuiz obj = new EducationalQuiz();
            string[] correctAnswer = obj.Input();
            obj.Display(correctAnswer);

        }

        string[] Input()
        {
            //input method for taking the correct answers 
            string[] corrrectAnswer = new string[10];
            for(int i=0;i<corrrectAnswer.Length; i++)
            {
                corrrectAnswer[i] = Console.ReadLine();
            }
            return corrrectAnswer;
        }

        void Display(string[]corrcetAnswer)
        {
            while (true)
                //while true means that untill user exits it will run
            {
                Console.WriteLine("Welcome to the quiz");
                Console.WriteLine("1. Take the quiz.");
                Console.WriteLine("2. Know your score");
                Console.WriteLine("3. Feedback");
                Console.WriteLine("3. Exit");
                string[]userAnswer = new string[10];
                int score = 0;
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        // takeing the quiz
                        userAnswer = TakeQuiz();
                        break;
                    case 2:
                        // calculate the score and percentage and shows pass or fail
                        score = CalculateScore(userAnswer,corrcetAnswer);
                        int per = (score / 10)*100;
                        Console.WriteLine("you scored " + score + "/10");
                        Console.WriteLine("your percantage " + per + "%");
                        if (per < 33)
                        {
                            Console.WriteLine("fail");
                        }
                        else
                        {
                            Console.WriteLine("pass");
                        }
                            break;
                    case 3:
                        // gives feed back for each questions
                        Feedback(userAnswer,corrcetAnswer);
                        break;
                    case 4:
                        Console.WriteLine("exit");
                        break;
                    default:
                        Console.WriteLine("invalid choice");
                        break;
                }
                if (choice == 4)
                {
                    break;
                }
            }
        }

        string[] TakeQuiz()
        {
            string[] userAnswer = new string[10];

            //take the user answer as input and store it in stinrg array
            for (int i = 0; i < userAnswer.Length; i++)
            {
                Console.WriteLine("question" + i + 1);
                userAnswer[i] = Console.ReadLine();
            }
            return userAnswer;
        }

        int CalculateScore(string[] userAnswer, string[]correctAnswer)
        {
            int score = 0;
            // calculate the score by comparing the two string
            for(int i=0;i<userAnswer.Length; i++)
            {
                if (correctAnswer[i].Equals(userAnswer[i].Trim().ToLower()))
                {
                    score++;
                }
                
            }
            return score;
        }

        void Feedback(string[] userAnswer, string[] correctAnswer)
        {
            int score = 0;
            // gives feedback
            for (int i = 0; i < userAnswer.Length; i++)
            {
                if (correctAnswer[i].Equals(userAnswer[i].Trim().ToLower()))
                {
                    Console.WriteLine("your answer is correct. well done");
                }
                else
                {
                    Console.WriteLine("your answer was incorrect. try again next time");
                }

            }
            
        }
    }
}
