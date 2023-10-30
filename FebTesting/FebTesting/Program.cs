namespace FebTesting;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        TextToQuestionMapper mapper = new TextToQuestionMapper();

        ApplicationConfiguration.Initialize();
        Application.Run(new ClosedQuestionsForm(mapper.GetClosedQuestions()));
    }
}