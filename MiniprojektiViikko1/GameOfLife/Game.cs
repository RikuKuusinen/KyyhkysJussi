using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public class Game
    {

        private bool[,] _board;
        private bool[,] Board { get => _board; set => _board = value; }

        public int Width { get; private set; }
        public int Height { get; private set; }
        public int Generation { get; private set; }

        public Game(int width, int height)
        {
            Board = new bool[width, height];
            Width = width;
            Height = height;
        }
        public Game(string filename)
        {
            loadGame(filename);
        }

        public void SetSCell(int x, int y, bool alive)
        {
            Board[x, y] = alive;
        }

        public void DumpBoard()
        {
            for (int x = 0; x < Width; x++)
            {
                for (int y = 0; y < Height; y++)
                {
                    Trace.Write(Board[x, y] ? 'X' : ' ');
                }
                Trace.WriteLine("");
            }
        }

        public bool NextGeneration()
        {
            Generation++;
            bool AtLeastOneAlive = false;
            bool[,] temp = new bool[Width, Height];
            for (int x = 0; x < Width; x++)
            {
                for (int y = 0; y < Height; y++)
                {
                    temp[x, y] = isAlive(Board, x, y);
                }
            }
            for (int x = 0; x < Width; x++)
            {
                for (int y = 0; y < Height; y++)
                {
                    Board[x, y] = temp[x, y];
                    if (Board[x, y])
                    {
                        AtLeastOneAlive = true;
                    }
                }
            }
            return AtLeastOneAlive;
        }

        public bool isAlive(int x, int y)
        {
            return Board[x, y];
        }

        private bool isAlive(bool[,] board, int x, int y)
        {
            int counter = 0;
            bool nowAlive = board[x, y];
            for (int i = Math.Max(0, x - 1); i <= Math.Min(x + 1, Width - 1); i++)
            {
                for (int j = Math.Max(y - 1, 0); j <= Math.Min(y + 1, Height - 1); j++)
                {
                    if (i == x && j == y)
                    {
                        continue;
                    }
                    counter += board[i, j] ? 1 : 0;
                }
            }
            if (!nowAlive && counter == 3)
            {
                return true;
            }
            if (nowAlive && (counter == 2 || counter == 3))
            {
                return true;
            }
            return false;
        }

        public bool[,] GetGameBoard()
        {
            bool[,] board = new bool[Width, Height];
            for (int x = 0; x < Width; x++)
            {
                for (int y = 0; y < Height; y++)
                {
                    board[x, y] = Board[x, y];
                }
            }
            return board;
        }

        public void SaveGame(string filename)
        {
            using (StreamWriter sw = new StreamWriter(filename))
            {
                sw.WriteLine("GoL");
                sw.WriteLine($"Width={Width}");
                sw.WriteLine($"Height={Height}");
                for (int x = 0; x < Width; x++)
                {
                    for (int y = 0; y < Height; y++)
                    {
                        sw.Write(Board[x, y] ? '1' : '0');
                    }
                    sw.WriteLine();
                }
            }
        }

        private void loadGame(string filename)
        {
            string row = "";
            using (StreamReader sr = new StreamReader(filename))
            {
                row = sr.ReadLine();
                if (row != "GoL")
                {
                    throw new FileLoadException("File format error, not GoL file");
                }
                int w = 0;
                int h = 0;
                row = sr.ReadLine();
                if (!row.StartsWith("Width="))
                {
                    throw new FileLoadException("File format error, not GoL file");
                }
                w = int.Parse(row.Substring("Width=".Length));
                row = sr.ReadLine();
                if (!row.StartsWith("Height="))
                {
                    throw new FileLoadException("File format error, not GoL file");
                }
                h = int.Parse(row.Substring("Height=".Length));

                Width = w;
                Height = h;
                Board = new bool[w, h];
                for (int x = 0; x < Width; x++)
                {
                    row = sr.ReadLine();
                    for (int y = 0; y < Height; y++)
                    {
                        Board[x, y]  = row[y] == '1'? true : false;
                    }
                }
            }
        }

    }
}
