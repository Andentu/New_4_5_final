using System.Reflection.Metadata;

namespace New_4_5_final
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int j = 0; j < 3; j++)
            {
                (string Name, string Surname, string Login, int LoginLength, bool HavePets, double PersonAge, string[] favcolors) User;
                Console.WriteLine("Введите имя");
                User.Name = Console.ReadLine();
                Console.WriteLine("Введите фамилию");
                User.Surname = Console.ReadLine();
                Console.WriteLine("Введите логин");
                User.Login = Console.ReadLine();
                User.LoginLength = User.Login.Length;

                Console.WriteLine("Есть ли у вас животные? Да или Нет");
                if (Console.ReadLine() == "Да")
                {
                    User.HavePets = true;
                }

                Console.WriteLine("Введите ваш возраст:");
                User.PersonAge = double.Parse(Console.ReadLine());
                User.favcolors = new string[3];
                Console.WriteLine("Введите три любимых цвета пользователя");
                for (int i = 0; i < User.favcolors.Length; i++)
                {
                    User.favcolors[i] = Console.ReadLine();
                }


            }
        }
    }
}