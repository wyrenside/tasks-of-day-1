using System.ComponentModel.Design;

string username = Console.ReadLine();
string password = Console.ReadLine();
if
    (username == "admin" && password == "Admin123") 
{
    Console.WriteLine("Welcome");
}
else if
    (username != "admin" || password != "Admin123")
{
    Console.WriteLine("Username or password is incorrect");
}