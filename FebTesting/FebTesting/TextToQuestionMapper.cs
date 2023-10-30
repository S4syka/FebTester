using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using FebTesting.Enums;
using System.Text.RegularExpressions;

namespace FebTesting;

public class TextToQuestionMapper
{
    private string GetAnswer(string text)
    {
        //Answer:{GetAnswer}
        return text.Trim().Remove(0, 7).ToUpper();
    }

    private QuestionType GetAnswerType(string text)
    {
        var answer = GetAnswer(text);

        if(answer == "A" || answer == "B" || answer == "C" || answer == "D" || answer == "E")
        {
            return QuestionType.Closed;
        }
        else if(answer == "TRUE" || answer == "FALSE")
        {
            return QuestionType.TrueFalse;
        }
        else
        {
            return QuestionType.Open;
        }
    }

    private Question? GetNextQuestion(int questionNumber, StreamReader reader)
    {
        string accumulatedQuestion = string.Empty;
        string accumulatedAnswer = string.Empty;

        string? line;
        while (true)
        {
            line = reader.ReadLine();

            if (line == null)
            {
                return null;
            }

            if(line.StartsWith(questionNumber + ")")) {
                break;
            }
        }

        accumulatedQuestion += line;
        while (true)
        {
            line = reader.ReadLine();

            if(line == null)
            {
                return null;
            }

            if (!line.StartsWith("Answer"))
            {
                accumulatedQuestion += line;
            }
            else
            {
                break;
            }
        }

        QuestionType questionType = GetAnswerType(line);

        if (questionType != QuestionType.Open)
        {
            accumulatedAnswer += GetAnswer(line);
            return new Question(questionNumber, questionNumber, accumulatedQuestion, accumulatedAnswer, questionType);
        }

        //Answer: {ActualAnswer}
        accumulatedAnswer += line.Remove(0, 8);

        while (true)
        {
            line = reader.ReadLine();

            if(line == null)
            {
                return null;
            }

            if(line.StartsWith("Diff: "))
            {
                break;
            }
            else
            {
                accumulatedAnswer += line;
            }
        }

        return new Question(Settings.Chapter, questionNumber, accumulatedQuestion, accumulatedAnswer, questionType);
    }


    private List<Question> GetAllQuestions()
    {
        List<Question> result = new List<Question>();
        int questionHaveToRead = 1;

        string questionFilePath = Path.Combine(Directory.GetCurrentDirectory(), "Questions", Settings.Chapter.ToString());

        using (var reader = new StreamReader(questionFilePath))
        {
            while (true)
            {
                Question? question = GetNextQuestion(questionHaveToRead, reader);

                if (question == null)
                {
                    break;
                }
                else
                {
                    result.Add(question);
                    questionHaveToRead++;
                }
            }
        }

        return result;
    }

    public List<Question> GetTrueFalseQuestions() => GetAllQuestions().Where(q => q.Type == QuestionType.TrueFalse).ToList();

    public List<Question> GetOpenQuestions() => GetAllQuestions().Where(q => q.Type == QuestionType.Open).ToList();

    public List<Question> GetClosedQuestions() =>  GetAllQuestions().Where(q => q.Type == QuestionType.Closed).ToList();
}
