using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserList
{
    internal class UserList
    {
        public string Name;
        public string Surname;

        public void GetUser(List<string> users)
        {
            foreach (string item in users)
            {
                Console.WriteLine(item);
            }
            foreach (string item in users)  //ozumden yoxlamaq ucun yazmisham
            {
                Name = item.Substring(0, item.IndexOf(' '));
                Surname = item.Substring(item.IndexOf(' ') + 1);
            }
        }
    }
}
