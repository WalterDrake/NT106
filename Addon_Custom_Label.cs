using System.CodeDom;
using System.Drawing;
using System.Drawing.Text;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace CaroSpeedRun
{
    public class CustomLabel : System.Windows.Forms.Label
    {
        public CustomLabel()
        {
            BackColor = Color.Transparent;
            ForeColor = Color.White;
        }

        public void UseCustomFont(string name, int size, FontStyle fontStyle)
        {
            try
            {
                PrivateFontCollection modernFont = new PrivateFontCollection();

                modernFont.AddFontFile(name);

                Font = new Font(modernFont.Families[0], size, fontStyle);
            }
            catch { UseDefaultFont(); }
        }

        public void UseDefaultFont()
        {
            Font = new Font("Segoe UI", 9, FontStyle.Regular);
        }
    }
}