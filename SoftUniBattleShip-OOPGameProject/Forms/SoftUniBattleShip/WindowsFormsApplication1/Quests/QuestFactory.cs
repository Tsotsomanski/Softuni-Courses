namespace WindowsFormsApplication1.Quests
{
    using System;
    using System.Collections.Generic;

    public class QuestFactory
    {
        private static readonly List<Quest> QuestionList = new List<Quest>
        {
            new Quest("C# namespace is different from Java package. Answer with: \"true\" or \"false\".", "false", QuestionType.Cs),
            new Quest("Checked exceptions are not present in C#. Answer with: \"true\" or \"false\".","true", QuestionType.Cs),
            new Quest("C# programmers must use the keyword \"virtual\" to allow methods to be overridden by subclasses. Answer with: \"true\" or \"false\"", "true", QuestionType.Cs),
            new Quest("Is lambda expressions included in C# 2.0. Answer with: \"true\" or \"false\".", "false", QuestionType.Cs),
            new Quest("C# is not suitable for writing applications for both hosted and embedded systems. Answer with: \"true\" or \"false\".", "false", QuestionType.Cs),
            new Quest("There are various ways to read input from the keyboad, the Console.ReadLine is one of them. Answer with: \"true\" or \"false\".", "false", QuestionType.Java),
            new Quest("Java is named by the Java coffee from Indonesian island. Answer with: \"true\" or \"false\".", "true", QuestionType.Java),
            new Quest("Java support \"Multiple inheritance\" for classes. Answer with: \"true\" or \"false\".", "true", QuestionType.Java),
            new Quest("Can you override private or static method in Java ? Answer with: \"true\" or \"false\".", "false", QuestionType.Java),
            new Quest("The elements in a TreeSet are sorted: Answer with: \"true\" or \"false\".", "true", QuestionType.Java),
            new Quest("Overriding is when you define two methods with the same name, in the same class, distinguished by their signatures. Answer with: \"true\" or \"false\".", "false", QuestionType.Oop),
            new Quest("Is Polymorphism part of the principles of Object oriented programing? Answer with: \"true\" or \"false\".", "true", QuestionType.Oop),
            new Quest("If the base class don't declares a method as virtual, the derived class is able to override the method with its own implementation? Answer with: \"true\" or \"false\".", "false", QuestionType.Oop ),
            new Quest("The interface is a reference type. Answer with: \"true\" or \"false\".", "true", QuestionType.Oop),
            new Quest("C++ is strongly typed language. Answer with: \"true\" or \"false\".", "false", QuestionType.Cpp),
            new Quest("Does C++ support exception handling? Answer with: \"true\" or \"false\".", "false", QuestionType.Cpp),
            new Quest("C++ programs can be run only with special IDE. Answer with: \"true\" or \"false\"", "false", QuestionType.Cpp),
        };

        /// <summary>
        /// This method generates a question depending on the category
        /// </summary>
        /// <returns>question</returns>
        public static Quest GenerateQuestOnCategory()
        {
            Quest question = null;

            switch (ChooseCategoryScreen.GetFinalCategory())
            {
                case "Csharp":
                    question = GenerateRandomQuest(QuestionType.Cs);
                    break;
                case "Java":
                    question = GenerateRandomQuest(QuestionType.Java);
                    break;
                case "OOP":
                    question = GenerateRandomQuest(QuestionType.Oop);
                    break;
                case "Cpp":
                    question = GenerateRandomQuest(QuestionType.Cpp);
                    break;
            }

                 return question;
        }
        
        /// <summary>
        /// This method generates a random question
        /// </summary>
        /// <param name="questionType">Type of the question</param>
        /// <returns>Random question</returns>
        private static  Quest GenerateRandomQuest(QuestionType questionType)
        {
            var questionListSize = QuestionList.Count;

            Random random = new Random();
            try
            {
                do
                {
                    var question = QuestionList[random.Next(1, questionListSize)];

                    if (question.Type == questionType)
                    {
                        return question;
                    }
                } while (true);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Error check code");
                return QuestionList[1];
            }
        }

        /// <summary>
        /// This method checks whether the answer is correct
        /// </summary>
        /// <param name="playerAnswer">Player answer</param>
        /// <param name="questionAnswer">Question answer</param>
        /// <returns>True if correct, false if not</returns>
        public static bool CheckAnswer(string playerAnswer, string questionAnswer)
        {
            return String.Compare(playerAnswer, questionAnswer, StringComparison.OrdinalIgnoreCase) == 0;
        }//method should be in Quest class??
    }
}
