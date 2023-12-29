
(string FirstName, string LastName, int Age, bool HaveAPet, int PetCount, string[] PetNames, int FavcolorsCount, string[] Favcolors) User = new()
{
    FirstName = GetInput("Enter your first name"),
    LastName = GetInput("Enter your last name"),
    Age = CheckCorrectNumberInput("Enter your age"),
    HaveAPet = GetInput("Do you have a pet? (y/n)") == "y"
};

if (User.HaveAPet)
{
    User.PetCount = CheckCorrectNumberInput("How many pets do you have?");
    User.PetNames = GetArrayOfInputs(User.PetCount, "Enter the name of the pet");
}
User.FavcolorsCount = CheckCorrectNumberInput("Enter the count of your favorite colors");
User.Favcolors = GetArrayOfInputs(User.FavcolorsCount, "Enter your favorite color");

ShowUserInfo(User);
Console.ReadKey();
        

        static void ShowUserInfo((string FirstName, string LastName, int Age, bool HaveAPet, int PetCount, string[] PetNames, int FavcolorsCount, string[] Favcolors) user)
{
    Console.WriteLine($"{Environment.NewLine}Your information:{Environment.NewLine}" +
        $"First name: {user.FirstName}{Environment.NewLine}" +
        $"Last name: {user.LastName}{Environment.NewLine}" +
        $"Age: {user.Age}{Environment.NewLine}" +
        $"You {BuildCorrectString(user.HaveAPet, user.PetCount, "pet")}");
    ShowArrayInfo(user.PetNames, user.HaveAPet);
    Console.WriteLine("You " + BuildCorrectString(true, user.FavcolorsCount, "favorite color"));
    ShowArrayInfo(user.Favcolors);
}

static void ShowArrayInfo(string[] array, bool NeedToShow = true)
{
    if (NeedToShow)
    {
        foreach (string item in array) Console.WriteLine($"{item};");
    }
}
static string BuildCorrectString(bool condition, int count, string str)
{
    string correctStr = condition ? "have" : $"have no {str}s";
    if (condition)
    {
        if (count == 1)
        {
            correctStr += $" 1 {str}: ";
        }
        else
        {
            correctStr += $" {count} {str}s: ";
        }
    }
    return correctStr;
}
static string[] GetArrayOfInputs(in int arrayCount, in string question)
{
    string[] array = new string[arrayCount];
    for (int i = 0; i < arrayCount; i++)
    {
        array[i] = GetInput($"{question} #{i + 1}");
    }
    return array;
}
static int CheckCorrectNumberInput(in string checkPhrase)
{
    int correctNumber;
    do
    {

    }
    while (!int.TryParse(GetInput(checkPhrase), out correctNumber) || correctNumber < 1);
    return correctNumber;
}
static string GetInput(in string question)
{
    Console.Write($"{question}: ");
    return Console.ReadLine();
}
