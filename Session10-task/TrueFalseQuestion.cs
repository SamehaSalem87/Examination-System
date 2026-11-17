using System;
using System.Collections.Generic;
using System;


    namespace Session10_task
    {
        public class TrueFalseQuestion : Question
        {
            // Property
            public bool CorrectAnswer { get; set; }

            // Constructor
            public TrueFalseQuestion(
                string header,
                int marks,
                QuestionLevel level,
                bool correctAnswer)
                : base(header, marks, level)
            {
                CorrectAnswer = correctAnswer;
            }

            // Display Method
            public override void Display()
            {
                Console.WriteLine(Header);
                Console.WriteLine("1. True");
                Console.WriteLine("2. False");
            }

            // Check Answer Method
            public override bool CheckAnswer(string answer)
            {
                if (bool.TryParse(answer, out bool studentAnswer))
                {
                    return studentAnswer == CorrectAnswer;
                }

                return false;
            }
        }
    }
