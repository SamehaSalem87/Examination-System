using System;
using System.Collections.Generic;
using System;


using System.Text;

namespace Session10_task
{

        public class ChooseOneQuestion : Question
        {
            // Properties
            public string[] Choices { get; set; }
            public int CorrectChoiceNumber { get; set; }

            // Constructor
            public ChooseOneQuestion(
                string header,
                int marks,
                QuestionLevel level,
                string[] choices,
                int correctChoiceNumber)
                : base(header, marks, level)
            {
                Choices = choices;
                CorrectChoiceNumber = correctChoiceNumber;
            }

            // Display Method
            public override void Display()
            {
                Console.WriteLine(Header);

                for (int i = 0; i < Choices.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {Choices[i]}");
                }
            }

            // CheckAnswer Method
            public override bool CheckAnswer(string answer)
            {
                if (int.TryParse(answer, out int studentAnswer))
                {
                    return studentAnswer == CorrectChoiceNumber;
                }

                return false;
            }
        }
    }
