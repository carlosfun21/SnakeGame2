using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Snake2
{
    public enum DireccioSnake
    {
        Dreta,
        Esquerre,
        Avall,
        Amunt
    }

    class SnakeGame
    {
        public const int X_SIZE = 10;
        public const int Y_SIZE = 10;
        public const int NPOMES = 5;

        Point capSerp = new Point(X_SIZE/2, 0);
        DireccioSnake direccio = DireccioSnake.Dreta;
        List<Point> pomes = new List<Point>();
        Random r = new Random();
        public SnakeGame()
        {
            for (int i = 0; i < NPOMES; i++)
            {
                Pomes.Add(new Point(r.Next(0, X_SIZE), r.Next(0, Y_SIZE)));

            }
        }
        public Point CapSerp { get => capSerp; set => capSerp = value; }
        public DireccioSnake Direccio { get => direccio; set => direccio = value; }
        public List<Point> Pomes { get => pomes; }

        internal void moure(DireccioSnake dir)
        {
            if (dir == DireccioSnake.Avall) capSerp.Y--;
            else if (dir == DireccioSnake.Amunt) capSerp.Y++;
            else if (dir == DireccioSnake.Esquerre) capSerp.X--;
            else if (dir == DireccioSnake.Dreta) capSerp.X++;

        }
    }
}
