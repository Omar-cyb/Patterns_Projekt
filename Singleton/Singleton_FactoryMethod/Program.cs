using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer computer = new Computer();
            computer.StartComputer("Windows 10");
            computer.OperationSystem.GraphicDriver.ChangeDriver("Intel");
            computer.OperationSystem.NetworkAdapterDriver.ChangeDriver("Some Network Adapter Driver");
            computer.OperationSystem.NetworkAdapterDriver.RestoreDriver();
            computer.OperationSystem.SoundDriver.ChangeDriver("HD sound");
            computer.OperationSystem.RestoreDrivers();
        }
    }
}
