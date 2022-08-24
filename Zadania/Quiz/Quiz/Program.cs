using Quiz;

var quiz = File.ReadLines("Quiz.txt");
List<Question> questionList = new List<Question>();
Random rand = new Random();
bool isCorrect = true;
bool correctValue = true;

foreach (var line in quiz)
{
    var textLine = line.Split(';');
    string text = $"{textLine[0]} 0.{textLine[1]} 1.{textLine[2]} 2.{textLine[3]} 3.{textLine[4]}";
    Question question = new Question(textLine[0], textLine[1..5], int.Parse(textLine[5]));
    questionList.Add(question);
}


do
{
    int id = 0;
    try
    {

        if (correctValue == true)
        {

            id = rand.Next(0, questionList.Count - 1);
            Console.WriteLine(questionList[id].Text);
            Console.WriteLine(questionList[id].Answers);
        }

        int answer = int.Parse(Console.ReadLine());

        if (answer != questionList[id].CorrectAnswerIndex)
        {
            isCorrect = false;
            Console.WriteLine($"Niepoprawna odpowiedź. Odpowiedź to {questionList[id].CorrectAnswerIndex}");
        }
        else if (answer > 3)
        {
            correctValue = false;
            throw new ArgumentException("Niepoprawna wartość. Podaj numer odpowiedzi.");
        }
        else
        {
            correctValue = true;
        }
    }
    catch (FormatException)
    {
        correctValue = false;
        Console.WriteLine("Niepoprawna wartość. Podaj numer odpowiedzi.");
    }
    

} while (isCorrect);

Console.ReadLine();



  
