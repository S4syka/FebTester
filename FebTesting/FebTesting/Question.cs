using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FebTesting.Enums;

namespace FebTesting;

public class Question
{
    public int Chapter { get; set; }

    public int Number { get; set; }

    public string? QuestionText { get; set; }

    public string? Answer { get; set; }

    public QuestionType Type { get; set; }

    public Question(int chapter, int number, string questionText, string answer, QuestionType type)
    {
        if (questionText == null) throw new ArgumentNullException(nameof(questionText));
        if (answer == null) throw new ArgumentNullException(nameof(answer));

        Chapter = chapter;
        Number = number;
        QuestionText = questionText;
        Answer = answer;
        Type = type;
    }
}