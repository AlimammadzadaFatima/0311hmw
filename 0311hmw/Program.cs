using System;
using _0311hmw;
namespace _0311hmw
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Console.WriteLine("Istifadeci adinizi daxil edin;");
            string usernamestr = Console.ReadLine();
            User user = new User(usernamestr);
            try
            {
                user.Username = (usernamestr);
            }
            catch (InvalidUserNameException n)
            {
                Console.WriteLine(n.Message);
            }
            try
            {
                Console.WriteLine("Parolunuzu daxil edin;");
                string passwordstr = Console.ReadLine();
               user.Password =(passwordstr);
                Console.WriteLine("Girisiniz ugurla tamamlanmisdir...");
            }
            catch (PasswordIncorrectException p)
            { Console.WriteLine(p.Message); }
            
            
        }
    }
}
