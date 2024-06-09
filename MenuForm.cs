using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaroSpeedRun
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void help_bt_Click(object sender, EventArgs e)
        {
            Form help_ = new help();
            help_.ShowDialog();
        }

        private void about_bt_Click(object sender, EventArgs e)
        {
            Form about_ = new about();
            about_.ShowDialog();
        }

        private void offline_bt_Click(object sender, EventArgs e)
        {
            
            Form form = new offline();
            form.ShowDialog();
        }


        private void online_bt_Click(object sender, EventArgs e)
        {
            Form form = new Caro();
            form.ShowDialog();

        }
    }
}
