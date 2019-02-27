namespace FraudPrevention.Business.Interfaces
{

    public interface IFraudControl
    {
        bool ExistFraud(IEnumerable<string> data);
    }
}

// You can add others FraudDetection classes implementing this interface
//In this case I only implemented one, DifferentCardInfo
