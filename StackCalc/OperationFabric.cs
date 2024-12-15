using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace StackCalc
{
    public abstract class OperationFabric
    {
        public abstract IOperation GenerateOperation();

        public IOperation GetOperation()
        {
            return this.GenerateOperation();
        }
    }

    public class Fabric : OperationFabric
    {
        private string key;

        public Fabric(string k)
        {
            this.key = k;
        }

        public override IOperation GenerateOperation()
        {
            switch (this.key)
            {
                case "+":
                    return new Plus();
                case "-":
                    return new Minus();
                case "*":
                    return new Myltiplication();
                case "/":
                    return new Division();
                default:
                    throw new InvalidOperationException();
            }
        }
    }
}
