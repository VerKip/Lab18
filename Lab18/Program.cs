using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку со скобками");
            string str = Console.ReadLine();
            //Console.WriteLine(Check(str));
            if (Check(str))
                Console.WriteLine("Все хорошо");
            else
                Console.WriteLine("Неверная расстановка скобок");
            Console.ReadKey();
        }

        static bool Check(string str)
        { 
            Stack<char> stack = new Stack<char>();
            Dictionary<char, char> dic = new Dictionary<char, char>
            {
                {'(',')' },
                {'{','}' },
                {'[',']' }, };

            foreach(char c in str)
            {
                if (c == '(' || c =='[' || c =='{')
                    stack.Push(dic[c]);
                if (c== ')' || c =='}' || c ==']')
                {
                    if (stack.Count==0 || stack.Pop()!=c)
                    {
                        return false;
                    }
                }
            }
            if (stack.Count == 0)
                return true;
            else
                return false;
        }
    }
}
