namespace FraudPrevention.Business
{
    using FraudPrevention.Business.Interfaces;
    using System;
    using System.Collections.Generic;


    class ConsoleWriter : IWriter
    {
        public void Write(IEnumerable<string> data)
        {
            foreach(var text in data)
            {
                Console.WriteLine(text);
            }

        }
    }
}
