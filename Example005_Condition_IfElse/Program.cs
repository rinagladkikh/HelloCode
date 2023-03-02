Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "ирина")
{
    Console.WriteLine("Ура, это же ИРИНА!");
}
else
{
    Console.WriteLine("Привет, ");
    Console.WriteLine(username);
}