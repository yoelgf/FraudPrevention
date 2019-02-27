namespace FraudPrevention.Business
{
    using FraudPrevention.Business.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    class ConsoleReader : IReader
    {
        public IEnumerable<string> Read()
        {
            List<string> a = new List<string>();
            string data = null;
            do
            {
                data = Console.ReadLine();
                HandlerOfTricks();
                a.Add(data);

            }
            while (data != "end");

            return a;    
        }

    
    }
}
