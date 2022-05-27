using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppInterfaces
{
    internal class TodoList : IDisplayable
    {
        // properties
        public string[] Todos
        { get; private set; }

        // fields
        private int nextOpenIndex;

        // methods
        public TodoList()
        {
            Todos = new string[5];
            nextOpenIndex = 0;
        }

        public void Add(string todo)
        {
            Todos[nextOpenIndex] = todo;
            nextOpenIndex++;
        }
        public void Display()
        {
            foreach (string todo in Todos)
            {
                Console.WriteLine(todo);
            }
        }

        public void Reset()
        {
            Todos = new string[5];
            nextOpenIndex=0;
        }
    }
}
