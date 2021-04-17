using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Selector_Hat
{
    public partial class inicio : Form
    {
        Timer timer = new Timer();
        public inicio()
        {
            InitializeComponent();
            timer.Interval = 5000;
            timer.Tick += timer_Tick;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            Hide();
            Form1 form1 = new Form1();
            form1.Show();
            
        }

        private void inicio_Load(object sender, EventArgs e)
        {
            timer.Start();
        }
    }
}
