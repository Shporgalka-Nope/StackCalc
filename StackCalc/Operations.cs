using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackCalc
{
    public enum OperationType
    {
        Plus,
        Minus,
        Division,
        Multiplication
    }

    public class Plus : IOperation
    {
        public void Run(CStack stack)
        {
            Node elementTwo = stack.Pop();
            Node elementOne = stack.Pop();
            float result = elementOne.data + elementTwo.data;
            string str = "";
            stack.Push(str += result);
        }
    }
}
