public class math : Assignments
{
    private string _textBook;
    private string _problem;

    public math (string name, string topic, string textBook, string problem)
        : base(name, topic)
    {
        _textBook = textBook;
        _problem = problem;
    }

    public string GetHomework()
    {
        return $"Section {_textBook} Problems {_problem}";
    }
}