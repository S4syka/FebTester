using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FebTesting;

public partial class TrueFalseForm : Form
{
    private int _currentQuestionIndex;
    private Question _currentQuestion;

    private List<Question> Questions { get; set; }

    public TrueFalseForm(List<Question> questions)
    {
        InitializeComponent();
        Questions = questions;
        _currentQuestion = questions[0];
        _currentQuestionIndex = 0;

        LoadQuestion();
    }

    private void LoadQuestion(int index)
    {
        _currentQuestionIndex = index;
        _currentQuestion = Questions[index];
        ResetControls();

        QuestionTxt.Text = _currentQuestion.QuestionText;
    }


    private void LoadQuestion()
    {
        LoadQuestion(_currentQuestionIndex);
    }

    private void LoadNextQuestion()
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

    private void LoadPrvQuestion()
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


    private void ResetControls()
    {
        AnsFalse_btn.BackColor = Color.White;
        AnsTrue_btn.BackColor = Color.White;

        PagingTxt.Text = (_currentQuestionIndex + 1).ToString() + $"/{Questions.Count}";
    }

    private void CheckAnswer(object sender, EventArgs e)
    {
        Button clickedButton = (Button)sender;

        if (clickedButton.Tag!.ToString() == _currentQuestion.Answer)
        {
            clickedButton.BackColor = Color.Green;
        }
        else
        {
            clickedButton.BackColor = Color.Red;
        }

        if (Settings.AutomaticallyMoveIfCorrect)
        {
            LoadNextQuestion();
        }
    }

    private void PrvBtn_Click(object sender, EventArgs e)
    {
        LoadPrvQuestion();
    }

    private void NextBtn_Click(object sender, EventArgs e)
    {
        LoadNextQuestion();
    }
}