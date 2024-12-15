using System.Net;
using System.Security;

namespace StackCalc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InputConvert();
        }

        public static void InputConvert()
        {
            Console.WriteLine("Write expression");
            string expression = Console.ReadLine() + " ";
            
            Stack<string> newStack = new Stack<string>();
            string sign = "";
            string operation = "";
            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '+' || expression[i] == '-' || expression[i] == '*' || expression[i] == '/') 
                {
                    operation = expression[i].ToString();
                    i += 1;
                }
                else if (expression[i] != ' ') { sign += expression[i]; }
                else
                {
                    newStack.Push(sign);
                    if (operation != "") { newStack.Push(operation); }
                    sign = "";
                    operation = "";
                }
            }
            string res = "";
            foreach (string element in newStack.Reverse())
            {
                res += element + " ";
            }
            Input(res);
        }

        static void Input(string ex)
        {
            string expression = ex;
            CStack newStack = new CStack();
            string sign = "";
            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] != ' ') { sign += expression[i]; }
                else 
                { 
                    newStack.Push(sign);
                    sign = "";
                }
            }

            Console.Clear();
            Console.WriteLine("Result: ");
            Node current = newStack.head;
            while (current != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }

            Thread.Sleep(2000);
            Console.Clear();
            InputConvert();
        }
    }
}
