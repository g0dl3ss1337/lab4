namespace Task2;

using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Network network = new Network();

        // Пристрої
        Computer PC1 = new Computer
        {
            IPAddress = "192.168.1.1",
            Power = 500,
            OperatingSystem = "Windows 10"
        };

        Computer PC2 = new Computer
        {
            IPAddress = "192.168.1.2",
            Power = 600,
            OperatingSystem = "Linux"
        };

        Server server1 = new Server
        {
            IPAddress = "192.168.1.3",
            Power = 1000,
            OperatingSystem = "Windows Server 2019",
            CoreCount = 8
        };

        // Додання до мережі
        network.AddComputer(PC1);
        network.AddComputer(PC2);
        network.AddComputer(server1);

        Console.WriteLine("Додавання пристроїв до мережі.");

        // Підключення пристроїв між собою
        network.Connect(PC1, PC2);
        network.Connect(PC1, server1);

        Console.WriteLine("Підключено PC1 до PC2.");
        Console.WriteLine("Підключено PC1 до server1.");

        // Передача інформації між пристроями
        network.TransmitData(PC1, PC2, "Передача інформації від PC1 до PC2");
        network.TransmitData(server1, PC1, "Передача інформації від сервера до PC1");

        Console.WriteLine("Передача інформації між пристроями.");

        // Відключення пристроїв
        network.Disconnect(PC1, PC2);

        Console.WriteLine("Відключення PC1 від PC2.");

        // Інфо про пристрої
        Console.WriteLine("PC1 IP: " + PC1.IPAddress);
        Console.WriteLine("PC2 IP: " + PC2.IPAddress);
        Console.WriteLine("Сервер 1 IP: " + server1.IPAddress);

        // Додаткова інфо для сервера
        if (server1 is Server)
        {
            Console.WriteLine("Сервер 1 ядра: " + server1.CoreCount);
        }
    }
}
