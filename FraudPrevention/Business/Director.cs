namespace FraudPrevention.Business
{
    using FraudPrevention.Business.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Director
    {

        private readonly IReader reader;
        private readonly IWriter writer;
        private IEnumerable<IFraudControl> control;

        public Director(IReader reader, IWriter writer, IEnumerable<IFraudControl> control)
        {
            this.reader = reader;
            this.writer = writer;
            this.control = control;
        }

        public void Process()
        {
            IEnumerable<string> data = this.reader.Read();

            List<string> results = new List<string>();
            foreach (var operation in control)
            {
                if (operation.ExistFraud(data) == true)
                    {
                        FraudDetected();
                    }
                
            }

            this.writer.Write(data);
        }

        private void FraudDetected()
        {
            Console.WriteLine("Fraud is going on");
            break;
        }
    }
}

