Console.WriteLine("Enter username: ");
string username = Console.ReadLine();

if(username.ToLower() == "merry")
{
    Console.WriteLine("WOW, merry");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}
