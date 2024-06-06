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
        private string name;
        public string Name { get => name; set => name = value; }
        private Image image;
        public Image Image { get => image; set => image = value; }
        private Image darkImage;
        public Image DarkImage { get => darkImage; set => darkImage = value; }
        public Player(string name, Image image, Image darkImage)
        {
            Name = name;
            Image = image;
            DarkImage = darkImage;
        }


    }
}
