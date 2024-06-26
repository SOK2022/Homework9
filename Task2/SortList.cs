using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class SortList
    {
        public event Action<string, string[]> SortEvent;

        public void StartProcess(string choice, string[] LastNames)
        {
            Console.WriteLine("Начинается сортировка списка фамилий");
            Sort(choice, LastNames);
        }

        protected void Sort(string choice, string[] LastNames)
        {
            SortEvent.Invoke(choice, LastNames);
        }
    }
}
