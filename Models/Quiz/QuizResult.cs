using System;
namespace ApiPool.Models.Quiz;

public class QuizResult
{
	public int QuizResultId { get; set; }
	public string? WebAppId { get; set; }
	public string? Category { get; set; }
	public DateOnly DateOfQuiz { get; set; }
	public TimeOnly TimeOfQuiz { get; set; }
	public int NumberOfQuestionsInQuiz { get; set; }
	public int Score { get; set; }
	public string? Name { get; set; }
}

