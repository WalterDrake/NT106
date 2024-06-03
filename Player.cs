using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaroSpeedRun
{
    public class Player
    {
        private string name; // Ctrl + R +E

        public string Name { get => name; set => name = value; }
        public Image Mark { get => mark; set => mark = value; }

        private Image mark;
        public Color Color { get => color; set => color = value; }

        private Color color;

        public Player(string name, Color color)
        {
            this.name = name;
            this.color = color;
        }

    }
}