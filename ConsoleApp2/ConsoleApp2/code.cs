using System;

namespace ClassPotok
{
    public class Robot
    {
        private int x { get; set; }
        private int y { get; set; }
        private string name { get; set; }
        private Random random;

        public Robot(string name)
        {
            this.name = name;
            x = 0;
            y = 0;
            random = new Random();
        }

        public void Move()
        {
            int direction = random.Next(4);

            switch (direction)
            {
                case 0:
                    // Вперед
                    y++;
                    Console.WriteLine("Робот {0} двигается вперёд", name);
                    break;
                case 1:
                    // Назад
                    y--;
                    Console.WriteLine("Робот {0} двигается назад", name);
                    break;
                case 2:
                    // Поворот налево
                    x--;
                    Console.WriteLine("Робот {0} поворачивает налево", name);
                    break;
                case 3:
                    // Поворот направо
                    x++;
                    Console.WriteLine("Робот {0} поворачивает направо", name);
                    break;
            }
        }

        public void GetInfo()
        {
            Console.WriteLine("Робот {0} находится на координатах ({1}, {2})", name, x, y);
        }
    }
}