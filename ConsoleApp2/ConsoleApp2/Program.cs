using ClassPotok;

namespace PotokConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Robot robot = new Robot("Robot");
            for (int i = 0; i < 10; i++)
            {
                robot.Move();
                robot.GetInfo();
            }
        }
    }
}