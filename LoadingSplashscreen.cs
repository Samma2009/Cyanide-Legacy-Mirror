using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cyanide
{
    public partial class LoadingSplashscreen : Form
    {
        public LoadingSplashscreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Program.LoadProgram();
            timer1.Stop();
        }
    }
}
