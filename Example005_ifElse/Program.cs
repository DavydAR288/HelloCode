// Условие на определение особенного имени
string username;
Console.Write("Введите имя пользователя: ");
username = Console.ReadLine();

if (username.ToLower() == "alex")
{
    Console.WriteLine("Здравствуй, создатель!");
}
else
{
    Console.Write("Привет, ");
    Console.Write(username);
    Console.Write("!");
}
