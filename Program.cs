using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> user = new List<string>();
            user.Add("Shamil Celilzade");
            user.Add("Ibrahim Huseynov");
            user.Add("Elcan Musali");
            user.Add("Cavid Bunyatov");

            UserList ul = new UserList();
            ul.GetUser(user);


            Console.WriteLine(ul.Name);
            Console.WriteLine(ul.Surname);

            Console.Read();
        }
    }
}
