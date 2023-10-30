namespace FebTesting;

public partial class ClosedQuestionsForm : Form
{
    private int _currentQuestionIndex;
    private Question _currentQuestion;

    private List<Question> Questions { get; set; }

    public ClosedQuestionsForm(List<Question> questions)
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
        QuestionTxt.Text = _currentQuestion.QuestionText!.Replace("\n", "\r\n");
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
        AnsA_btn.BackColor = Color.White;
        AnsB_btn.BackColor = Color.White;
        AnsC_btn.BackColor = Color.White;
        AnsD_btn.BackColor = Color.White;
        AnsE_btn.BackColor = Color.White;

        PagingTxt.Text = (_currentQuestionIndex + 1).ToString() + $"/{Questions.Count}";
    }

    private void CheckAnswer(object sender, EventArgs e)
    {
        Button clickedButton = (Button)sender;

        if (clickedButton.Tag!.ToString() == _currentQuestion.Answer)
        {
            clickedButton.BackColor = Color.Green;

            if (Settings.AutomaticallyMoveIfCorrect)
            {
                LoadNextQuestion();
            }
        }
        else
        {
            clickedButton.BackColor = Color.Red;
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