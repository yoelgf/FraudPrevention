namespace FraudPrevention.Business.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public interface IReader
    {
        IEnumerable<string> Read();
    }
}
