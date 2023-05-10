using System;
using ApiPool.Models.Quiz;
using ApiPool.Models.Utils;

namespace ApiPool.Data.Seed;

public class QuizSeedData
{
    public static List<QuizResult> GetQuizResults()
    {
        string[] guids = Helpers.GetQuizGuids();

        List<QuizResult> items = new List<QuizResult>()
            {
                new QuizResult() {
                    QuizResultId = 1,
                    WebAppId = guids[0],
                    Category = "General Knowledge",
                    DateOfQuiz = DateOnly.FromDateTime(DateTime.Now),
                    TimeOfQuiz = TimeOnly.FromDateTime(DateTime.Now),
                    NumberOfQuestionsInQuiz = 10,
                    Score = 8,
                    Name = "Tom Max",
                },
                new QuizResult() {
                    QuizResultId = 2,
                    WebAppId = guids[1],
                    Category = "Entertainment: Books",
                    DateOfQuiz = DateOnly.FromDateTime(DateTime.Now),
                    TimeOfQuiz = TimeOnly.FromDateTime(DateTime.Now),
                    NumberOfQuestionsInQuiz = 10,
                    Score = 5,
                    Name = "Ann Fay",
                },
                new QuizResult() {
                    QuizResultId = 3,
                    WebAppId = guids[2],
                    Category = "General Knowledge",
                    DateOfQuiz = DateOnly.FromDateTime(DateTime.Now),
                    TimeOfQuiz = TimeOnly.FromDateTime(DateTime.Now),
                    NumberOfQuestionsInQuiz = 10,
                    Score = 6,
                    Name = "Ken Sim",
                },
                new QuizResult() {
                    QuizResultId = 4,
                    WebAppId = guids[3],
                    Category = "Entertainment: Film",
                    DateOfQuiz = DateOnly.FromDateTime(DateTime.Now),
                    TimeOfQuiz = TimeOnly.FromDateTime(DateTime.Now),
                    NumberOfQuestionsInQuiz = 10,
                    Score = 9,
                    Name = "Joe Sun",
                },
                new QuizResult() {
                    QuizResultId = 5,
                    WebAppId = guids[4],
                    Category = "Entertainment: Books",
                    DateOfQuiz = DateOnly.FromDateTime(DateTime.Now),
                    TimeOfQuiz = TimeOnly.FromDateTime(DateTime.Now),
                    NumberOfQuestionsInQuiz = 10,
                    Score = 4,
                    Name = "Sue Fox",
                },
                new QuizResult() {
                    QuizResultId = 6,
                    WebAppId = guids[5],
                    Category = "Entertainment: Music",
                    DateOfQuiz = DateOnly.FromDateTime(DateTime.Now),
                    TimeOfQuiz = TimeOnly.FromDateTime(DateTime.Now),
                    NumberOfQuestionsInQuiz = 10,
                    Score = 7,
                    Name = "Ben Ray",
                },
                new QuizResult() {
                    QuizResultId = 7,
                    WebAppId = guids[6],
                    Category = "Entertainment: Books",
                    DateOfQuiz = DateOnly.FromDateTime(DateTime.Now),
                    TimeOfQuiz = TimeOnly.FromDateTime(DateTime.Now),
                    NumberOfQuestionsInQuiz = 10,
                    Score = 4,
                    Name = "Zoe Cox",
                },
                new QuizResult() {
                    QuizResultId = 8,
                    WebAppId = guids[7],
                    Category = "Entertainment: Film",
                    DateOfQuiz = DateOnly.FromDateTime(DateTime.Now),
                    TimeOfQuiz = TimeOnly.FromDateTime(DateTime.Now),
                    NumberOfQuestionsInQuiz = 10,
                    Score = 10,
                    Name = "Sam Ray",
                },
                new QuizResult() {
                    QuizResultId = 9,
                    WebAppId = guids[8],
                    Category = "General Knowledge",
                    DateOfQuiz = DateOnly.FromDateTime(DateTime.Now),
                    TimeOfQuiz = TimeOnly.FromDateTime(DateTime.Now),
                    NumberOfQuestionsInQuiz = 10,
                    Score = 8,
                    Name = "Dan Ash",
                },
                new QuizResult() {
                    QuizResultId = 10,
                    WebAppId = guids[9],
                    Category = "General Knowledge",
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

