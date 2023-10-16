namespace Task2;

public class Network
{
    public List<Computer> Computers { get; private set; }

    public Network()
    {
        Computers = new List<Computer>();
    }

    public void AddComputer(Computer computer)
    {
        Computers.Add(computer);
    }

    public void RemoveComputer(Computer computer)
    {
        Computers.Remove(computer);
    }

    public void Connect(Computer computer1, Computer computer2)
    {
        if (computer1 is IConnectable && computer2 is IConnectable)
        {
            ((IConnectable)computer1).Connect(computer2);
            ((IConnectable)computer2).Connect(computer1);
  
        }
    }

    public void Disconnect(Computer computer1, Computer computer2)
    {
        if (computer1 is IConnectable && computer2 is IConnectable)
        {
            ((IConnectable)computer1).Disconnect(computer2);
            ((IConnectable)computer2).Disconnect(computer1);
        }
    }

    public void TransmitData(Computer fromComputer, Computer toComputer, string data)
    {
        if (fromComputer is IConnectable)
        {
            ((IConnectable)fromComputer).TransmitData(toComputer, data);
        }
    }
}
