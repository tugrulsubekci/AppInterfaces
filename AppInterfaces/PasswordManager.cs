using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppInterfaces
{
    internal class PasswordManager : IDisplayable
    {
        // properties
        private string Password
        { get; set; }

        public bool Hidden
        { get; private set; }

        // methods
        public PasswordManager(string password, bool hidden)
        {
            Password = password;
            Hidden = hidden;
        }
        public void Display()
        {
            if (!Hidden)
            {
                Console.WriteLine(Password);
            }
            else
            {
                for (int i = 0; i < Password.Length; i++)
                {
                    Console.Write("*");
                }
                
            }
        }

        public void Reset()
        {
            Password = " ";
            Hidden = false;
        }
    }
}
