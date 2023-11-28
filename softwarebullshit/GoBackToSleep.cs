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
    public partial class GoBackToSleep : Form
    {
        public GoBackToSleep()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SleepAfterMath afterMath = new SleepAfterMath();
            afterMath.Show();
            Hide();
        }
    }
}
