using System;
using System.Collections.Generic;
using System;


using System.Text;

namespace Session10_task
{

 
        public class MultipleChoiceQuestion : Question
        {
            // Properties
            public string[] Choices { get; set; }
            public int[] CorrectAnswers { get; set; }

            // Constructor
            public MultipleChoiceQuestion(
                string header,
                int marks,
                QuestionLevel level,
                string[] choices,
                int[] correctAnswers)
                : base(header, marks, level)
            {
                Choices = choices;
                CorrectAnswers = correctAnswers;
            }

            // Display Method
            public override void Display()
            {
                Console.WriteLine(Header);
                Console.WriteLine("Choose all correct answers:");

                for (int i = 0; i < Choices.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {Choices[i]}");
                }
            }

            // CheckAnswer Method
            public override bool CheckAnswer(string answer)
            {
                string[] parts = answer.Split(',');

                int[] studentAnswers = new int[parts.Length];

                for (int i = 0; i < parts.Length; i++)
                {
                    if (!int.TryParse(parts[i].Trim(), out studentAnswers[i]))
                    {
                        return false;
                    }
                }

                int[] correctAnswers = (int[])CorrectAnswers.Clone();

                Array.Sort(studentAnswers);
                Array.Sort(correctAnswers);

                if (studentAnswers.Length != correctAnswers.Length)
                {
                    return false;
                }

                for (int i = 0; i < studentAnswers.Length; i++)
                {
                    if (studentAnswers[i] != correctAnswers[i])
                    {
                        return false;
                    }
                }

                return true;
            }
        }
    
}

