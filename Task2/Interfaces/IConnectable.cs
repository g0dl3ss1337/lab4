namespace Task2;

public interface IConnectable
{
    void Connect(Computer otherComputer);
    void Disconnect(Computer otherComputer);
    void TransmitData(Computer otherComputer, string data);
    string ReceiveData(Computer otherComputer);
}
