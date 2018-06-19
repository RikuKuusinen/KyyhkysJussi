using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peli
{
    public class Game
    {
        public int Width { get; private set; }
        public int Heigth { get; private set; }
        public int Generation { get; private set; }
        public bool[,] PeliLauta { get => peliLauta; set => peliLauta = value; }

        private bool[,]  peliLauta;


        public Game(int width, int height)
        {

            PeliLauta = new bool[width, height];
            Width = width;
            Heigth = height;

        }
        public void SetCell(int x, int y, bool alive)
        {
            PeliLauta[x, y] = alive;
            
            
        }
        bool NextGeneration()
        {
            
        }
        bool IsCellAlive(int x, int y)
        {
            return PeliLauta[x, y];           
            
        }
        bool[,] GetGameBoard()
        {

        }
    }
}
