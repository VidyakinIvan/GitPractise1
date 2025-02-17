Console.WriteLine("Привет! Это самый лучший чат-бот! Он ничего не умеет, да и ладно!");
Console.WriteLine("Поговори со мной!");
string ? command = Console.ReadLine();
while  (command != "Выход")
{
    switch (command)
    {
        case "Привет":
            Console.WriteLine("Привет!");
            break;
        case "Как погода?":
            Console.WriteLine("Жарковато сегодня");
            break;
        case "Мне грустно":
            Console.WriteLine("Не грусти!");
            break;
        default:
            Console.WriteLine("Не понял, но согласен!!!!!!!!!!!!!!!!!!!");
            break;
    }
    command = Console.ReadLine();
}