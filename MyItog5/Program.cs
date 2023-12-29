(string MyName, string MyName2, int age, bool MyPet, int PetColvo, string[] NamePet, int Color, string[] NameColor) User = new()
{
    MyName = VvodDan("Введи своё имя! "), // Здесь мы присвоили методы к определенным картежам.
    MyName2 = VvodDan("Введи свою фамилию! "),
    age = proverkaNomer("Сколько тебе годиков? "),
    MyPet = VvodDan("У тебя есть животное? 1)Да - 2)Нет" ) == "1"
};
// Спасибо огромное Владиславу Миронову за помощь. Но даже так, некоторые аспекты мне дались сложно. Понимание есть, я потратил на разборку его кода
// Достаточно времени и постарался сделать похоже. Самостоятельно, без помощи, увы у меня особо не получилось. Даже сейчас я не могу найти свою ошибку, голова идёт кругом.
if(User.MyPet)
{
    User.PetColvo = proverkaNomer("Сколько у тебя животных? ");
    User.NamePet = DlinaMassiva(User.PetColvo, "Назови своих животных ");
}

User.Color = proverkaNomer("Сколько у тебя любимых цветов? ");
User.NameColor = DlinaMassiva(User.Color, "Назови любимые цвета! ");

Infa(User);
Console.ReadKey();

static void Infa((string MyName, string MyName2, int age, bool MyPet, int PetColvo, string[] NamePet, int Color, string[] NameColor) user)
{
    Console.WriteLine("Твоё Имя = " + user.MyName);
    Console.WriteLine("Твоя Фамилия = " + user.MyName2);
    Console.WriteLine("Твоё имя = " + user.age);
    Console.WriteLine("Количество твоих животных! = " + user.PetColvo);
    Console.WriteLine("Количества твоих любимый цветов! = ", user.Color);
    
    for(int i = 0; i < user.PetColvo - 1; i++)
    {
        Console.WriteLine("Твой любимый цвет именуют! = ", user.NameColor[i]);
    }
    for (int j = 0; j < user.Color - 1; j++)
    {
        Console.WriteLine("Имя твоего животного! = ", user.NamePet[j]);
    }
}
static string[] DlinaMassiva(in int Massiv, in string Vopros)
{
    string[] Massivuska = new string[Massiv]; // Здесь мы создаем массивы под имена животных. Тоесть, после вопроса и ответа, в массив идет имя, написанный Пользователем.
    for(int i = 0; i < Massiv;  i++)
    {
        Massivuska[i] = VvodDan($"{Vopros} #{i + 1}");
    }
    return Massivuska;
}

static int proverkaNomer(in string FRAZA)
{
    int Numer; // Тут, с помощью Ду Вхайла, мы проверяем цифры ли там это, если нет, возращаем обратно. 
    do
    {

    }
    while (!int.TryParse(VvodDan(FRAZA), out Numer) || Numer < 1);
    return Numer;
}

static string VvodDan(in string Vopros)
{
    Console.Write($"{Vopros}: "); // А тут, совсем чудеса. С помощью этого метода мы и задаем вопросы.
    return Console.ReadLine();
}


