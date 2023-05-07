using System;
using ApiPool.Models.Quiz;

// https://www.worldathletics.org/world-rankings/overall-ranking/men
namespace ApiPool.Data.Seed
{
    public class QuizSeedData
    {
        public static List<QuizResult> GetQuizResults()
        {
            List<QuizResult> items = new List<QuizResult>()
            {
                new QuizResult() {
                    QuizResultId = 1,
                    WebAppId = Guid.NewGuid().ToString(),
                    DateOfQuiz = DateOnly.FromDateTime(DateTime.Now),
                    TimeOfQuiz = TimeOnly.FromDateTime(DateTime.Now),
                    NumberOfQuestionsInQuiz = 10,
                    Score = 8,
                    Name = "Tom Max",                
                },
                new QuizResult() {
                    QuizResultId = 2,
                    WebAppId = Guid.NewGuid().ToString(),
                    DateOfQuiz = DateOnly.FromDateTime(DateTime.Now),
                    TimeOfQuiz = TimeOnly.FromDateTime(DateTime.Now),
                    NumberOfQuestionsInQuiz = 10,
                    Score = 5,
                    Name = "Ann Fay",                
                },
                new QuizResult() {
                    QuizResultId = 3,
                    WebAppId = Guid.NewGuid().ToString(),
                    DateOfQuiz = DateOnly.FromDateTime(DateTime.Now),
                    TimeOfQuiz = TimeOnly.FromDateTime(DateTime.Now),
                    NumberOfQuestionsInQuiz = 10,
                    Score = 6,
                    Name = "Ken Sim",                
                },
                new QuizResult() {
                    QuizResultId = 4,
                    WebAppId = Guid.NewGuid().ToString(),
                    DateOfQuiz = DateOnly.FromDateTime(DateTime.Now),
                    TimeOfQuiz = TimeOnly.FromDateTime(DateTime.Now),
                    NumberOfQuestionsInQuiz = 10,
                    Score = 9,
                    Name = "Joe Sun",                
                },
                new QuizResult() {
                    QuizResultId = 5,
                    WebAppId = Guid.NewGuid().ToString(),
                    DateOfQuiz = DateOnly.FromDateTime(DateTime.Now),
                    TimeOfQuiz = TimeOnly.FromDateTime(DateTime.Now),
                    NumberOfQuestionsInQuiz = 10,
                    Score = 4,
                    Name = "Sue Fox",                
                },
                new QuizResult() {
                    QuizResultId = 6,
                    WebAppId = Guid.NewGuid().ToString(),
                    DateOfQuiz = DateOnly.FromDateTime(DateTime.Now),
                    TimeOfQuiz = TimeOnly.FromDateTime(DateTime.Now),
                    NumberOfQuestionsInQuiz = 10,
                    Score = 7,
                    Name = "Ben Ray",                
                },
                new QuizResult() {
                    QuizResultId = 7,
                    WebAppId = Guid.NewGuid().ToString(),
                    DateOfQuiz = DateOnly.FromDateTime(DateTime.Now),
                    TimeOfQuiz = TimeOnly.FromDateTime(DateTime.Now),
                    NumberOfQuestionsInQuiz = 10,
                    Score = 4,
                    Name = "Zoe Cox",                
                },
                new QuizResult() {
                    QuizResultId = 8,
                    WebAppId = Guid.NewGuid().ToString(),
                    DateOfQuiz = DateOnly.FromDateTime(DateTime.Now),
                    TimeOfQuiz = TimeOnly.FromDateTime(DateTime.Now),
                    NumberOfQuestionsInQuiz = 10,
                    Score = 10,
                    Name = "Sam Ray",                
                },
                new QuizResult() {
                    QuizResultId = 9,
                    WebAppId = Guid.NewGuid().ToString(),
                    DateOfQuiz = DateOnly.FromDateTime(DateTime.Now),
                    TimeOfQuiz = TimeOnly.FromDateTime(DateTime.Now),
                    NumberOfQuestionsInQuiz = 10,
                    Score = 8,
                    Name = "Dan Ash",                
                },
                new QuizResult() {
                    QuizResultId = 10,
                    WebAppId = Guid.NewGuid().ToString(),
                    DateOfQuiz = DateOnly.FromDateTime(DateTime.Now),
                    TimeOfQuiz = TimeOnly.FromDateTime(DateTime.Now),
                    NumberOfQuestionsInQuiz = 10,
                    Score = 6,
                    Name = "Pat Day",                
                },
            };

            return items;
        }
    }
}
