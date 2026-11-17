using System;
using System.Collections.Generic;
using System.Text;

namespace Session10_task
{

 

    
    
        public abstract class Question
        {
            // Properties
            public string Header { get; set; }
            public int Marks { get; set; }
            public QuestionLevel Level { get; set; }
        public QuestionLevel Level1 { get; }

        // Constructor
        protected Question(string header, int marks, QuestionLevel level)
            {
                Header = header;
                Marks = marks;
                Level = level;
            }

    

        // Abstract Methods
        public abstract void Display();

            public abstract bool CheckAnswer(string answer);
        }
    

}
