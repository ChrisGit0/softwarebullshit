using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace softwarebullshit
{
    public partial class SleepAfterMath : Form
    {
        public SleepAfterMath()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 again = new Form1();
            again.Show();
            Hide();
        }
    }
}
