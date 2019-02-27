namespace FraudPrevention.Business.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public interface IWriter
    {
        void Write(IEnumerable<string> data);
    }
}
