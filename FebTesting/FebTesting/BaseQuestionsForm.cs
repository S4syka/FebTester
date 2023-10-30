using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FebTesting;

public partial class BaseQuestionsForm : Form
{
    protected int _currentQuestionIndex;
    protected Question _currentQuestion;

    protected List<Question> Questions { get; set; }

    public BaseQuestionsForm()
    {
        InitializeComponent();
        List<Question> questions = new List<Question>();
        Questions = questions;
        _currentQuestion = questions[0];
        _currentQuestionIndex = 0;

        LoadQuestion();
    }

    protected void LoadQuestion()
    {
        LoadQuestion(_currentQuestionIndex);
    }

    protected virtual void ResetControls()
    {
        throw new NotImplementedException();
    }

    protected void LoadQuestion(int index)
    {
        _currentQuestionIndex = index;
        _currentQuestion = Questions[index];
        ResetControls();

        QuestionTxt.Text = _currentQuestion.QuestionText;
    }

    protected void LoadNextQuestion()
    {
        if (!Settings.Randomize)
        {
            _currentQuestionIndex = Math.Min(Questions.Count - 1, _currentQuestionIndex + 1);
        }
        else
        {
            _currentQuestionIndex = Random.Shared.Next(Questions.Count);
        }

        LoadQuestion(_currentQuestionIndex);
    }

    protected void LoadPrvQuestion()
    {
        if (!Settings.Randomize)
        {
            _currentQuestionIndex = Math.Max(0, _currentQuestionIndex - 1);
        }
        else
        {
            _currentQuestionIndex = Random.Shared.Next(Questions.Count);
        }

        LoadQuestion(_currentQuestionIndex);
    }
}
