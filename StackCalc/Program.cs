namespace StackCalc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Input();
        }

        static void Input()
        {
            Console.WriteLine("Write expression");
            string expression = Console.ReadLine();
            CStack newStack = new CStack();
            foreach (char ch in expression)
            {
                string str = "";
                newStack.Push(str += ch);
            }
        }
    }
}
