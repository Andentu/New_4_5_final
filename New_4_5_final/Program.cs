using System.Reflection.Metadata;

namespace New_4_5_final
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (string Name, string Surname, string Login, int LoginLength, bool HavePets, double PersonAge, string[] favcolors) User;
            Console.WriteLine("Введите имя");
            User.Name = Console.ReadLine();
            Console.WriteLine("Введите фамилию");
            User.Surname = Console.ReadLine();
            Console.WriteLine("Введите логин");
            User.Login = Console.ReadLine();
            User.LoginLength = User.Login.Length;
        }
    }
}