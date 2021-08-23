using System;
// for practice, wrap top-level statements in Main function to convert them into idomatic C#
Main();

void Main()
{
    Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
    Console.WriteLine("--------------------------------------------");
    Console.WriteLine();

    // Let the moose speak!
    MooseSays("H I, I'M  E N T H U S I A S T I C !");
    MooseSays("I really am enthusiastic");
    // refactor separate question functions with same characteristics (3 string parameters comprising a prompt,
    // and a yes or no response) into a single question function
    // ?? don't know the terminology yet for the code below. Declaring a function and its parameters?
    AskQuestion("Is Canada real?", "Really? It seems very unlikely.", "I  K N E W  I T !!!");
    AskQuestion("Are you enthusiastic?", "Yay!", "You should try it!");
    AskQuestion("Do you love C# yet?", "Good job sucking up to your instructor!", "You will...oh, yes, you will...");
    AskQuestion("Do you want to know a secret?", "ME TOO!!!! I love secrets...tell me one!", "Oh, no...secrets are the best, I love to share them!");
}
// invoke Main function
Main();

// invoke AskQuestion method. void = will not return anything
// AskQuestion() method accepts 3 parameters and uses string interpolation to display the question to the CLI:
void AskQuestion(string question, string yesAnswer, string noAnswer)
{
    bool isAnswer = MooseAsks($"{ question} (Y/N): ");
    if (isAnswer)
    {
        MooseSays(yesAnswer);
    }
    else
    {
        MooseSays(noAnswer);
    }
}

// adding an @ in front of the string allows for a multi-line string
// adding the $ character to the front of the string enables string interpolation
// invoke MooseSays, passing in as parameter the defined strings
void MooseSays(string message)
{
    Console.WriteLine($@"
                                      _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ _     _  \.'
               '-'    | /       \ |
                      |  .-. .-.  |
                      \ / o| |o \ /
                       |   / \   |    {message}
                      / `^`   `^` \
                     /             \
                    | '._.'         \
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                       `^^` `^^^`
    ");
}

// MooseAsks() method returns data type of boolean that takes a question (as string parameter) as an input 
// and returns the parameter (as interpolated string) for an answer, depending on evaluation of Y/N.
// while loop checks condition of variable: Y/N/neither, then returns true/false or reprints question.
// on the input:
bool MooseAsks(string question)
{
    Console.Write($"{question} (Y/N): ");
    string answer = Console.ReadLine().ToLower();

    while (answer != "y" && answer != "n")
    {
        Console.Write($"{question} (Y/N): ");
        answer = Console.ReadLine().ToLower();
    }

    if (answer == "y")
    {
        return true;
    }
    else
    {
        return false;
    }

}