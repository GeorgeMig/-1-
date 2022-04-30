Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "питер")
{
    Console.WriteLine("Здраствуй, мой мальчик! Все борешься с ленью?");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}