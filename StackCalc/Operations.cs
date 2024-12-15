using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackCalc
{
    public class Plus : IOperation
    {
        public void Run(CStack stack)
        {
            Node elementTwo = stack.Pop();
            Node elementOne = stack.Pop();
            float result = elementOne.data + elementTwo.data;
            stack.Push(result.ToString());
        }
    }

    public class Minus : IOperation
    {
        public void Run(CStack stack)
        {
            Node elementTwo = stack.Pop();
            Node elementOne = stack.Pop();
            float result = elementOne.data - elementTwo.data;
            stack.Push(result.ToString());
        }
    }

    public class Myltiplication : IOperation
    {
        public void Run(CStack stack)
        {
            Node elementTwo = stack.Pop();
            Node elementOne = stack.Pop();
            float result = elementOne.data * elementTwo.data;
            stack.Push(result.ToString());
        }
    }

    public class Division : IOperation
    {
        public void Run(CStack stack)
        {
            Node elementTwo = stack.Pop();
            Node elementOne = stack.Pop();
            float result = elementOne.data / elementTwo.data;
            stack.Push(result.ToString());
        }
    }
}
