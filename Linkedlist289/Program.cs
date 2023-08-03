using System.Collections.Generic;

namespace Linkedlist289
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Linkedlist program");
            Linkedlist linkedList = new Linkedlist();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("1 : Add Data");
                int Option = Convert.ToInt32(Console.ReadLine());
                switch (Option)
                {
                    case 1:
                        linkedList.Add(30);
                        linkedList.Add(56);
                        linkedList.Add(70);
                        break;
                }
            }
        }
    }
}